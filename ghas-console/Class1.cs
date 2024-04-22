using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghas_console
{
    public class SQLInjection
    {

        public void RunQuery(string userInput)
        {
            string connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Vulnerable to SQL Injection
                string query = "SELECT * FROM Users WHERE UserName = '" + userInput + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString());
                    }
                }
            }
        }
    }
}


