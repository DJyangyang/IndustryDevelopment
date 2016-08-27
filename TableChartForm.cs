using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartMenuBar
{
    public partial class TableChartForm : Form
    {
        private DataTable _dt;      //数据源
        private string _xFieldName; //x轴对应的数据源字段名
        private string _yFieldName; //y轴对应的数据源字段名
        private string _legendText; //图例文本

        public TableChartForm(DataTable dt, string xFieldName, string yFieldName, string legendText)
        {
            InitializeComponent(); 
            this._dt = dt;
            this._xFieldName = xFieldName;
            this._yFieldName = yFieldName;
            this._legendText = legendText;
        }

        //public TableChartForm(DataTable dt, string xFieldName, string yFieldName, string legendText)
        //{
        //    // TODO: Complete member initialization
          
        //}

        private void TableChartForm_Load(object sender, EventArgs e)
        {
            try{
            chart2.DataSource = this._dt;
            chart2.DataBind();
            chart2.Series[0].ChartType = SeriesChartType.Spline;
            chart2.Series[0].LegendText = this._legendText;
            chart2.Series[0].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
            chart2.Series[0].YValueMembers = this._yFieldName;// 绑定的值（数据）(坐标纵轴)
         }
            catch (System.Exception ex)
            {
                return;
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存Chart控件的图片
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG文件|*.jpg|PNG文件|*.png|BMP文件|*.bmp";
            sfd.Title = "导出统计图";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FilterIndex == 1)
                    chart2.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                else if (sfd.FilterIndex == 2)
                    chart2.SaveImage(sfd.FileName, ChartImageFormat.Png);
                else
                    chart2.SaveImage(sfd.FileName, ChartImageFormat.Bmp);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
