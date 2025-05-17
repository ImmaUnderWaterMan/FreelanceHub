using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FreelanceHub
{
    public class DBConnection
    {
        private static DBConnection _instance;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        private DBConnection()
        {
            _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\romas\\Source\\Repos\\FreelanceHub\\FreelanceHub\\Database1.mdf;Integrated Security=True";
        }

        public static DBConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DBConnection();
                    }
                    return _instance;
                }
            }
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

    }
}
