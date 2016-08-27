using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartMenuBar
{
    class WaterTotalFormCmd:MyPluginEngine.ICommand
    {
         private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;

        public WaterTotalFormCmd()
        {
            string str = @"..\Data\Image\Development\chart.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }

        #region ICommond成员

        public Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "不同情境用水总量"; }
        }

        public string Category
        {
            get { return "ChartMenu"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "不同情境用水总量"; }
        }

        public string Name
        {
            get { return "TableFormCmd"; }
        }

        public void OnClick()
        {
            //AccessChartTableForm accessFrm = new AccessChartTableForm();
            //accessFrm.ShowDialog();
            //WForm tableform = new TableForm();
            //tableform.ShowDialog();
            WaterTotalForm waterfrms=new WaterTotalForm();
            waterfrms.ShowDialog();
        }


        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
            }
        }

        public string Tooltip
        {
            get { return "不同情境用水总量"; }
        }
        #endregion
    }
    }

