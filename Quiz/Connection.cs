using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quiz
{
    public class Connection {
        private string _connString;
        public Connection()
        {
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"DESKTOP-43407LQ\SQLEXPRESS",
                InitialCatalog = @"kiyo",
                IntegratedSecurity = true
            };
            _connString = connStringBuilder.ToString();
    }

        public SqlConnection OpenConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(_connString);
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }
    }
}
