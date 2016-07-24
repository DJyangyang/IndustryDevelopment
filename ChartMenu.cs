using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPluginEngine;

namespace ChartMenuBar
{
    class ChartMenu : IMenuDef
    {
        #region IMenuDef成员
        public string Caption
        {
            get { return "产业发展"; }
        }

        public string Name
        {
            get { return "ChartMenu"; }
        }

        public long ItemCount
        {
            get { return 2; }
        }

        public void GetItemInfo(int pos, ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "ChartMenuBar.AccessChartCmd";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "ChartMenuBar.frmDevCmd";
                    itemDef.Group = false;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
