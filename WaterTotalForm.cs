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
    public partial class WaterTotalForm : Form
    {
        #region 私有变量
        private string _mdbFileFullName;  //mdb文件完整路径名
        private DBOperate _dbOperate; //数据库操作类
        private DataTable resultDt;

        #endregion
        public WaterTotalForm()
        {
            InitializeComponent();
        }

        private void btnBrowser3_Click(object sender, EventArgs e)
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
                cmbxTableNames4.DataSource = tableNames;
                cmbxTableNames4.SelectedIndex = 0;
            }
        }

        private void cmbxTableNames4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxTableNames4_TextChanged(object sender, EventArgs e)
        {
            if (cmbxTableNames4.DataSource == null || _dbOperate == null)
            {
                return;
            }
            DataTable dt = _dbOperate.GetDataTableByName(cmbxTableNames4.Text);
            dataGridView4.DataSource = dt;

            //重新加载表数据后，同步更新自变量、因变量字段值
            cmbxXField3.Items.Clear();
            cmbxY1Field3.Items.Clear();
            cmbxY2Field3.Items.Clear();
            cmbxY3Field3.Items.Clear();
            cmbxY4Field3.Items.Clear();
            foreach (DataColumn dc in dt.Columns)
            {
                string fieldName = dc.ColumnName;
                cmbxXField3.Items.Add(fieldName);
                cmbxY1Field3.Items.Add(fieldName);
                cmbxY2Field3.Items.Add(fieldName);
                cmbxY3Field3.Items.Add(fieldName);
                cmbxY4Field3.Items.Add(fieldName);

            }
            cmbxXField3.SelectedIndex = 0;
            cmbxY1Field3.SelectedIndex = 0;
            cmbxY2Field3.SelectedIndex = 0;
            cmbxY3Field3.SelectedIndex = 0;
            cmbxY4Field3.SelectedIndex = 0;

            //设置成图范围的行范围
            txbxStartRowNum4.Text = "1";
            txbxEndRowNum4.Text = "14";
        }

        private void dataGridView4_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void cmbxY1Field3_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe31.Text = cmbxY1Field3.Text;
        }//更改值描述文本的默认值

        private void cmbxY2Field3_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe32.Text = cmbxY2Field3.Text;

        }//更改值描述文本的默认值

        private void cmbxY3Field3_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe33.Text = cmbxY3Field3.Text;
        }//更改值描述文本的默认值

        private void cmbxY4Field3_TextChanged(object sender, EventArgs e)
        {
            cmbxValueDescribe34.Text = cmbxY4Field3.Text;
        }//更改值描述文本的默认值

        private void btDraw2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbxTableNames4.Text))
            {
                MessageBox.Show("未加载任何数据表！");
                return;
            }
            if (String.IsNullOrEmpty(cmbxXField3.Text) || String.IsNullOrEmpty(cmbxY1Field3.Text) || String.IsNullOrEmpty(cmbxY2Field3.Text) || String.IsNullOrEmpty(cmbxY3Field3.Text) || String.IsNullOrEmpty(cmbxY3Field3.Text))
            {
                MessageBox.Show("自变量和因变量不能为空");
                return;
            }
            DataTable sourceDt = dataGridView4.DataSource as DataTable;
            FieldValueType y1FieldType = DataTableImp.GetFieldType(sourceDt, cmbxY1Field3.Text);
            FieldValueType y2FieldType = DataTableImp.GetFieldType(sourceDt, cmbxY2Field3.Text);
            FieldValueType y3FieldType = DataTableImp.GetFieldType(sourceDt, cmbxY3Field3.Text);
            FieldValueType y4FieldType = DataTableImp.GetFieldType(sourceDt, cmbxY4Field3.Text);
            if (y1FieldType == FieldValueType.非值文本 || y2FieldType == FieldValueType.非值文本 || y3FieldType == FieldValueType.非值文本 || y4FieldType == FieldValueType.非值文本)
            {
                MessageBox.Show("因变量字段不可为非数值字段！");
                return;
            }
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames31 = new List<string>() { cmbxXField3.Text, cmbxY1Field3.Text };
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames32 = new List<string>() { cmbxXField3.Text, cmbxY2Field3.Text };
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames33 = new List<string>() { cmbxXField3.Text, cmbxY3Field3.Text };
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames34 = new List<string>() { cmbxXField3.Text, cmbxY4Field3.Text };
            int startRowNum3 = Convert.ToInt32(txbxStartRowNum4.Text) - 1; //DataTable的行号从0开始
            int endRowNum3 = Convert.ToInt32(txbxEndRowNum4.Text) - 1;
            DataTable tempDt = DataTableImp.GetTableByFieldNamesAndRowNumRange3(sourceDt, fieldNames31, fieldNames32, fieldNames33,fieldNames34, startRowNum3, endRowNum3);
            //再进行因变量字段值的值类型转换
            DataTable resultDt = DataTableImp.ConvertFieldToType3(tempDt, cmbxY1Field3.Text, cmbxY2Field3.Text, cmbxY3Field3.Text,cmbxY4Field3.Text, y1FieldType, y2FieldType, y3FieldType,y4FieldType);
            WaterTatalFormChart waterFrm = new WaterTatalFormChart(resultDt, cmbxXField3.Text, cmbxY1Field3.Text, cmbxY2Field3.Text, cmbxY3Field3.Text, cmbxY4Field3.Text,cmbxValueDescribe31.Text, cmbxValueDescribe32.Text, cmbxValueDescribe33.Text,cmbxValueDescribe34.Text);
            waterFrm.ShowDialog();
        }

        private void btClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
