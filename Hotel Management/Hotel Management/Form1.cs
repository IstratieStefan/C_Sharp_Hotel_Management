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

        public Form1()
        {
            InitializeComponent();
            tab1Handler = new Tab1Handler();
            tab2Handler = new Tab2Handler();
            tab3Handler = new Tab3Handler();
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab1Handler.AddData(TextBox_Id.Text, TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_PhoneNumber.Text, TextBox_Country.Text);
            LoadDataTab1();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tab1Handler.EditData(TextBox_Id.Text, TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_PhoneNumber.Text, TextBox_Country.Text);
            LoadDataTab1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tab1Handler.RemoveData(TextBox_Id.Text);
            LoadDataTab1();
        }
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
        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRooms.Rows[e.RowIndex];
                TextBox_RoomNumber.Text = row.Cells["Number"].Value.ToString();
                ComboBox_RoomType.SelectedItem = row.Cells["Type"].Value.ToString();
                TextBox_RoomPhone.Text = row.Cells["Phone"].Value.ToString();
                ComboBox_Free.SelectedItem = row.Cells["Free"].Value.ToString();
            }
        }
        private void dataGridViewReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservations.Rows[e.RowIndex];
                TextBox_ReservationId.Text = row.Cells["ReservationId"].Value.ToString();
                TextBox_ClientId.Text = row.Cells["ClientId"].Value.ToString();
                ComboBox_RoomType.SelectedItem = row.Cells["RoomType"].Value.ToString();
                TextBox_RoomNumber.Text = row.Cells["RoomNumber"].Value.ToString();
                dateTimePicker_In.Value = Convert.ToDateTime(row.Cells["DateIn"].Value);
                dateTimePicker_Out.Value = Convert.ToDateTime(row.Cells["DateOut"].Value);
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            TextBox_Id.Text = string.Empty;
            TextBox_FirstName.Text = string.Empty;
            TextBox_LastName.Text = string.Empty;
            TextBox_PhoneNumber.Text = string.Empty;
            TextBox_Country.Text = string.Empty;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

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


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker_In_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Id_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void button1_Click_3(object sender, EventArgs e)
        {
            TextBox_RoomNumber.Text = string.Empty;
            ComboBox_RoomType.SelectedIndex = -1;
            TextBox_RoomPhone.Text = string.Empty;
            ComboBox_Free.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox_ReservationId.Text = string.Empty;
            TextBox_ClientId.Text = string.Empty;
            ComboBox_RoomType_Reservation.SelectedIndex = -1;
            TextBox_RoomNumber_Reservation.Text = string.Empty;
            dateTimePicker_In.Value = DateTime.Now;
            dateTimePicker_Out.Value = DateTime.Now;
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void rmUser_btn_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUserForm = new RemoveUserForm();
            removeUserForm.ShowDialog();
        }

        private void TextBox_Search2_TextChanged(object sender, EventArgs e)
        {

        }

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
    }
}
