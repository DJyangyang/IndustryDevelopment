using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZedGraph;

namespace ChartMenuBar
{
    public partial class frmDev : DevComponents.DotNetBar.OfficeForm
    {
        private string sConn = null;
        private OleDbConnection pConn = null;
        private DataTable dt = null;
        private PointPairList list1 = null, list2 = null, list3 = null, list4 = null;
        public frmDev()
        {
            InitializeComponent();
            this.dgDataSource.ReadOnly = true;
            this.dgDataSource.AllowUserToAddRows = false;
            //禁用Glass主题
            this.EnableGlass = false;
            //不显示最大化最小化按钮
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //去除图标
            this.ShowIcon = false;

        }
        private void frmDev_Load(object sender, EventArgs e)
        {
            LoadData();
            CreateMutiLineChart();

        }

        private void CreateMutiLineChart()
        {
            dgDataSource.DataSource = dt;

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            myPane.GraphObjList.Clear();
            myPane.Title.Text = "不同环境下用水总量对比模拟";
            myPane.XAxis.Title.Text = "年份";
            myPane.YAxis.Title.Text = "用水总量";
            list1 = new PointPairList();
            list2 = new PointPairList();
            list3 = new PointPairList();
            list4 = new PointPairList();
            LineItem myCurve1 = null, myCurve2 = null, myCurve3 = null, myCurve4 = null;
            myCurve1 = myPane.AddCurve("农业",
               list1, Color.Red, SymbolType.Diamond);
            myCurve2 = myPane.AddCurve("工业",
                list2, Color.Blue, SymbolType.Circle);
            myCurve3 = myPane.AddCurve("生活",
               list3, Color.Green, SymbolType.Star);
            myCurve4 = myPane.AddCurve("生态",
                list4, Color.Orange, SymbolType.Square);
            myPane.Title.FontSpec.FontColor = Color.Green;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.LightGray;
            myPane.YAxis.MajorGrid.Color = Color.LightGray;
            myPane.Legend.Position = ZedGraph.LegendPos.Bottom;
            myCurve1.Line.Width = 1.0F;
            myCurve2.Line.Width = 1.0F;
            myCurve3.Line.Width = 1.0F;
            myCurve4.Line.Width = 1.0F;


            myCurve1.Symbol.Size = 2.0F;
            myCurve2.Symbol.Size = 2.0F;
            myCurve3.Symbol.Size = 2.0F;
            myCurve4.Symbol.Size = 2.0F;

            myCurve1.Symbol.Fill = new Fill(Color.White);
            myCurve2.Symbol.Fill = new Fill(Color.White);
            myCurve3.Symbol.Fill = new Fill(Color.White);
            myCurve4.Symbol.Fill = new Fill(Color.White);


            myPane.Chart.Fill = new Fill(Color.White,
                Color.FromArgb(255, 255, 210), -45F);


            TextObj myText = new TextObj("Interesting\nPoint", 230F, 70F);
            myText.FontSpec.FontColor = Color.Red;
            myText.Location.AlignH = AlignH.Center;
            myText.Location.AlignV = AlignV.Top;
            myPane.GraphObjList.Add(myText);
            ArrowObj myArrow = new ArrowObj(Color.Red, 12F, 230F, 70F, 280F, 55F);
            myPane.GraphObjList.Add(myArrow);

            myPane.AxisChange();
            zedGraphControl1.Refresh();




        }

        private void LoadData()
        {
            sConn = @"Provider = Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + @"\Data\dqhp1.mdb;Jet OLEDB:Database Password=dqhpdata";
            if (pConn == null)
                pConn = new OleDbConnection(sConn);
            if (pConn.State == ConnectionState.Closed)
                pConn.Open();
            OleDbCommand cmd = pConn.CreateCommand();
            cmd.CommandText = "Select id,年份,总用水量,农业,工业,生活,生态 From water";
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds, "water");
            if (dt == null)
                dt = new DataTable();
            dt = ds.Tables["water"];
        }


        private void frmDev_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (pConn.State == ConnectionState.Open)
                pConn.Close();
            if (pConn != null)
                pConn = null;

        }
        private void LoadHistoryData()
        {
            while (list1.Count > 1)
            {
                list1.RemoveAt(1);
                list2.RemoveAt(1);
                list3.RemoveAt(1);
                list4.RemoveAt(1);

            }
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                double x = double.Parse(dt.Rows[i]["年份"].ToString().Trim());
                double y1 = double.Parse(dt.Rows[i]["农业"].ToString().Trim());
                double y2 = double.Parse(dt.Rows[i]["工业"].ToString().Trim());
                double y3 = double.Parse(dt.Rows[i]["生活"].ToString().Trim());
                double y4 = double.Parse(dt.Rows[i]["生态"].ToString().Trim());
                list1.Add(x, y1);
                list2.Add(x, y2);
                list3.Add(x, y3);
                list4.Add(x, y4);
                zedGraphControl1.GraphPane.XAxis.Scale.MaxAuto = true;

                this.zedGraphControl1.AxisChange();
                this.zedGraphControl1.Refresh();
            }

        }
        private void LoadSimulationData()
        {
            int iRowCount = dt.Rows.Count - 1;
            if (iRowCount > 10)
            {
                for (int i = iRowCount; i >= 10; i--)
                {
                    dt.Rows.RemoveAt(i);
                    list1.RemoveAt(i);
                    list2.RemoveAt(i);
                    list3.RemoveAt(i);
                    list4.RemoveAt(i);
                }
            }

            double year;

            //for (int i = 0; i < 1; i++)
            //{
                Thread.Sleep(200);
                //产生模拟数据
                //dRate = dRate - dRateTemp;
                int iRowMaxIndex = dt.Rows.Count - 1;
                DataRow dr = dt.NewRow();
                year = double.Parse(dt.Rows[iRowMaxIndex]["年份"].ToString().Trim());

                dr["id"] = int.Parse(dt.Rows[iRowMaxIndex]["id"].ToString().Trim()) + 1;
                dr["年份"] = int.Parse(dt.Rows[iRowMaxIndex]["年份"].ToString().Trim()) + 1;


                dt.Rows.Add(dr);

                //创建曲线图

                double x = double.Parse(dt.Rows[iRowMaxIndex]["年份"].ToString().Trim());
                double y1 = double.Parse(dt.Rows[iRowMaxIndex]["农业"].ToString().Trim());
                double y2 = double.Parse(dt.Rows[iRowMaxIndex]["工业"].ToString().Trim());
                double y3 = double.Parse(dt.Rows[iRowMaxIndex]["生活"].ToString().Trim());
                double y4 = double.Parse(dt.Rows[iRowMaxIndex]["生态"].ToString().Trim());
                list1.Add(x, y1);
                list2.Add(x, y2);
                list3.Add(x, y3);
                list4.Add(x, y4);
                zedGraphControl1.GraphPane.XAxis.Scale.MaxAuto = true;

                this.zedGraphControl1.AxisChange();
                this.zedGraphControl1.Refresh();

                this.dgDataSource.DataSource = dt;
                this.dgDataSource.Refresh();
            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadHistoryData();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
