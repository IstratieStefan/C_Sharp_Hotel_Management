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
        private readonly Color lightBackColor = Color.White;
        private readonly Color lightForeColor = Color.Black;

        private readonly Color darkBackColor = Color.FromArgb(30, 30, 30); // Dark gray
        private readonly Color darkForeColor = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

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

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
    }
}
