using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartMenuBar
{
    class frmDevCmd :MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;
        private ICommand cmd = null;
        frmDev pfrmDev;
        public frmDevCmd()
        {
            string str = @"..\Data\Image\Development\line.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;
        }
        #region ICommand成员
        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "变化趋势"; }
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
            get {return ""; }
        }

        public string Message
        {
            get { return "变化趋势"; }
        }

        public string Name
        {
            get { return "frmDevCmd"; }
        }

        public void OnClick()
        { 
           //System.Windows.Forms.MessageBox.Show("模块正在开发中！");
            pfrmDev = new frmDev();
            pfrmDev.ShowDialog(); 
        }

        public void OnCreate(MyPluginEngine.IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                pfrmDev = new frmDev();
                pfrmDev.Visible = false;
            }
        }

        public string Tooltip
        {
            get { return "变化趋势"; }
        }
        #endregion
    }
}
