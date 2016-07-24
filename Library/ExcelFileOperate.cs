using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using ExcelLib = Microsoft.Office.Interop.Excel;


namespace ChartMenuBar
{
    public class ExcelFileOperate
    {
        
        /// <summary>
        /// 从Excel文件中读取数据，返回数据集
        /// </summary>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        public static DataSet GetDataSetFromExcel(string strFileName)         //strFileName指定的路径+文件名.xls
        {
            if (strFileName != "")
            {
                //string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strFileName + ";Extended Properties=Excel 8.0";
                string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFileName + ";Extended Properties='Excel 12.0; HDR=yes; IMEX=0'";
                string sql = "select * from [Sheet1$]";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                }
                catch(Exception ex)
                {
                    return null;
                }
                return ds;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将数据表写入到Excel文件中
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="xlsPath">Excel文件完整路径</param>
        /// <returns></returns>
        public static bool SaveDataTableToXls(DataTable dt, string xlsPath)
        {
            ExcelLib.Application Excel_App = null;
            Excel_App = new ExcelLib.Application();
            Excel_App.Visible = false;
            Excel_App.DisplayAlerts = false;

            if (File.Exists(xlsPath))
            {
                File.Delete(xlsPath);
            }

            var wb = Excel_App.Application.Workbooks.Add(true);
            var sh = wb.ActiveSheet;

            int currentRow = 1;
            int startCol = 1;
            int colCount = dt.Columns.Count;
            int rowCount = dt.Rows.Count;

            // write title
            for (int i = 0; i < colCount; i++)
            {
                sh.Cells[currentRow, startCol + i]
                    = dt.Columns[i].Caption;
            }

            // write data   可能因数据量大而耗时长，后期可写进度条
            for (int i = 0; i < rowCount; i++)
            {
                var row = dt.Rows[i];
                currentRow++;
                for (int ii = 0; ii < colCount; ii++)
                {
                    sh.Cells[currentRow, startCol + ii] = row[ii];
                }
            }

            // save excel
            wb.Close(true, xlsPath);
            return true;
        }

    }
}
