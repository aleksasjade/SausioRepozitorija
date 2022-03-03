using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_20_sql
{
    internal class Database
    {
        private string _connectionString;

        public Database()
        {
            _connectionString = @"Data Source=DESKTOP-CJEVE95\SQLEXPRESS01;Initial Catalog=PirmaDuomenuBaze;Integrated Security=True";
        }

        public void NuskaitytiDuomenis()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students", sqlConnection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string lastName = reader.GetString(1);
                        string firstName = reader.GetString(2);
                        double score = reader.GetDouble(3);
                        string city = reader.GetString(4);
                        Console.WriteLine($"{id} {firstName} {lastName} {score} {city}");
                    }
                }
            }
        }

        public void IrasytiDuomenis(int Id, string lastName, string firstName, double score, string city)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO STudents (@Id,@LastName,@FirstName,@Score,@City)", sqlConnection))
                {
                    command.Parameters.Add(new SqlParameter("Id", Id));
                    command.Parameters.Add(new SqlParameter("Lastname", lastName));
                    command.Parameters.Add(new SqlParameter("FirstName", firstName));
                    command.Parameters.Add(new SqlParameter("Score", score));
                    command.Parameters.Add(new SqlParameter("City", city));
                    command.ExecuteNonQuery();
                }
                    
            }
        }
    }
}
