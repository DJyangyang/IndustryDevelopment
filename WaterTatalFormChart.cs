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
    public partial class WaterTatalFormChart : Form
    {
        private DataTable _dt;      //数据源
        private string _xFieldName; //x轴对应的数据源字段名
        private string _y1FieldName; //y轴对应的数据源字段名
        private string _legendText1; //图例文本
        private string _y2FieldName; //y轴对应的数据源字段名
        private string _legendText2; //图例文本
        private string _y3FieldName; //y轴对应的数据源字段名
        private string _legendText3; //图例文本
        private string _y4FieldName; //y轴对应的数据源字段名
        private string _legendText4; //图例文本

        public WaterTatalFormChart(DataTable Dt, string xfieldName, string Y1FieldName, string Y2FieldName, string Y3FieldName, string Y4FieldName, string lengendText1, string lengendText2, string lengendText3, string lengendText4)
        {
          
            InitializeComponent();
            this._dt = Dt;
            this._xFieldName = xfieldName;
            this._y1FieldName = Y1FieldName;
            this._y2FieldName = Y2FieldName;
            this._y3FieldName = Y3FieldName;
            this._y4FieldName = Y4FieldName;
            this._legendText1 = lengendText1;
            this._legendText2 = lengendText2;
            this._legendText3 = lengendText3;
            this._legendText4 = lengendText4;
        }

        private void WaterTatalFormChart_Load(object sender, EventArgs e)
        {
            try
            {
                chart5.DataSource = this._dt;
                chart5.DataBind();
                chart5.Series[0].ChartType = SeriesChartType.Column;
                chart5.Series[0].LegendText = this._legendText1;
                chart5.Series[0].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart5.Series[0].YValueMembers = this._y1FieldName;// 绑定的值（数据）(坐标纵轴)
               
                chart5.Series[1].ChartType = SeriesChartType.Column;
                chart5.Series[1].LegendText = this._legendText2;
                chart5.Series[1].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart5.Series[1].YValueMembers = this._y2FieldName;// 绑定的值（数据）(坐标纵轴)
               
                chart5.Series[2].ChartType = SeriesChartType.Column;
                chart5.Series[2].LegendText = this._legendText3;
                chart5.Series[2].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart5.Series[2].YValueMembers = this._y3FieldName;// 绑定的值（数据）(坐标纵轴)

                chart5.Series[3].ChartType = SeriesChartType.Column;
                chart5.Series[3].LegendText = this._legendText4;
                chart5.Series[3].XValueMember = this._xFieldName;//绑定的文字信息（名称）(坐标横轴)
                chart5.Series[3].YValueMembers = this._y4FieldName;// 绑定的值（数据）(坐标纵轴)
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
                    chart5.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                else if (sfd.FilterIndex == 2)
                    chart5.SaveImage(sfd.FileName, ChartImageFormat.Png);
                else
                    chart5.SaveImage(sfd.FileName, ChartImageFormat.Bmp);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
