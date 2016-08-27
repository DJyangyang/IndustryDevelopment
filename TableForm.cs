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
    public partial class TableForm : Form
    {
        #region 私有变量
        private string _mdbFileFullName;  //mdb文件完整路径名
        private DBOperate _dbOperate; //数据库操作类
        #endregion
        public TableForm()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();//打开data文件夹下的mdb文件
            openDialog.InitialDirectory = Application.StartupPath + @"\data";
            openDialog.Filter = "mdb文件|*.mdb";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _mdbFileFullName = openDialog.FileName;
               
                //读取数据库的表名，并默认加载第一个表
                _dbOperate = new DBOperate(_mdbFileFullName, "");
                List<string> tableNames = _dbOperate.GetTableNameList();
                cmbxTableNames1.DataSource = tableNames;
                cmbxTableNames1.SelectedIndex = 0;
            }
        }

        private void cmbxTableNames1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxTableNames1_TextChanged(object sender, EventArgs e)
        {
            if (cmbxTableNames1.DataSource == null || _dbOperate == null)
            {
                return;
            }
            DataTable dt = _dbOperate.GetDataTableByName(cmbxTableNames1.Text);
            dataGridView1.DataSource = dt;

            //重新加载表数据后，同步更新自变量、因变量字段值
            cmbxXField1.Items.Clear();
            cmbxYField1.Items.Clear();
            
            foreach (DataColumn dc in dt.Columns)
            {
                string fieldName = dc.ColumnName;
                cmbxXField1.Items.Add(fieldName);
                cmbxYField1.Items.Add(fieldName);
              
            }
            cmbxXField1.SelectedIndex = 0;
            cmbxYField1.SelectedIndex = 0;
           
            //设置成图范围的行范围
            txbxStartRowNum1.Text = "1";
            txbxEndRowNum1.Text = "14";
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void cmbxYField1_TextChanged(object sender, EventArgs e)
        {
            //更改值描述文本的默认值
            cmbxValueDescribe1.Text = cmbxYField1.Text;

        }

        private void btnChart1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbxTableNames1.Text))
            {
                MessageBox.Show("未加载任何数据表！");
                return;
            }
            if (String.IsNullOrEmpty(cmbxXField1.Text) || String.IsNullOrEmpty(cmbxYField1.Text))
            {
                MessageBox.Show("自变量和因变量不能为空");
                return;
            }

            //判断因变量字段是否是值字段，或者是否能强制转换成值
            DataTable sourceDt = dataGridView1.DataSource as DataTable;
            FieldValueType yFieldType = DataTableImp.GetFieldType(sourceDt, cmbxYField1.Text);
          
            if (yFieldType == FieldValueType.非值文本)
            {
                MessageBox.Show("因变量字段不可为非数值字段！");
                return;
            }
           

            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames = new List<string>() { cmbxXField1.Text, cmbxYField1.Text };
           
            int startRowNum = Convert.ToInt32(txbxStartRowNum1.Text) - 1; //DataTable的行号从0开始
            int endRowNum = Convert.ToInt32(txbxEndRowNum1.Text) - 1;
            //先进行行列筛选
            DataTable tempDt = DataTableImp.GetTableByFieldNamesAndRowNumRange1(sourceDt, fieldNames, startRowNum, endRowNum);
            //再进行因变量字段值的值类型转换
            DataTable resultDt = DataTableImp.ConvertFieldToType1(tempDt, cmbxYField1.Text, yFieldType);
          
            TableChartForm TabChartform = new TableChartForm(resultDt, cmbxXField1.Text, cmbxYField1.Text, cmbxValueDescribe1.Text);
            TabChartform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
