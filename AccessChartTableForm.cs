using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChartMenuBar
{
    public partial class AccessChartTableForm : Form
    {
        #region 私有变量
        private string _mdbFileFullName;  //mdb文件完整路径名
        private DBOperate _dbOperate; //数据库操作类
        #endregion

        public AccessChartTableForm()
        {
            InitializeComponent();
        }

        private void btnMdbBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();//打开data文件夹下的mdb文件
            openDialog.InitialDirectory = Application.StartupPath + @"\data";
            openDialog.Filter = "mdb文件|*.mdb";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _mdbFileFullName = openDialog.FileName;
                txbxMdbFileFullPath.Text = openDialog.FileName;
                //读取数据库的表名，并默认加载第一个表
                _dbOperate = new DBOperate(_mdbFileFullName, "");
                List<string> tableNames = _dbOperate.GetTableNameList();
                cmbxTableNames.DataSource = tableNames;
                cmbxTableNames.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 切换数据表中表的加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbxTableNames_TextChanged(object sender, EventArgs e)
        {
            if (cmbxTableNames.DataSource == null || _dbOperate == null)
            {
                return;
            }
            DataTable dt = _dbOperate.GetDataTableByName(cmbxTableNames.Text);
            dataGridView1.DataSource = dt;

            //重新加载表数据后，同步更新自变量、因变量字段值
            cmbxXField.Items.Clear();
            cmbxYField.Items.Clear();
            cmbxZField.Items.Clear();
            foreach (DataColumn dc in dt.Columns)
            {
                string fieldName = dc.ColumnName;
                cmbxXField.Items.Add(fieldName);
                cmbxYField.Items.Add(fieldName);
                cmbxZField.Items.Add(fieldName);
            }
            cmbxXField.SelectedIndex = 0;
            cmbxYField.SelectedIndex = 0;
            cmbxZField.SelectedIndex = 0;
            //设置成图范围的行范围
            txbxStartRowNum.Text = "1";
            txbxEndRowNum.Text = "14";
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        /// <summary>
        /// 因变量字段发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxYField_TextChanged(object sender, EventArgs e)
        {
            //更改值描述文本的默认值
            cmbxValueDescribe.Text = cmbxYField.Text;
        }
        private void cmbxZField_TextChanged(object sender, EventArgs e)
        {
            //更改值描述文本的默认值
            cmbxValueDescribe1.Text = cmbxZField.Text;
        }


        /// <summary>
        /// 生成统计图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbxTableNames.Text))
            {
                MessageBox.Show("未加载任何数据表！");
                return;
            }
            if (String.IsNullOrEmpty(cmbxXField.Text) || String.IsNullOrEmpty(cmbxYField.Text))
            {
                MessageBox.Show("自变量和因变量不能为空");
                return;
            }

            //判断因变量字段是否是值字段，或者是否能强制转换成值
            DataTable sourceDt = dataGridView1.DataSource as DataTable;
            FieldValueType yFieldType = DataTableImp.GetFieldType(sourceDt, cmbxYField.Text);
            FieldValueType zFieldType = DataTableImp.GetFieldType(sourceDt, cmbxZField.Text);
            if (yFieldType == FieldValueType.非值文本)
            {
                MessageBox.Show("因变量字段不可为非数值字段！");
                return;
            }
            if (zFieldType == FieldValueType.非值文本)
            {
                MessageBox.Show("因变量字段不可为非数值字段！");
                return;
            }

            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames = new List<string>() { cmbxXField.Text, cmbxYField.Text };
            List<string> fieldNames1 = new List<string>() { cmbxXField.Text, cmbxZField.Text };
            int startRowNum = Convert.ToInt32(txbxStartRowNum.Text) - 1; //DataTable的行号从0开始
            int endRowNum = Convert.ToInt32(txbxEndRowNum.Text)-1;
            //先进行行列筛选
            DataTable tempDt = DataTableImp.GetTableByFieldNamesAndRowNumRange(sourceDt, fieldNames,fieldNames1, startRowNum, endRowNum);
            //再进行因变量字段值的值类型转换
            DataTable resultDt = DataTableImp.ConvertFieldToType(tempDt, cmbxYField.Text,cmbxZField.Text, yFieldType,zFieldType);
            ChartForm chartFrm = new ChartForm(resultDt, cmbxXField.Text, cmbxYField.Text,cmbxZField.Text, cmbxValueDescribe.Text,cmbxValueDescribe1.Text);
            chartFrm.ShowDialog();
        }

        /// <summary>
        /// 导出一个统计表，包含自变量字段和因变量字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cmbxTableNames.Text) )
                {
                    MessageBox.Show("未加载任何数据表！");
                    return;
                }
                if (String.IsNullOrEmpty(cmbxXField.Text) || String.IsNullOrEmpty(cmbxYField.Text))
                {
                    MessageBox.Show("自变量和因变量不能为空");
                    return;
                }


                //根据选择的自变量因变量字段，及行范围，新生成表
                DataTable sourceDt = dataGridView1.DataSource as DataTable;
                List<string> fieldNames = new List<string>() { cmbxXField.Text, cmbxYField.Text };
                List<string> fieldNames1 = new List<string>() { cmbxXField.Text, cmbxZField.Text };
                int startRowNum = Convert.ToInt32(txbxStartRowNum.Text) - 1; //DataTable的行号从0开始
                int endRowNum = Convert.ToInt32(txbxEndRowNum.Text) - 1;
                DataTable resultDt = DataTableImp.GetTableByFieldNamesAndRowNumRange(sourceDt, fieldNames,fieldNames1, startRowNum, endRowNum);
                

                SaveFileDialog saveFileDlg = new System.Windows.Forms.SaveFileDialog();
                saveFileDlg.Title = "导出统计表";
                saveFileDlg.Filter = "Excel文件|*.xls;*.xlsx";
                saveFileDlg.FileName = cmbxValueDescribe.Text;

                string excelFile;
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    excelFile = saveFileDlg.FileName;

                    if (ExcelFileOperate.SaveDataTableToXls(resultDt, excelFile))
                    {
                        MessageBox.Show("数据导出成功！保存到" + excelFile);
                    }
                    else
                    {
                        MessageBox.Show("导出失败！");
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("统计表导出失败！");
                return;
            }
        }

        /// <summary>
        /// 关闭当前窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccessChartTableForm_Load(object sender, EventArgs e)
        {

        }

        private void txbxMdbFileFullPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     









    }
}
