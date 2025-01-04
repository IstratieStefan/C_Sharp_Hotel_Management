using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Tab2Handler
    {
        private readonly string connectionString;

        public Tab2Handler()
        {
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tab2DB.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";
        }

        public void AddRoom(int Number, int Type, string Phone, string Free)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Rooms (Number, Type, Phone, Free) VALUES (@Number, @Type, @Phone, @Free)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Number", Number);
                command.Parameters.AddWithValue("@Type", Type);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Free", Free);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditRoom(int Number, int Type, string Phone, string Free)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Rooms SET Type = @Type, Phone = @Phone, Free = @Free WHERE Number = @Number";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Number", Number);
                command.Parameters.AddWithValue("@Type", Type);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Free", Free);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveRoom(int Number)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Rooms WHERE Number = @Number";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Number", Number);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllRooms()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Number, Type, Phone, Free FROM Rooms";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

    }
}
