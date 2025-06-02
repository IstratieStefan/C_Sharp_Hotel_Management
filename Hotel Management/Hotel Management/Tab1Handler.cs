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
    internal class Tab1Handler
    {
        private readonly string connectionString;


        private readonly HashSet<string> validCountries = new HashSet<string>
        {
            "afghanistan", "albania", "algeria", "andorra", "angola", "antigua and barbuda", "argentina", "armenia", "australia", "austria",
            "azerbaijan", "bahamas", "bahrain", "bangladesh", "barbados", "belarus", "belgium", "belize", "benin", "bhutan",
            "bolivia", "bosnia and herzegovina", "botswana", "brazil", "brunei", "bulgaria", "burkina faso", "burundi", "cabo verde", "cambodia",
            "cameroon", "canada", "central african republic", "chad", "chile", "china", "colombia", "comoros", "congo (brazzaville)", "congo (kinshasa)",
            "costa rica", "croatia", "cuba", "cyprus", "czech republic", "denmark", "djibouti", "dominica", "dominican republic", "ecuador",
            "egypt", "el salvador", "equatorial guinea", "eritrea", "estonia", "eswatini", "ethiopia", "fiji", "finland", "france",
            "gabon", "gambia", "georgia", "germany", "ghana", "greece", "grenada", "guatemala", "guinea", "guinea-bissau",
            "guyana", "haiti", "honduras", "hungary", "iceland", "india", "indonesia", "iran", "iraq", "ireland",
            "israel", "italy", "ivory coast", "jamaica", "japan", "jordan", "kazakhstan", "kenya", "kiribati", "korea north",
            "korea south", "kosovo", "kuwait", "kyrgyzstan", "laos", "latvia", "lebanon", "lesotho", "liberia", "libya",
            "liechtenstein", "lithuania", "luxembourg", "madagascar", "malawi", "malaysia", "maldives", "mali", "malta", "marshall islands",
            "mauritania", "mauritius", "mexico", "micronesia", "moldova", "monaco", "mongolia", "montenegro", "morocco", "mozambique",
            "myanmar", "namibia", "nauru", "nepal", "netherlands", "new zealand", "nicaragua", "niger", "nigeria", "north macedonia",
            "norway", "oman", "pakistan", "palau", "panama", "papua new guinea", "paraguay", "peru", "philippines", "poland",
            "portugal", "qatar", "romania", "russia", "rwanda", "saint kitts and nevis", "saint lucia", "saint vincent and the grenadines", "samoa", "san marino",
            "sao tome and principe", "saudi arabia", "senegal", "serbia", "seychelles", "sierra leone", "singapore", "slovakia", "slovenia", "solomon islands",
            "somalia", "south africa", "south sudan", "spain", "sri lanka", "sudan", "suriname", "sweden", "switzerland", "syria",
            "taiwan", "tajikistan", "tanzania", "thailand", "timor-leste", "togo", "tonga", "trinidad and tobago", "tunisia", "turkey",
            "turkmenistan", "tuvalu", "uganda", "ukraine", "united arab emirates", "united kingdom", "united states", "uruguay", "uzbekistan", "vanuatu",
            "vatican city", "venezuela", "vietnam", "yemen", "zambia", "zimbabwe"
        };

        public Tab1Handler()
        {
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tab1DB.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";
        }

        public void AddData(string id, string firstName, string lastName, string phone, string country)
        {
            if (!ValidateFields(id, firstName, lastName, phone, country))
            {
                return;
            }

            if (CheckIfIdExists(id))
            {
                MessageBox.Show("An entry with the same Id already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clients (Id, FirstName, LastName, Phone, Country) VALUES (@Id, @FirstName, @LastName, @Phone, @Country)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Country", country);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditData(string id, string firstName, string lastName, string phone, string country)
        {
            if (!ValidateFields(id, firstName, lastName, phone, country))
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Clients SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Country = @Country WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Country", country);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveData(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Id cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Clients WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DataTable GetAllData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, FirstName, LastName, Phone, Country FROM Clients";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // Max total length for phone numbers (including +)
            const int maxLength = 16; // + followed by up to 15 digits

            if (phone.Length > maxLength)
            {
                MessageBox.Show("Phone number is too long. Maximum length is 16 characters including '+'.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Matches international format like +123456789012
            string pattern = @"^\+\d{8,15}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, pattern))
            {
                MessageBox.Show("Phone must be in international format, e.g., +40712345678.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateFields(string id, string firstName, string lastName, string phone, string country)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Id cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First Name cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last Name cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Country cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("Id must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(!IsValidPhoneNumber(phone))
{
                return false;
            }

            if (!IsString(firstName))
            {
                MessageBox.Show("First Name must be a valid string.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsString(lastName))
            {
                MessageBox.Show("Last Name must be a valid string.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!validCountries.Contains(country.ToLower()))
            {
                MessageBox.Show("Please enter a valid country name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool IsString(string value)
        {
            return value.All(char.IsLetter);
        }

        private bool CheckIfIdExists(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Clients WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }
    }
}
