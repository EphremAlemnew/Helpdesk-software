namespace WindowsFormsApplication1
{
    partial class Helpers
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
            this.components = new System.ComponentModel.Container();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.printPannel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.ExpertPhoto = new System.Windows.Forms.PictureBox();
            this.E_birthDate = new System.Windows.Forms.DateTimePicker();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SearchE_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.campus = new System.Windows.Forms.ComboBox();
            this.Clear_bt = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.E_Edulevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.E_RoomNo = new System.Windows.Forms.TextBox();
            this.AuthenticationNo = new System.Windows.Forms.TextBox();
            this.E_phoneNo = new System.Windows.Forms.TextBox();
            this.authent = new System.Windows.Forms.Label();
            this.E_buldingNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.E_lastname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.E_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Expert_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.E_firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Experts_In = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.printExpertDoc = new System.Drawing.Printing.PrintDocument();
            this.printExpert = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.printPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gray;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(192, 659);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 35);
            this.add.TabIndex = 7;
            this.add.Text = "ADD NEW";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.AddNew);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(435, 659);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Delete);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(314, 659);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Update);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // printPannel
            // 
            this.printPannel.Controls.Add(this.label17);
            this.printPannel.Controls.Add(this.ExpertPhoto);
            this.printPannel.Controls.Add(this.E_birthDate);
            this.printPannel.Controls.Add(this.Female);
            this.printPannel.Controls.Add(this.Male);
            this.printPannel.Controls.Add(this.label14);
            this.printPannel.Controls.Add(this.Search);
            this.printPannel.Controls.Add(this.SearchE_ID);
            this.printPannel.Controls.Add(this.label12);
            this.printPannel.Controls.Add(this.campus);
            this.printPannel.Controls.Add(this.Clear_bt);
            this.printPannel.Controls.Add(this.Browse);
            this.printPannel.Controls.Add(this.label11);
            this.printPannel.Controls.Add(this.E_Edulevel);
            this.printPannel.Controls.Add(this.label7);
            this.printPannel.Controls.Add(this.label9);
            this.printPannel.Controls.Add(this.E_RoomNo);
            this.printPannel.Controls.Add(this.AuthenticationNo);
            this.printPannel.Controls.Add(this.E_phoneNo);
            this.printPannel.Controls.Add(this.authent);
            this.printPannel.Controls.Add(this.E_buldingNo);
            this.printPannel.Controls.Add(this.label5);
            this.printPannel.Controls.Add(this.label10);
            this.printPannel.Controls.Add(this.E_lastname);
            this.printPannel.Controls.Add(this.label8);
            this.printPannel.Controls.Add(this.E_email);
            this.printPannel.Controls.Add(this.label6);
            this.printPannel.Controls.Add(this.label15);
            this.printPannel.Controls.Add(this.label3);
            this.printPannel.Controls.Add(this.label4);
            this.printPannel.Controls.Add(this.Expert_ID);
            this.printPannel.Controls.Add(this.label13);
            this.printPannel.Controls.Add(this.E_firstname);
            this.printPannel.Controls.Add(this.label2);
            this.printPannel.Controls.Add(this.Experts_In);
            this.printPannel.Controls.Add(this.label1);
            this.printPannel.Location = new System.Drawing.Point(13, 14);
            this.printPannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printPannel.Name = "printPannel";
            this.printPannel.Size = new System.Drawing.Size(812, 635);
            this.printPannel.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 45);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 20);
            this.label17.TabIndex = 79;
            this.label17.Text = "Expert\"s Photo";
            // 
            // ExpertPhoto
            // 
            this.ExpertPhoto.Location = new System.Drawing.Point(9, 71);
            this.ExpertPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpertPhoto.Name = "ExpertPhoto";
            this.ExpertPhoto.Size = new System.Drawing.Size(150, 165);
            this.ExpertPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpertPhoto.TabIndex = 78;
            this.ExpertPhoto.TabStop = false;
            // 
            // E_birthDate
            // 
            this.E_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.E_birthDate.Location = new System.Drawing.Point(144, 425);
            this.E_birthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_birthDate.Name = "E_birthDate";
            this.E_birthDate.Size = new System.Drawing.Size(140, 26);
            this.E_birthDate.TabIndex = 77;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(282, 383);
            this.Female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(87, 24);
            this.Female.TabIndex = 76;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(144, 382);
            this.Male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(68, 24);
            this.Male.TabIndex = 75;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 386);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 74;
            this.label14.Text = "Gender";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Gray;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(702, 131);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 35);
            this.Search.TabIndex = 73;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.SearchBt);
            // 
            // SearchE_ID
            // 
            this.SearchE_ID.Location = new System.Drawing.Point(516, 134);
            this.SearchE_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchE_ID.Name = "SearchE_ID";
            this.SearchE_ID.Size = new System.Drawing.Size(175, 26);
            this.SearchE_ID.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 138);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Search by ID:";
            // 
            // campus
            // 
            this.campus.FormattingEnabled = true;
            this.campus.Items.AddRange(new object[] {
            "Atse Tewodros Campus",
            "Atse Fasil Campus",
            "Maraki Campus",
            "GC Campus",
            "Tseda Campus"});
            this.campus.Location = new System.Drawing.Point(538, 342);
            this.campus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campus.Name = "campus";
            this.campus.Size = new System.Drawing.Size(262, 28);
            this.campus.TabIndex = 70;
            this.campus.Text = "Select";
            // 
            // Clear_bt
            // 
            this.Clear_bt.BackColor = System.Drawing.Color.Gray;
            this.Clear_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_bt.ForeColor = System.Drawing.Color.White;
            this.Clear_bt.Location = new System.Drawing.Point(446, 577);
            this.Clear_bt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear_bt.Name = "Clear_bt";
            this.Clear_bt.Size = new System.Drawing.Size(84, 35);
            this.Clear_bt.TabIndex = 69;
            this.Clear_bt.Text = "Clear";
            this.Clear_bt.UseVisualStyleBackColor = false;
            this.Clear_bt.Click += new System.EventHandler(this.clear);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Gray;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.ForeColor = System.Drawing.Color.White;
            this.Browse.Location = new System.Drawing.Point(174, 200);
            this.Browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(112, 35);
            this.Browse.TabIndex = 68;
            this.Browse.Text = "BROWSE";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.photo);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 598);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Educational level";
            // 
            // E_Edulevel
            // 
            this.E_Edulevel.FormattingEnabled = true;
            this.E_Edulevel.Items.AddRange(new object[] {
            "Bsc",
            "Msc",
            "PhD"});
            this.E_Edulevel.Location = new System.Drawing.Point(144, 594);
            this.E_Edulevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_Edulevel.Name = "E_Edulevel";
            this.E_Edulevel.Size = new System.Drawing.Size(262, 28);
            this.E_Edulevel.TabIndex = 66;
            this.E_Edulevel.Text = "Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Expert\'s Campus Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 386);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Building No:";
            // 
            // E_RoomNo
            // 
            this.E_RoomNo.Location = new System.Drawing.Point(538, 426);
            this.E_RoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_RoomNo.Name = "E_RoomNo";
            this.E_RoomNo.Size = new System.Drawing.Size(262, 26);
            this.E_RoomNo.TabIndex = 63;
            // 
            // AuthenticationNo
            // 
            this.AuthenticationNo.Location = new System.Drawing.Point(589, 466);
            this.AuthenticationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AuthenticationNo.MaxLength = 6;
            this.AuthenticationNo.Name = "AuthenticationNo";
            this.AuthenticationNo.Size = new System.Drawing.Size(208, 26);
            this.AuthenticationNo.TabIndex = 62;
            this.AuthenticationNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthenticationNo_KeyPress);
            // 
            // E_phoneNo
            // 
            this.E_phoneNo.Location = new System.Drawing.Point(144, 506);
            this.E_phoneNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_phoneNo.MaxLength = 10;
            this.E_phoneNo.Name = "E_phoneNo";
            this.E_phoneNo.Size = new System.Drawing.Size(264, 26);
            this.E_phoneNo.TabIndex = 64;
            this.E_phoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E_phoneNo_KeyPress);
            // 
            // authent
            // 
            this.authent.AutoSize = true;
            this.authent.Location = new System.Drawing.Point(441, 475);
            this.authent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authent.Name = "authent";
            this.authent.Size = new System.Drawing.Size(140, 20);
            this.authent.TabIndex = 50;
            this.authent.Text = "Authentication No:";
            // 
            // E_buldingNo
            // 
            this.E_buldingNo.Location = new System.Drawing.Point(538, 382);
            this.E_buldingNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_buldingNo.Name = "E_buldingNo";
            this.E_buldingNo.Size = new System.Drawing.Size(262, 26);
            this.E_buldingNo.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 512);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Phone No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Room No:";
            // 
            // E_lastname
            // 
            this.E_lastname.Location = new System.Drawing.Point(144, 348);
            this.E_lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_lastname.Name = "E_lastname";
            this.E_lastname.Size = new System.Drawing.Size(264, 26);
            this.E_lastname.TabIndex = 60;
            this.E_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E_lastname_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Campus:";
            // 
            // E_email
            // 
            this.E_email.Location = new System.Drawing.Point(144, 466);
            this.E_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_email.Name = "E_email";
            this.E_email.Size = new System.Drawing.Size(264, 26);
            this.E_email.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 558);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Experts in:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 429);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Birth date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email Address:";
            // 
            // Expert_ID
            // 
            this.Expert_ID.Location = new System.Drawing.Point(144, 268);
            this.Expert_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Expert_ID.Name = "Expert_ID";
            this.Expert_ID.Size = new System.Drawing.Size(264, 26);
            this.Expert_ID.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 271);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "Expert\"s ID";
            // 
            // E_firstname
            // 
            this.E_firstname.Location = new System.Drawing.Point(144, 308);
            this.E_firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.E_firstname.Name = "E_firstname";
            this.E_firstname.Size = new System.Drawing.Size(264, 26);
            this.E_firstname.TabIndex = 57;
            this.E_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E_firstname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "First Name:";
            // 
            // Experts_In
            // 
            this.Experts_In.FormattingEnabled = true;
            this.Experts_In.Location = new System.Drawing.Point(144, 552);
            this.Experts_In.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Experts_In.Name = "Experts_In";
            this.Experts_In.Size = new System.Drawing.Size(264, 28);
            this.Experts_In.TabIndex = 45;
            this.Experts_In.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 47);
            this.label1.TabIndex = 44;
            this.label1.Text = "Expert\'s Information";
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Gray;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.ForeColor = System.Drawing.Color.White;
            this.Print.Location = new System.Drawing.Point(555, 659);
            this.Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(112, 35);
            this.Print.TabIndex = 7;
            this.Print.Text = "PRINT";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // printExpertDoc
            // 
            this.printExpertDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printExpertDoc_PrintPage);
            // 
            // printExpert
            // 
            this.printExpert.UseEXDialog = true;
            // 
            // Helpers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 794);
            this.Controls.Add(this.printPannel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Helpers";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Helpers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.printPannel.ResumeLayout(false);
            this.printPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel printPannel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox ExpertPhoto;
        private System.Windows.Forms.DateTimePicker E_birthDate;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchE_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox campus;
        private System.Windows.Forms.Button Clear_bt;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox E_Edulevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox E_RoomNo;
        private System.Windows.Forms.TextBox AuthenticationNo;
        private System.Windows.Forms.TextBox E_phoneNo;
        private System.Windows.Forms.Label authent;
        private System.Windows.Forms.TextBox E_buldingNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox E_lastname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox E_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Expert_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox E_firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Experts_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Print;
        private System.Drawing.Printing.PrintDocument printExpertDoc;
        private System.Windows.Forms.PrintDialog printExpert;
    }
}