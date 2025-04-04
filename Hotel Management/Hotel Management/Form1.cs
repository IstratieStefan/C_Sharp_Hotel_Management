using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Form1 : Form

    {
        private Tab1Handler tab1Handler;
        private Tab2Handler tab2Handler;
        private Tab3Handler tab3Handler;

        private readonly Color lightBackColor = Color.White;
        private readonly Color lightForeColor = Color.Black;

        private readonly Color darkBackColor = Color.FromArgb(30, 30, 30); // Dark gray
        private readonly Color darkForeColor = Color.White;


        //Tab handlers initialization
        public Form1()
        {
            InitializeComponent();
            tab1Handler = new Tab1Handler();
            tab2Handler = new Tab2Handler();
            tab3Handler = new Tab3Handler();
        }

        //LoadData functions for each tab
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataTab1();
            LoadDataTab2();
            LoadDataTab3();
        }
        private void LoadDataTab1()
        {
            dataGridViewClients.DataSource = tab1Handler.GetAllData();
        }
        private void LoadDataTab2()
        {
            dataGridViewRooms.DataSource = tab2Handler.GetAllRooms();
        }
        private void LoadDataTab3()
        {
            dataGridViewReservations.DataSource = tab3Handler.GetAllReservations(); 
        }


        //Tab1 Add
        private void button1_Click(object sender, EventArgs e)
        {
            tab1Handler.AddData(TextBox_Id.Text, TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_PhoneNumber.Text, TextBox_Country.Text);
            LoadDataTab1();
        }
        //Tab1 Edit

        private void button1_Click_1(object sender, EventArgs e)
        {
            tab1Handler.EditData(TextBox_Id.Text, TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_PhoneNumber.Text, TextBox_Country.Text);
            LoadDataTab1();
        }
        //Tab1 Remove
        private void button2_Click(object sender, EventArgs e)
        {
            tab1Handler.RemoveData(TextBox_Id.Text);
            LoadDataTab1();
        }
        //Tab1 DataGrid Click
        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClients.Rows[e.RowIndex];
                TextBox_Id.Text = row.Cells["Id"].Value.ToString();
                TextBox_FirstName.Text = row.Cells["FirstName"].Value.ToString();
                TextBox_LastName.Text = row.Cells["LastName"].Value.ToString();
                TextBox_PhoneNumber.Text = row.Cells["Phone"].Value.ToString();
                TextBox_Country.Text = row.Cells["Country"].Value.ToString();
            }
        }
        //Tab2 DataGrid Click
        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRooms.Rows[e.RowIndex];
                TextBox_RoomNumber.Text = row.Cells["Number"].Value.ToString();
                int roomTypeId = Convert.ToInt32(row.Cells["Type"].Value);
                string roomTypeString = tab2Handler.roomTypeMapping.FirstOrDefault(x => x.Value == roomTypeId).Key;
                ComboBox_RoomType.SelectedItem = roomTypeString; ;
                TextBox_RoomPhone.Text = row.Cells["Phone"].Value.ToString();
                ComboBox_Free.SelectedItem = row.Cells["Free"].Value.ToString();
            }
        }

        //Tab3 DataGrid Click
        private void dataGridViewReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservations.Rows[e.RowIndex];
                TextBox_ReservationId.Text = row.Cells["ReservationId"].Value.ToString();
                TextBox_ClientId.Text = row.Cells["ClientId"].Value.ToString();
                int roomTypeId = Convert.ToInt32(row.Cells["RoomType"].Value);
                string roomTypeString = tab3Handler.roomTypeMapping.FirstOrDefault(x => x.Value == roomTypeId).Key;
                ComboBox_RoomType_Reservation.SelectedItem = roomTypeString;
                TextBox_RoomNumber_Reservation.Text = row.Cells["RoomNumber"].Value.ToString();
                dateTimePicker_In.Value = Convert.ToDateTime(row.Cells["DateIn"].Value);
                dateTimePicker_Out.Value = Convert.ToDateTime(row.Cells["DateOut"].Value);
            }
        }

        //Tab1 Clear
        private void button1_Click_2(object sender, EventArgs e)
        {
            TextBox_Id.Text = string.Empty;
            TextBox_FirstName.Text = string.Empty;
            TextBox_LastName.Text = string.Empty;
            TextBox_PhoneNumber.Text = string.Empty;
            TextBox_Country.Text = string.Empty;
        }

   

        //Tab3 Add
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(TextBox_ReservationId.Text);
                int clientId = Convert.ToInt32(TextBox_ClientId.Text);
                string roomType = ComboBox_RoomType_Reservation.SelectedItem.ToString();
                int roomNumber = Convert.ToInt32(TextBox_RoomNumber_Reservation.Text);
                DateTime dateIn = dateTimePicker_In.Value;
                DateTime dateOut = dateTimePicker_Out.Value;

                tab3Handler.AddReservation(reservationId, clientId, roomType, roomNumber, dateIn, dateOut);
                LoadDataTab3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tab3 Edit
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(TextBox_ReservationId.Text);
                int clientId = Convert.ToInt32(TextBox_ClientId.Text);
                string roomType = ComboBox_RoomType_Reservation.SelectedItem.ToString();
                int roomNumber = Convert.ToInt32(TextBox_RoomNumber_Reservation.Text);
                DateTime dateIn = dateTimePicker_In.Value;
                DateTime dateOut = dateTimePicker_Out.Value;

                tab3Handler.EditReservation(reservationId, clientId, roomType, roomNumber, dateIn, dateOut);
                LoadDataTab3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tab3 Remove
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int reservationId = Convert.ToInt32(TextBox_ReservationId.Text);
                tab3Handler.RemoveReservation(reservationId);
                LoadDataTab3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Apply theme function
        private void ApplyTheme(bool isDarkMode)
        {
            if (isDarkMode)
            {
                // Dark Mode Colors
                Color backColor = Color.FromArgb(40, 40, 40); // Slightly lighter dark gray
                Color foreColor = Color.Gainsboro;           // Light gray for text
                Color buttonBackColor = Color.FromArgb(60, 60, 60); // Neutral dark tone for buttons
                Color buttonBorderColor = Color.Gray;        // Subtle border color for buttons

                // Apply to form and controls
                this.BackColor = backColor;
                this.ForeColor = foreColor;
                ApplyDarkModeToControls(this.Controls, backColor, foreColor, buttonBackColor, buttonBorderColor);
            }
            else
            {
                // Light Mode Colors (default)
                Color backColor = Color.White;
                Color foreColor = Color.Black;

                this.BackColor = backColor;
                this.ForeColor = foreColor;
                ApplyLightModeToControls(this.Controls, backColor, foreColor);
            }
        }
        //Apply dark mode to controls function
        private void ApplyDarkModeToControls(Control.ControlCollection controls, Color backColor, Color foreColor, Color buttonBackColor, Color buttonBorderColor)
        {
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    button.BackColor = buttonBackColor;
                    button.ForeColor = foreColor;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = buttonBorderColor;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.FromArgb(50, 50, 50);
                    textBox.ForeColor = foreColor;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                if (control is TabControl tabControl)
                {
                    tabControl.BackColor = backColor;
                    tabControl.ForeColor = foreColor;

                    tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
                    tabControl.ItemSize = new Size(100, 30);

                    tabControl.DrawItem += (sender, e) =>
                    {
                        TabControl tabCtrl = sender as TabControl;
                        TabPage tabPage = tabCtrl.TabPages[e.Index];
                        e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);
                        TextRenderer.DrawText(e.Graphics, tabPage.Text, e.Font, e.Bounds, foreColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                    };

                    // Custom TabControl Border
                    tabControl.Paint += (sender, e) =>
                    {
                        using (Pen borderPen = new Pen(Color.FromArgb(60, 60, 60)))
                        {
                            e.Graphics.DrawRectangle(borderPen, tabControl.ClientRectangle);
                        }
                    };

                    foreach (TabPage tabPage in tabControl.TabPages)
                    {
                        tabPage.BackColor = backColor;
                        tabPage.ForeColor = foreColor;
                    }
                }

                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
                    dateTimePicker.CalendarForeColor = Color.FromArgb(50, 50, 50);
                    dateTimePicker.BackColor = Color.FromArgb(50, 50, 50);
                    dateTimePicker.ForeColor = Color.FromArgb(50, 50, 50);
                    dateTimePicker.CalendarTitleBackColor = Color.FromArgb(50, 50, 50);
                    dateTimePicker.CalendarTitleForeColor = Color.FromArgb(50, 50, 50);
                }
                else if (control is ComboBox comboBox)
                {
                    // Style ComboBoxes
                    comboBox.BackColor = Color.FromArgb(50, 50, 50);
                    comboBox.ForeColor = foreColor;
                    comboBox.FlatStyle = FlatStyle.Flat;
                }
                else
                {
                    control.BackColor = backColor;
                    control.ForeColor = foreColor;
                }

                if (control.HasChildren)
                {
                    ApplyDarkModeToControls(control.Controls, backColor, foreColor, buttonBackColor, buttonBorderColor);
                }
            }
        
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.Padding = new Padding(1);
                this.BackColor = Color.FromArgb(40, 40, 40); 
                this.Refresh(); 
            }
        }
        //Apply light mode to controls function
        private void ApplyLightModeToControls(Control.ControlCollection controls, Color backColor, Color foreColor)
        {
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    // Style buttons for light mode
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    button.FlatStyle = FlatStyle.Standard;
                    button.FlatAppearance.BorderColor = Color.Black;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.Black;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                if (control is TabControl tabControl)
                {
                    tabControl.BackColor = backColor;
                    tabControl.ForeColor = foreColor;

                    tabControl.DrawMode = TabDrawMode.Normal;

                    tabControl.Paint -= (sender, e) =>
                    {
                        using (Pen borderPen = new Pen(Color.FromArgb(60, 60, 60)))
                        {
                            e.Graphics.DrawRectangle(borderPen, tabControl.ClientRectangle);
                        }
                    };

                    foreach (TabPage tabPage in tabControl.TabPages)
                    {
                        tabPage.BackColor = backColor;
                        tabPage.ForeColor = foreColor;
                    }
                }

                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.CalendarMonthBackground = Color.White;
                    dateTimePicker.CalendarForeColor = foreColor;
                    dateTimePicker.BackColor = Color.White;
                    dateTimePicker.ForeColor = foreColor;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = foreColor;
                    comboBox.FlatStyle = FlatStyle.Standard;
                }
                else
                {
                    control.BackColor = backColor;
                    control.ForeColor = foreColor;
                }

                if (control.HasChildren)
                {
                    ApplyLightModeToControls(control.Controls, backColor, foreColor);
                }
            }

            
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.Padding = new Padding(1); 
                this.BackColor = Color.White; 
                this.Refresh(); 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Theme.Text == "Light Mode")
            {
                ApplyTheme(isDarkMode: false); 
            }
            else if (comboBox_Theme.Text == "Dark Mode")
            {
                ApplyTheme(isDarkMode: true); 
            }
        }

        
        //Tab2 Add
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TextBox_RoomNumber.Text);
                string type = ComboBox_RoomType.SelectedItem.ToString();
                string phone = TextBox_RoomPhone.Text;
                string free = ComboBox_Free.SelectedItem.ToString();

                tab2Handler.AddRoom(number, type, phone, free);
                LoadDataTab2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tab2 Edit
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TextBox_RoomNumber.Text);
                string type = ComboBox_RoomType.SelectedItem.ToString();
                string phone = TextBox_RoomPhone.Text;
                string free = ComboBox_Free.SelectedItem.ToString();

                tab2Handler.EditRoom(number, type, phone, free);
                LoadDataTab2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tab2 Remove
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TextBox_RoomNumber.Text);
                tab2Handler.RemoveRoom(number);
                LoadDataTab2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tab2 Clear
        private void button1_Click_3(object sender, EventArgs e)
        {
            TextBox_RoomNumber.Text = string.Empty;
            ComboBox_RoomType.SelectedIndex = -1;
            TextBox_RoomPhone.Text = string.Empty;
            ComboBox_Free.SelectedIndex = -1;
        }

       
        // Clients search query function on button click
        private void Search_clients_Click(object sender, EventArgs e)
        {
            string searchTerm = TextBox_Search.Text.ToLower();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Loop through rows in DataGridView to find matches
                foreach (DataGridViewRow row in dataGridViewClients.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White; 

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                        {
                            row.DefaultCellStyle.BackColor = Color.LightSkyBlue; 
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Rooms search query function on button click
        private void ButtonSearch2_Click(object sender, EventArgs e)
        {
            string searchTerm = TextBox_Search2.Text.ToLower();

            if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Loop through rows in DataGridView to find matches
                    foreach (DataGridViewRow row in dataGridViewRooms.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                            {
                                row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        // Reservations search query function on button click
        private void ButtonSearch3_Click(object sender, EventArgs e)
        {
            string searchTerm = TextBox_Search3.Text.ToLower();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Loop through rows in DataGridView to find matches
                foreach (DataGridViewRow row in dataGridViewReservations.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                        {
                            row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 

        //Tab3 Clear
        private void button5_Click(object sender, EventArgs e)
        {
            TextBox_ReservationId.Text = string.Empty;
            TextBox_ClientId.Text = string.Empty;
            ComboBox_RoomType_Reservation.SelectedIndex = -1;
            TextBox_RoomNumber_Reservation.Text = string.Empty;
            dateTimePicker_In.Value = DateTime.Now;
            dateTimePicker_Out.Value = DateTime.Now;
        }
        //Add user button click
        private void addUser_btn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
        //Remove user button click
        private void rmUser_btn_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUserForm = new RemoveUserForm();
            removeUserForm.ShowDialog();
        }

        //Logout
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Form1 newForm = new Form1();
                newForm.FormClosed += (s, args) => this.Close(); // Close the current form when the new form is closed
                newForm.Show();
            }
            else
            {
                this.Show(); // Show the current form again if login is canceled
            }
        }

     
    }
}
