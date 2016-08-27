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
    public partial class TotalForm : Form
    {
        #region 私有变量
        private string _mdbFileFullName;  //mdb文件完整路径名
        private DBOperate _dbOperate; //数据库操作类
        private DataTable resultDt;
      
        #endregion
        public TotalForm()
        {
            InitializeComponent();
        }

       

        private void btnBrowser2_Click(object sender, EventArgs e)
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
                cmbxTableNames3.DataSource = tableNames;
                cmbxTableNames3.SelectedIndex = 0;
            }
        }

        private void cmbxTableNames3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxTableNames3_TextChanged(object sender, EventArgs e)
        {
            if (cmbxTableNames3.DataSource == null || _dbOperate == null)
            {
                return;
            }
            DataTable dt = _dbOperate.GetDataTableByName(cmbxTableNames3.Text);
            dataGridView3.DataSource = dt;

            //重新加载表数据后，同步更新自变量、因变量字段值
            cmbxXField2.Items.Clear();
            cmbxY1Field2.Items.Clear();
            cmbxY2Field2.Items.Clear();
            cmbxY3Field2.Items.Clear();

            foreach (DataColumn dc in dt.Columns)
            {
                string fieldName = dc.ColumnName;
                cmbxXField2.Items.Add(fieldName);
                cmbxY1Field2.Items.Add(fieldName);
                cmbxY2Field2.Items.Add(fieldName);
                cmbxY3Field2.Items.Add(fieldName);

            }
            cmbxXField2.SelectedIndex = 0;
            cmbxY1Field2.SelectedIndex = 0;
            cmbxY2Field2.SelectedIndex = 0;
            cmbxY3Field2.SelectedIndex = 0;

            //设置成图范围的行范围
            txbxStartRowNum2.Text = "1";
            txbxEndRowNum2.Text = "14";
        }

        private void dataGridView3_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
      
        private void cmbxY1Field2_TextChanged(object sender, EventArgs e)
        {
            //更改值描述文本的默认值
            cmbxValueDescribe21.Text = cmbxY1Field2.Text;
        }

        private void cmbxY2Field2_TextChanged(object sender, EventArgs e)
        {
            //更改值描述文本的默认值
            cmbxValueDescribe22.Text = cmbxY2Field2.Text;
        }

        private void cmbxY3Field2_TextChanged(object sender, EventArgs e)
        {
            //更改值描述文本的默认值
            cmbxValueDescribe23.Text = cmbxY3Field2.Text;
        }
       

        private void btDraw_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbxTableNames3.Text))
            {
                MessageBox.Show("未加载任何数据表！");
                return;
            }
            if (String.IsNullOrEmpty(cmbxXField2.Text) || String.IsNullOrEmpty(cmbxY1Field2.Text)||String.IsNullOrEmpty(cmbxY2Field2.Text)||String.IsNullOrEmpty(cmbxY3Field2.Text))
            {
                MessageBox.Show("自变量和因变量不能为空");
                return;
            }

            //判断因变量字段是否是值字段，或者是否能强制转换成值
            DataTable sourceDt = dataGridView3.DataSource as DataTable;
            FieldValueType yFieldType1 = DataTableImp.GetFieldType(sourceDt, cmbxY1Field2.Text);
            FieldValueType yFieldType2 = DataTableImp.GetFieldType(sourceDt, cmbxY2Field2.Text);
            FieldValueType yFieldType3 = DataTableImp.GetFieldType(sourceDt, cmbxY3Field2.Text);

            if (yFieldType1 == FieldValueType.非值文本 || yFieldType2 == FieldValueType.非值文本 || yFieldType3 == FieldValueType.非值文本)
            {
                MessageBox.Show("因变量字段不可为非数值字段！");
                return;
            }
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames1 = new List<string>() { cmbxXField2.Text, cmbxY1Field2.Text };
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames2 = new List<string>() { cmbxXField2.Text, cmbxY2Field2.Text };
            //根据选择的自变量因变量字段，及行范围，新生成表
            List<string> fieldNames3 = new List<string>() { cmbxXField2.Text, cmbxY3Field2.Text };
            int startRowNum = Convert.ToInt32(txbxStartRowNum2.Text) - 1; //DataTable的行号从0开始
            int endRowNum = Convert.ToInt32(txbxEndRowNum2.Text) - 1;
            DataTable tempDt = DataTableImp.GetTableByFieldNamesAndRowNumRange2(sourceDt, fieldNames1, fieldNames2, fieldNames3, startRowNum, endRowNum);
            //再进行因变量字段值的值类型转换
            DataTable resultDt = DataTableImp.ConvertFieldToType2(tempDt, cmbxY1Field2.Text, cmbxY2Field2.Text, cmbxY3Field2.Text, yFieldType1, yFieldType2, yFieldType3);
            TotalFormChart totalFrom = new TotalFormChart(resultDt, cmbxXField2.Text, cmbxY1Field2.Text, cmbxY2Field2.Text, cmbxY3Field2.Text, cmbxValueDescribe21.Text, cmbxValueDescribe22.Text, cmbxValueDescribe23.Text);
            totalFrom.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
