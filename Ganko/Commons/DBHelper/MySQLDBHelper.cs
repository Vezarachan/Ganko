using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Ganko.Commons.Models;
using Ganko.Commons.Security;
using MySql.Data.MySqlClient;

namespace Ganko.ApiProcessor
{
    /// <summary>
    /// 数据库操作模块，用于进行数据的操作
    /// </summary>
    class MySQLDBHelper : ICloneable
    {
        //MySQL连接的声明，只读
        private readonly MySqlConnection conn = new MySqlConnection();

        /// <summary>
        /// 私有的构造方法，该类不能被实例化
        /// </summary>
        private MySQLDBHelper()
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.SslMode = MySqlSslMode.None;
            connectionString.Database = "Ganko";
            connectionString.Server = "127.0.0.1";
            connectionString.Port = 3306;
            connectionString.UserID = "gankio";
            connectionString.Password = "GankIO";
            connectionString.Pooling = true;
            connectionString.MinimumPoolSize = 0;
            connectionString.MaximumPoolSize = 200;
            connectionString.ConnectionTimeout = 10;
            conn.ConnectionString = connectionString.ConnectionString;
        }

        //ICloneable接口的实现
        public object Clone()
        {
            return new MySQLDBHelper().MemberwiseClone();
        }

        //获取连接,以便进行一些拓展操作
        public MySqlConnection Conn
        {
            get { return conn; }
        }

        //获得DBHelper实例
        public static MySQLDBHelper Instance
        {
            get
            {   MySQLDBHelper dbHelper = new MySQLDBHelper();
                return (MySQLDBHelper)dbHelper.Clone();
            }
        }

        #region Add Data to DB

        /// <summary>
        /// 插入所有的结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="results"></param>
        public void AddAllResults<T>(List<T> results) where T : ResultModel
        {
            var sqlmain = "INSERT INTO resultTbl VALUES (@_id, @createdAt, @desc, @publishedAt, @source, @type, @url, @used, @who);";
            var sqlimages = "INSERT INTO images VALUES (@_idimage, @imageurl);";
            try
            {
                conn.Open();
                results.ForEach(item =>
                {
                    MySqlParameter[] parameters =
                    {
                        new MySqlParameter("@_id", item._id),
                        new MySqlParameter("@createdAt", item.createdAt),
                        new MySqlParameter("@desc", item.desc),
                        new MySqlParameter("@publishedAt", item.publishedAt),
                        new MySqlParameter("@source", item.source),
                        new MySqlParameter("@type", item.type),
                        new MySqlParameter("@url", item.url),
                        new MySqlParameter("@used", item.used),
                        new MySqlParameter("@who", item.who)
                    };

                    if (item.images != null)
                    {
                        item.images.ForEach(image =>
                        {
                            MySqlParameter[] imageparameters =
                            {
                                new MySqlParameter("@_idimage", item._id),
                                new MySqlParameter("@imageurl", image),
                            };
                            var sqlImageCmd = new MySqlCommand(sqlimages, conn);
                            sqlImageCmd.Parameters.AddRange(imageparameters);
                            sqlImageCmd.ExecuteNonQuery();
                        });
                    }

                    MySqlCommand sqlCmd = new MySqlCommand(sqlmain, conn);
                    sqlCmd.Parameters.AddRange(parameters);
                    sqlCmd.ExecuteNonQuery();
                });
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 添加单个结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        public void AddResult<T>(T result) where T : ResultModel
        {
            var sqlmain = "INSERT INTO resultTbl VALUES (@_id, @createdAt, @desc, @publishedAt, @source, @type, @url, @used, @who);";
            var sqlimages = "INSERT INTO images VALUES (@_idimage, @imageurl);";
            try
            {
                conn.Open();
                MySqlParameter[] sqlParameters =
                {
                    new MySqlParameter("@_id", result._id),
                    new MySqlParameter("@createdAt", result.createdAt),
                    new MySqlParameter("@desc", result.desc),
                    new MySqlParameter("@publishedAt", result.publishedAt),
                    new MySqlParameter("@source", result.source),
                    new MySqlParameter("@type", result.type),
                    new MySqlParameter("@url", result.url),
                    new MySqlParameter("@used", result.used),
                    new MySqlParameter("@who", result.who)
                };

                if (result.images != null)
                {
                    result.images.ForEach(image =>
                    {
                        MySqlParameter[] imagesParameter =
                        {
                            new MySqlParameter("@_idimage", result._id),
                            new MySqlParameter("@imageurl", image),
                        };
                        var sqlImageCmd = new MySqlCommand(sqlimages, conn);
                        sqlImageCmd.Parameters.AddRange(imagesParameter);
                        sqlImageCmd.ExecuteNonQuery();
                    });
                }

                MySqlCommand sqlCmd = new MySqlCommand(sqlmain, conn);
                sqlCmd.Parameters.AddRange(sqlParameters);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 注册添加用户，不加密
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            var sqlAddUser = "INSERT INTO usrLogin VALUES (@account, @password)";
            try
            {
                conn.Open();
                MySqlParameter[] sqlParameters =
                {
                    new MySqlParameter("@account", user.Account),
                    new MySqlParameter("@password", user.Password)
                };
                var sqlCmd = new MySqlCommand(sqlAddUser, conn);
                sqlCmd.Parameters.AddRange(sqlParameters);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 更加安全的注册添加用户，将密码解析为32位16进制的MD5散列值
        /// </summary>
        /// <param name="user"></param>
        public void AddUserHash(User user)
        {
            var sqlAddUser = "INSERT INTO usrHash VALUES (@account, @password)";
            try
            {
                conn.Open();
                MySqlParameter[] sqlParameters =
                {
                    new MySqlParameter("@account", user.Account),
                    new MySqlParameter("@password", user.Password),
                };
                var sqlCmd = new MySqlCommand(sqlAddUser, conn);
                sqlCmd.Parameters.AddRange(sqlParameters);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddUserDetail(UserDetails userDetails)
        {
            var sqlAddUser = "INSERT INTO usrDetail VALUES (@account, @age, @company, @position)";
            try
            {
                conn.Open();
                MySqlParameter[] sqlParameters =
                {
                    new MySqlParameter("@account", userDetails.Account),
                    new MySqlParameter("@age", userDetails.Age),
                    new MySqlParameter("@company", userDetails.Company),
                    new MySqlParameter("@position", userDetails.Position) 
                };
                var sqlCmd = new MySqlCommand(sqlAddUser, conn);
                sqlCmd.Parameters.AddRange(sqlParameters);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region Get Data From DB

        /// <summary>
        /// 根据类别获取结果（除图片urls）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetResultExceptImagesByCategory<T>() where T : ResultModel, new()
        {
            var sqlGetResult = $"SELECT * FROM resultTbl WHERE typeof = '{typeof(T).Name}' ORDER BY RAND() LIMIT 8";
            var ResultList = new List<T>();
            try
            {
                conn.Open();
                var sqlcmd = new MySqlCommand(sqlGetResult, conn);
                var sqlReader = sqlcmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    var result = new T();
                    result._id = sqlReader.GetString(0);
                    result.createdAt = sqlReader.GetDateTime(1);
                    result.desc = sqlReader.GetString(2);
                    result.publishedAt = sqlReader.GetDateTime(3);
                    result.source = sqlReader.GetString(4);
                    result.type = sqlReader.GetString(5);
                    result.url = sqlReader.GetString(6);
                    result.used = sqlReader.GetString(7);
                    result.who = sqlReader.GetString(8);
                    result.images = null;
                    ResultList.Add(result);
                }
                sqlcmd.Dispose();
                sqlReader.Dispose();
                return ResultList;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 根据描述从数据库获取图片urls
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public List<string> GetImagesByDesc(string desc)
        {
            var sqlGetImages = "SELECT * FROM images WHERE description = @desc";
            var sqlParameter = new MySqlParameter("@desc", MySqlDbType.VarChar, 120, desc);
            List<string> imageUrlList = new List<string>();
            try
            {
                conn.Open();
                var sqlcmd = new MySqlCommand(sqlGetImages, conn);
                sqlcmd.Parameters.Add(sqlParameter);
                var sqlReader = sqlcmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    var imagesUrl = sqlReader.GetString(1);
                    imageUrlList.Add(imagesUrl);
                }
                sqlcmd.Dispose();
                sqlReader.Dispose();
                return imageUrlList;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 根据推送人姓名返回结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="who"></param>
        /// <returns></returns>
        public List<T> GetResultExceptImagesByWho<T>(string who) where T : ResultModel, new()
        {
            var sqlGetImages = "SELECT * FROM resultTbl WHERE who = @who";
            var sqlParameter = new MySqlParameter("@who", MySqlDbType.VarChar, 40, who);
            List<T> ResultList = new List<T>();
            try
            {
                conn.Open();
                var sqlcmd = new MySqlCommand(sqlGetImages, conn);
                sqlcmd.Parameters.Add(sqlParameter);
                var sqlReader = sqlcmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    var result = new T();
                    result._id = sqlReader.GetString(0);
                    result.createdAt = sqlReader.GetDateTime(1);
                    result.desc = sqlReader.GetString(2);
                    result.publishedAt = sqlReader.GetDateTime(3);
                    result.source = sqlReader.GetString(4);
                    result.type = sqlReader.GetString(5);
                    result.url = sqlReader.GetString(6);
                    result.used = sqlReader.GetString(7);
                    result.who = sqlReader.GetString(8);
                    result.images = null;
                    ResultList.Add(result);
                }
                sqlcmd.Dispose();
                sqlReader.Dispose();
                return ResultList;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 根据发布时间返回某年某月结果根据发布年月返回结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public List<T> GetResultExceptImagesByPublishedAt<T>(DateTime dateTime) where T : ResultModel, new()
        {
            var sqlGetResult = "SELECT * FROM resultTbl WHERE YEAR(publishedAt) = @YEAR AND MONTH(publishedAt) = @MONTH";
            var year = dateTime.Year;
            var month = dateTime.Month;
            List<T> ResultList = new List<T>();
            try
            {
                MySqlParameter[] sqlParameter =
                {
                    new MySqlParameter("@YEAR", year),
                    new MySqlParameter("@MONTH", month)
                };

                conn.Open();
                var sqlCmd = new MySqlCommand(sqlGetResult, conn);
                sqlCmd.Parameters.AddRange(sqlParameter);
                var sqlReader = sqlCmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    var result = new T();
                    result._id = sqlReader.GetString(0);
                    result.createdAt = sqlReader.GetDateTime(1);
                    result.desc = sqlReader.GetString(2);
                    result.publishedAt = sqlReader.GetDateTime(3);
                    result.source = sqlReader.GetString(4);
                    result.type = sqlReader.GetString(5);
                    result.url = sqlReader.GetString(6);
                    result.used = sqlReader.GetString(7);
                    result.who = sqlReader.GetString(8);
                    result.images = null;
                    ResultList.Add(result);
                }
                sqlCmd.Dispose();
                sqlReader.Dispose();
                return ResultList;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 根据用户名获得用户信息
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public User GetUserByAccount(string accountName)
        {
            var sqlGetUser = "SELECT * FROM usrLogin WHERE _account = @account";
            try
            {
                conn.Open();
                MySqlParameter sqlParameter = new MySqlParameter("@account", accountName);
                var sqlCmd = new MySqlCommand(sqlGetUser, conn);
                sqlCmd.Parameters.Add(sqlParameter);
                var sqlReader = sqlCmd.ExecuteReader();
                var userInfo = new User();
                while (sqlReader.Read())
                {
                    userInfo.Account = sqlReader.GetString(0);
                    userInfo.Password = sqlReader.GetString(1);
                }
                sqlCmd.Dispose();
                sqlReader.Dispose();
                return userInfo;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 根据用户名获取用户信息，密码为MD5加密字符串
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public User GetUserByAccountHash(string accountName)
        {
            var sqlGetUser = "SELECT * FROM usrHash WHERE _account = @account";
            try
            {
                conn.Open();
                MySqlParameter sqlParameter = new MySqlParameter("@account", accountName);
                var sqlCmd = new MySqlCommand(sqlGetUser, conn);
                sqlCmd.Parameters.Add(sqlParameter);
                var sqlReader = sqlCmd.ExecuteReader();
                var userInfo = new User();
                while (sqlReader.Read())
                {
                    userInfo.Account = sqlReader.GetString(0);
                    userInfo.Password = sqlReader.GetString(1);
                }
                sqlCmd.Dispose();
                sqlReader.Dispose();
                return userInfo;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public UserDetails GetUserDetailsByAccount(string accountName)
        {
            var sqlGetUser = "SELECT * FROM usrDetail WHERE _account = @account";
            try
            {
                conn.Open();
                MySqlParameter sqlParameter = new MySqlParameter("@account", accountName);
                var sqlCmd = new MySqlCommand(sqlGetUser, conn);
                sqlCmd.Parameters.Add(sqlParameter);
                var sqlReader = sqlCmd.ExecuteReader();
                var userInfo = new UserDetails();
                while (sqlReader.Read())
                {
                    userInfo.Account = sqlReader.GetString(0);
                    userInfo.Age = sqlReader.GetUInt16(1);
                    userInfo.Company = sqlReader.GetString(2);
                    userInfo.Position = sqlReader.GetString(3);
                }
                sqlCmd.Dispose();
                sqlReader.Dispose();
                return userInfo;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region Delete Data From DB

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="accountName"></param>
        public void DeleteUserByAccount(string accountName)
        {
            var sqlDelUser = "DELETE FROM usrTbl WHERE _account = @account";
            try
            {
                MySqlParameter sqlParameter = new MySqlParameter("@account", MySqlDbType.VarChar, 80, accountName);
                conn.Open();
                var sqlCmd = new MySqlCommand(sqlDelUser, conn);
                sqlCmd.Parameters.Add(sqlParameter);
                sqlCmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion
    }
}
