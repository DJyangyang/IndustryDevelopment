using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartMenuBar
{
    class TotalFormCmd:MyPluginEngine.ICommand
    {
          private MyPluginEngine.IApplication hk;
        private Bitmap m_hBitmap;

        public TotalFormCmd()
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
            get { return "分行业生产总值"; }
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
            get { return "分行业生产总值"; }
        }

        public string Name
        {
            get { return "TotalFormCmd"; }
        }

        public void OnClick()
        {
           
            TotalForm totalfrm = new TotalForm();
            totalfrm.ShowDialog();
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
            get { return "分行业生产总值"; }
        }
        #endregion
    }
}
