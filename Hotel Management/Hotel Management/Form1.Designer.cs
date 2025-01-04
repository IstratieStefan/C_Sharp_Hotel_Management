namespace Hotel_Management
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.TextBox_Id = new System.Windows.Forms.TextBox();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.Add_New_Button = new System.Windows.Forms.Button();
            this.TextBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Country = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ComboBox_Free = new System.Windows.Forms.ComboBox();
            this.ComboBox_RoomType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.TextBox_RoomPhone = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TextBox_RoomNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonSearch2 = new System.Windows.Forms.Button();
            this.TextBox_Search2 = new System.Windows.Forms.TextBox();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker_Out = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker_In = new System.Windows.Forms.DateTimePicker();
            this.ComboBox_RoomType_Reservation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBox_RoomNumber_Reservation = new System.Windows.Forms.TextBox();
            this.TextBox_ClientId = new System.Windows.Forms.TextBox();
            this.TextBox_ReservationId = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_Theme = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Clients";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Clear_Button);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_Id);
            this.splitContainer1.Panel1.Controls.Add(this.Remove_Button);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_FirstName);
            this.splitContainer1.Panel1.Controls.Add(this.Edit_Button);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_LastName);
            this.splitContainer1.Panel1.Controls.Add(this.Add_New_Button);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_PhoneNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_Country);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel2.Controls.Add(this.TextBox_Search);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewClients);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(786, 415);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 14;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Transparent;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear_Button.Location = new System.Drawing.Point(5, 384);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(237, 23);
            this.Clear_Button.TabIndex = 13;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // TextBox_Id
            // 
            this.TextBox_Id.AllowDrop = true;
            this.TextBox_Id.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Id.Location = new System.Drawing.Point(5, 27);
            this.TextBox_Id.Name = "TextBox_Id";
            this.TextBox_Id.Size = new System.Drawing.Size(237, 24);
            this.TextBox_Id.TabIndex = 0;
            this.TextBox_Id.TextChanged += new System.EventHandler(this.TextBox_Id_TextChanged);
            // 
            // Remove_Button
            // 
            this.Remove_Button.BackColor = System.Drawing.Color.Transparent;
            this.Remove_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remove_Button.Location = new System.Drawing.Point(167, 355);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 12;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_FirstName.Location = new System.Drawing.Point(5, 70);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.Size = new System.Drawing.Size(237, 24);
            this.TextBox_FirstName.TabIndex = 1;
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit_Button.Location = new System.Drawing.Point(86, 355);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_Button.TabIndex = 11;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_LastName.Location = new System.Drawing.Point(5, 115);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(237, 24);
            this.TextBox_LastName.TabIndex = 2;
            // 
            // Add_New_Button
            // 
            this.Add_New_Button.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_New_Button.Location = new System.Drawing.Point(5, 355);
            this.Add_New_Button.Name = "Add_New_Button";
            this.Add_New_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_New_Button.TabIndex = 10;
            this.Add_New_Button.Text = "Add New ";
            this.Add_New_Button.UseVisualStyleBackColor = false;
            this.Add_New_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_PhoneNumber
            // 
            this.TextBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PhoneNumber.Location = new System.Drawing.Point(5, 158);
            this.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber";
            this.TextBox_PhoneNumber.Size = new System.Drawing.Size(237, 24);
            this.TextBox_PhoneNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country";
            // 
            // TextBox_Country
            // 
            this.TextBox_Country.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Country.Location = new System.Drawing.Point(5, 203);
            this.TextBox_Country.Name = "TextBox_Country";
            this.TextBox_Country.Size = new System.Drawing.Size(237, 24);
            this.TextBox_Country.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(448, 392);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.Search_clients_Click);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBox_Search.Location = new System.Drawing.Point(0, 392);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(523, 23);
            this.TextBox_Search.TabIndex = 15;
            this.TextBox_Search.Text = "Search...";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(523, 415);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ComboBox_Free);
            this.splitContainer2.Panel1.Controls.Add(this.ComboBox_RoomType);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.TextBox_RoomPhone);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.TextBox_RoomNumber);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ButtonSearch2);
            this.splitContainer2.Panel2.Controls.Add(this.TextBox_Search2);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewRooms);
            this.splitContainer2.Size = new System.Drawing.Size(786, 415);
            this.splitContainer2.SplitterDistance = 261;
            this.splitContainer2.TabIndex = 33;
            // 
            // ComboBox_Free
            // 
            this.ComboBox_Free.FormattingEnabled = true;
            this.ComboBox_Free.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ComboBox_Free.Location = new System.Drawing.Point(8, 161);
            this.ComboBox_Free.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_Free.Name = "ComboBox_Free";
            this.ComboBox_Free.Size = new System.Drawing.Size(233, 24);
            this.ComboBox_Free.TabIndex = 34;
            // 
            // ComboBox_RoomType
            // 
            this.ComboBox_RoomType.FormattingEnabled = true;
            this.ComboBox_RoomType.Items.AddRange(new object[] {
            "1-Single",
            "2-Double",
            "3-Apartment",
            "4-Suite"});
            this.ComboBox_RoomType.Location = new System.Drawing.Point(7, 68);
            this.ComboBox_RoomType.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_RoomType.Name = "ComboBox_RoomType";
            this.ComboBox_RoomType.Size = new System.Drawing.Size(234, 24);
            this.ComboBox_RoomType.TabIndex = 33;
            this.ComboBox_RoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Free";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Phone Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Room Type";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(89, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Room Number";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(8, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add New ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextBox_RoomPhone
            // 
            this.TextBox_RoomPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RoomPhone.Location = new System.Drawing.Point(7, 116);
            this.TextBox_RoomPhone.Name = "TextBox_RoomPhone";
            this.TextBox_RoomPhone.Size = new System.Drawing.Size(237, 24);
            this.TextBox_RoomPhone.TabIndex = 21;
            this.TextBox_RoomPhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(170, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TextBox_RoomNumber
            // 
            this.TextBox_RoomNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RoomNumber.Location = new System.Drawing.Point(7, 21);
            this.TextBox_RoomNumber.Name = "TextBox_RoomNumber";
            this.TextBox_RoomNumber.Size = new System.Drawing.Size(237, 24);
            this.TextBox_RoomNumber.TabIndex = 18;
            this.TextBox_RoomNumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(8, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // ButtonSearch2
            // 
            this.ButtonSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch2.Location = new System.Drawing.Point(446, 392);
            this.ButtonSearch2.Name = "ButtonSearch2";
            this.ButtonSearch2.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch2.TabIndex = 31;
            this.ButtonSearch2.Text = "Search";
            this.ButtonSearch2.UseVisualStyleBackColor = true;
            this.ButtonSearch2.Click += new System.EventHandler(this.ButtonSearch2_Click);
            // 
            // TextBox_Search2
            // 
            this.TextBox_Search2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBox_Search2.Location = new System.Drawing.Point(0, 392);
            this.TextBox_Search2.Name = "TextBox_Search2";
            this.TextBox_Search2.Size = new System.Drawing.Size(521, 23);
            this.TextBox_Search2.TabIndex = 30;
            this.TextBox_Search2.Text = "Search...";
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRooms.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRooms.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(521, 415);
            this.dataGridViewRooms.TabIndex = 29;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker_Out);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.dateTimePicker_In);
            this.tabPage3.Controls.Add(this.ComboBox_RoomType_Reservation);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.TextBox_RoomNumber_Reservation);
            this.tabPage3.Controls.Add(this.TextBox_ClientId);
            this.tabPage3.Controls.Add(this.TextBox_ReservationId);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Reservations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Out
            // 
            this.dateTimePicker_Out.Location = new System.Drawing.Point(8, 250);
            this.dateTimePicker_Out.Name = "dateTimePicker_Out";
            this.dateTimePicker_Out.Size = new System.Drawing.Size(237, 23);
            this.dateTimePicker_Out.TabIndex = 35;
            this.dateTimePicker_Out.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Date Out";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dateTimePicker_In
            // 
            this.dateTimePicker_In.Location = new System.Drawing.Point(8, 204);
            this.dateTimePicker_In.Name = "dateTimePicker_In";
            this.dateTimePicker_In.Size = new System.Drawing.Size(237, 23);
            this.dateTimePicker_In.TabIndex = 33;
            this.dateTimePicker_In.ValueChanged += new System.EventHandler(this.dateTimePicker_In_ValueChanged);
            // 
            // ComboBox_RoomType_Reservation
            // 
            this.ComboBox_RoomType_Reservation.FormattingEnabled = true;
            this.ComboBox_RoomType_Reservation.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Apartment",
            "Penthouse"});
            this.ComboBox_RoomType_Reservation.Location = new System.Drawing.Point(8, 116);
            this.ComboBox_RoomType_Reservation.Name = "ComboBox_RoomType_Reservation";
            this.ComboBox_RoomType_Reservation.Size = new System.Drawing.Size(237, 24);
            this.ComboBox_RoomType_Reservation.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date In";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Room Number";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Room Type";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Client Id";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Reservation Id";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // TextBox_RoomNumber_Reservation
            // 
            this.TextBox_RoomNumber_Reservation.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RoomNumber_Reservation.Location = new System.Drawing.Point(8, 159);
            this.TextBox_RoomNumber_Reservation.Name = "TextBox_RoomNumber_Reservation";
            this.TextBox_RoomNumber_Reservation.Size = new System.Drawing.Size(237, 24);
            this.TextBox_RoomNumber_Reservation.TabIndex = 25;
            this.TextBox_RoomNumber_Reservation.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // TextBox_ClientId
            // 
            this.TextBox_ClientId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ClientId.Location = new System.Drawing.Point(8, 71);
            this.TextBox_ClientId.Name = "TextBox_ClientId";
            this.TextBox_ClientId.Size = new System.Drawing.Size(237, 24);
            this.TextBox_ClientId.TabIndex = 23;
            this.TextBox_ClientId.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // TextBox_ReservationId
            // 
            this.TextBox_ReservationId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ReservationId.Location = new System.Drawing.Point(8, 28);
            this.TextBox_ReservationId.Name = "TextBox_ReservationId";
            this.TextBox_ReservationId.Size = new System.Drawing.Size(237, 24);
            this.TextBox_ReservationId.TabIndex = 22;
            this.TextBox_ReservationId.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(8, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(170, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(89, 361);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Edit";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(8, 361);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Add New ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.comboBox_Theme);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(130, 65);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "Remove User";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(69, 94);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 23);
            this.button10.TabIndex = 5;
            this.button10.Text = "Drop Database";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Database";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(49, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Add User";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Users";
            // 
            // comboBox_Theme
            // 
            this.comboBox_Theme.FormattingEnabled = true;
            this.comboBox_Theme.Items.AddRange(new object[] {
            "Light Mode",
            "Dark Mode"});
            this.comboBox_Theme.Location = new System.Drawing.Point(8, 31);
            this.comboBox_Theme.Name = "comboBox_Theme";
            this.comboBox_Theme.Size = new System.Drawing.Size(108, 24);
            this.comboBox_Theme.TabIndex = 1;
            this.comboBox_Theme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Theme";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Country;
        private System.Windows.Forms.TextBox TextBox_PhoneNumber;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.TextBox TextBox_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_New_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_RoomPhone;
        private System.Windows.Forms.TextBox TextBox_RoomNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBox_RoomNumber_Reservation;
        private System.Windows.Forms.TextBox TextBox_ClientId;
        private System.Windows.Forms.TextBox TextBox_ReservationId;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox ComboBox_RoomType_Reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Out;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker_In;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_Theme;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox ComboBox_RoomType;
        private System.Windows.Forms.ComboBox ComboBox_Free;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ButtonSearch2;
        private System.Windows.Forms.TextBox TextBox_Search2;
        private System.Windows.Forms.Button button11;
    }
}

