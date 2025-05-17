using Microsoft.VisualBasic.Logging;
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
    public class DateBaseManager
    {
        private readonly DBConnection dbConnection = DBConnection.Instance;
        public void SaveToDateBase(string login, string password)
        {
            try
            {
                using (SqlConnection connection = dbConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO [dbo].[Users] (Login, Password) " +
                        "VALUES (@Login, @Password)",
                        connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool AreCredentialsValidFreelance(string login, string password)
        {
            login = login.Trim();
            password = password.Trim();
            string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, dbConnection.GetConnection()))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }

        }
    }
}
    


      


