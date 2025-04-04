using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal class Tab2Handler
    {
        private readonly string connectionString;
        public Dictionary<string, int> roomTypeMapping;

        public Tab2Handler()
        {
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tab2DB.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";

            // Initialize the room type mapping dictionary
            roomTypeMapping = new Dictionary<string, int>
            {
                { "1-Single", 1 },
                { "2-Double", 2 },
                { "3-Apartment", 3 },
                { "4-Suite", 4 }
            };
        }

        public void AddRoom(int Number, string Type, string Phone, string Free)
        {
            if (ValidateFields(Number, Type, Phone, Free))
            {
                if (!roomTypeMapping.TryGetValue(Type, out int typeValue))
                {
                    throw new ArgumentException("Invalid room type");
                }

                if (CheckIfNumberExists(Number))
                {
                    MessageBox.Show("A room with the same number already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Rooms (Number, Type, Phone, Free) VALUES (@Number, @Type, @Phone, @Free)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Number", Number);
                    command.Parameters.AddWithValue("@Type", typeValue);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Free", Free);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditRoom(int Number, string Type, string Phone, string Free)
        {
            if (ValidateFields(Number, Type, Phone, Free))
            {
                if (!roomTypeMapping.TryGetValue(Type, out int typeValue))
                {
                    throw new ArgumentException("Invalid room type");
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Rooms SET Type = @Type, Phone = @Phone, Free = @Free WHERE Number = @Number";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Number", Number);
                    command.Parameters.AddWithValue("@Type", typeValue);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Free", Free);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveRoom(int Number)
        {
            if (Number <= 0)
            {
                MessageBox.Show("Room number must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private bool ValidateFields(int Number, string Type, string Phone, string Free)
        {
            if (Number <= 0)
            {
                MessageBox.Show("Room number must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Type) || !roomTypeMapping.ContainsKey(Type))
            {
                MessageBox.Show("Invalid room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Phone) || !IsPhoneNumber(Phone))
            {
                MessageBox.Show("Invalid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Free) || (Free != "Yes" && Free != "No"))
            {
                MessageBox.Show("Free field must be 'Yes' or 'No'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsPhoneNumber(string value)
        {
            return value.All(char.IsDigit);
        }

        private bool CheckIfNumberExists(int Number)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Rooms WHERE Number = @Number";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Number", Number);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }
    }
}
