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
    internal class Tab3Handler
    {
        private readonly string connectionString;
        public Dictionary<string, int> roomTypeMapping;

        public Tab3Handler()
        {
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tab3DB.mdf");
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

        public void AddReservation(int reservationId, int clientId, string roomType, int roomNumber, DateTime dateIn, DateTime dateOut)
        {
            if (ValidateFields(reservationId, clientId, roomType, roomNumber, dateIn, dateOut))
            {
                if (!roomTypeMapping.TryGetValue(roomType, out int typeValue))
                {
                    throw new ArgumentException("Invalid room type");
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Reservations (ReservationId, ClientId, RoomType, RoomNumber, DateIn, DateOut) VALUES (@ReservationId, @ClientId, @RoomType, @RoomNumber, @DateIn, @DateOut)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ReservationId", reservationId);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@RoomType", typeValue);
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@DateIn", dateIn);
                    command.Parameters.AddWithValue("@DateOut", dateOut);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditReservation(int reservationId, int clientId, string roomType, int roomNumber, DateTime dateIn, DateTime dateOut)
        {
            if (ValidateFields(reservationId, clientId, roomType, roomNumber, dateIn, dateOut))
            {
                if (!roomTypeMapping.TryGetValue(roomType, out int typeValue))
                {
                    throw new ArgumentException("Invalid room type");
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Reservations SET ClientId = @ClientId, RoomType = @RoomType, RoomNumber = @RoomNumber, DateIn = @DateIn, DateOut = @DateOut WHERE ReservationId = @ReservationId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ReservationId", reservationId);
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@RoomType", typeValue);
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@DateIn", dateIn);
                    command.Parameters.AddWithValue("@DateOut", dateOut);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveReservation(int reservationId)
        {
            if (reservationId <= 0)
            {
                MessageBox.Show("Reservation ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Reservations WHERE ReservationId = @ReservationId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReservationId", reservationId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllReservations()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ReservationId, ClientId, RoomType, RoomNumber, DateIn, DateOut FROM Reservations";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        private bool ValidateFields(int reservationId, int clientId, string roomType, int roomNumber, DateTime dateIn, DateTime dateOut)
        {
            if (reservationId <= 0)
            {
                MessageBox.Show("Reservation ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clientId <= 0)
            {
                MessageBox.Show("Client ID must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(roomType) || !roomTypeMapping.ContainsKey(roomType))
            {
                MessageBox.Show("Invalid room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (roomNumber <= 0)
            {
                MessageBox.Show("Room number must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateIn >= dateOut)
            {
                MessageBox.Show("Check-in date must be before check-out date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
