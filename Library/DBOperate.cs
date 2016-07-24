using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace ChartMenuBar
{
    public class DBOperate
    {
        private OleDbConnection _conn;

        public DBOperate(string mdbFilePath, string password)
        {
            _conn = GetAccessConnection(mdbFilePath, password);
        }

        /// <summary>
        /// 获取一个Access数据库的连接
        /// </summary>
        /// <param name="mdbFilePath"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public OleDbConnection GetAccessConnection(string mdbFilePath, string password)
        {
          try
            {
                string StrConn = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                             "Data Source =" + mdbFilePath +
                               "; Persist Security Info = False;" +
                             "Jet OLEDB:Database Password = " + password;

                //建立数据库引擎连接
                OleDbConnection conn = new OleDbConnection(StrConn);//数据源开放链接
                if (conn.State == ConnectionState.Closed)
                    conn.Open();//判断数据源状态，使数据源保持开放状态

                return conn;
            }
            catch (System.Exception ex)
            {
                return null;
            }                     
        }

        /// <summary>
        /// 取所有表名
        /// </summary>
        /// <returns></returns>
        public List<string> GetTableNameList()
        {
            List<string> list = new List<string>();
            try
            {
                if (this._conn == null)
                    return null;

                if (this._conn.State == ConnectionState.Closed)
                    _conn.Open();
                DataTable dt = _conn.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    if (row[3].ToString() == "TABLE")
                        list.Add(row[2].ToString());
                }
                return list;
            }
            catch (Exception e)
            { 
                return null;
            }           
        }

        /// <summary>
        /// 从Access数据库中取出指定数据表中的全部数据
        /// </summary>
        /// <param name="mdbFilePath">mdb文件完整路径名</param>
        /// <param name="password">密码</param>
        /// <param name="dbTableName">sql语句</param>
        /// <returns></returns>
        public DataTable GetDataTableByName(string dbTableName)
        {
            try
            {
                if (this._conn == null)
                    return null;

                if (this._conn.State == ConnectionState.Closed)
                    _conn.Open();

                //建立适配器，通过SQL语句去搜索数据库
                OleDbDataAdapter myda = new OleDbDataAdapter("select * from " + dbTableName, this._conn);
                //建立数据集
                DataSet myds = new DataSet();
                //用FILL的方式将适配器已经连接好的数据表填充到数据集myds这张表
                myda.Fill(myds, dbTableName);
                return myds.Tables[0];
            }
            catch (System.Exception ex)
            {
                return null;
            }
            
        }

        /// <summary>
        /// 从Access数据库中取出指定数据表中的全部数据
        /// </summary>
        /// <param name="mdbFilePath">mdb文件完整路径名</param>
        /// <param name="password">密码</param>
        /// <param name="dbTableName">sql语句</param>
        /// <returns></returns>
        public DataSet GetDataSetFromDB(string mdbFilePath, string password, string dbTableName)
        {
            string StrConn = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                             "Data Source =" + mdbFilePath +
                             "; Persist Security Info = False;" +
                             "Jet OLEDB:Database Password = " + password;
            

            //建立数据库引擎连接
            OleDbConnection strConnection = new OleDbConnection(StrConn);
            //建立适配器，通过SQL语句去搜索数据库
            OleDbDataAdapter myda = new OleDbDataAdapter("select * from " + dbTableName, strConnection);
            //建立数据集
            DataSet myds = new DataSet();
            //用FILL的方式将适配器已经连接好的数据表填充到数据集myds这张表
            myda.Fill(myds, dbTableName);
            return myds;
        }

        /// <summary>
        /// 根据SQL语句从Access数据库中取出指定数据
        /// </summary>
        /// <param name="sqlStr">sql语句</param>
        /// <returns></returns>
        public DataTable GetDataTableBySQL(string sqlStr)
        {
            try
            {
                if (this._conn == null)
                    return null;

                if (this._conn.State == ConnectionState.Closed)
                    _conn.Open();

                //建立适配器，通过SQL语句去搜索数据库
                OleDbDataAdapter myda = new OleDbDataAdapter(sqlStr, _conn);
                //建立数据集
                DataSet myds = new DataSet();
                //用FILL的方式将适配器已经连接好的数据表填充到数据集myds这张表
                myda.Fill(myds);
                return myds.Tables[0];
            }
            catch (System.Exception ex)
            {
                return null;
            }
            
        }

        /// <summary>
        /// 根据SQL语句从Access数据库中取出指定数据
        /// </summary>
        /// <param name="mdbFilePath">mdb文件完整路径名</param>
        /// <param name="password">密码</param>
        /// <param name="sqlStr">sql语句</param>
        /// <returns></returns>
        public DataSet GetDataSetBySQL(string mdbFilePath, string password, string sqlStr)
        {
            string StrConn = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                             "Data Source =" + mdbFilePath +
                             "; Persist Security Info = False;" +
                             "Jet OLEDB:Database Password = " + password;


            //建立数据库引擎连接
            OleDbConnection strConnection = new OleDbConnection(StrConn);
            //建立适配器，通过SQL语句去搜索数据库
            OleDbDataAdapter myda = new OleDbDataAdapter(sqlStr, strConnection);
            //建立数据集
            DataSet myds = new DataSet();
            //用FILL的方式将适配器已经连接好的数据表填充到数据集myds这张表
            int index = sqlStr.IndexOf("from");
            string tableName = sqlStr.Substring(index + 5).Trim();
            myda.Fill(myds, tableName);
            return myds;
        }
    }
}
