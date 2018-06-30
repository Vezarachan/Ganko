using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ganko.Commons.DBHelper
{
    /// <summary>
    /// SQLite嵌入式数据库的数据操作模块
    /// </summary>
    class SQLiteDBHelper : ICloneable
    {
        private readonly SQLiteConnection conn = new SQLiteConnection();

        private SQLiteDBHelper()
        {
            SQLiteConnectionStringBuilder sqLiteConnectionString = new SQLiteConnectionStringBuilder();
            sqLiteConnectionString.DataSource = "gankDB.db";
            sqLiteConnectionString.Version = 3;
            conn.ConnectionString = sqLiteConnectionString.ConnectionString;
        }

        public object Clone()
        {
            return new SQLiteDBHelper().MemberwiseClone();
        }

        public static SQLiteDBHelper GetInstance()
        {
            SQLiteDBHelper dbHelper = new SQLiteDBHelper();
            try
            {
                return (SQLiteDBHelper) dbHelper.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public SQLiteConnection Conn
        {
            get { return conn; }
        }
    }
}
