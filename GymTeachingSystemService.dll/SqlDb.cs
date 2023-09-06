using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTeachingSystemService.dll
{
    public class SqlDb
    {
        public static string ApplicationName { get; set; }
        public static string GetConnectionString(string KeyOfConnString)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[KeyOfConnString].ToString();
            if (string.IsNullOrEmpty(connStr))
            {
                throw new Exception("找不到連線字串，key=" + KeyOfConnString);
            }

            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
            if (string.IsNullOrEmpty(ApplicationName) == false)
            {
                sb.ApplicationName = ApplicationName;
            }


            return sb.ToString();
        }

        public static SqlConnection GetConnection(string KeyOfConnString)
        {
            string connStr = GetConnectionString(KeyOfConnString);
            return new SqlConnection(connStr);
        }

        public static SqlConnection GetConnection()
        {

            return GetConnection("default");
        }

        public static int UpdateOrDelete(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
        {
            using (var conn = funcConn())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Create(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
        {
            sql += ";SELECT SCOPE_IDENTITY()";

            using (var conn = funcConn())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {

                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static T Get<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
        {
            using (var conn = funcConn())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {

                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader.Read()
                        ? funcAssembler(reader)
                        : default(T);
                }
            }
        }

        public static List<T> Search<T>(Func<SqlConnection> funcConn,
                                        Func<SqlDataReader, T> funcAssembler,
                                        string sql,
                                        params SqlParameter[] parameters)
        {
            List<T> list = new List<T>();

            using (var conn = funcConn())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        T entity = funcAssembler(reader);
                        list.Add(entity);
                    }

                    return list;
                }
            }
        }
    }
}
