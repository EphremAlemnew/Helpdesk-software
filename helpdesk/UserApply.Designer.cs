namespace WindowsFormsApplication1
{
    partial class UserApply
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
            this.pro_priority = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pro_Room = new System.Windows.Forms.TextBox();
            this.Pro_building = new System.Windows.Forms.TextBox();
            this.Pro_title = new System.Windows.Forms.TextBox();
            this.pro_Campus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pro_disc = new System.Windows.Forms.TextBox();
            this.no_more = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ticketNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pro_priority
            // 
            this.pro_priority.FormattingEnabled = true;
            this.pro_priority.Items.AddRange(new object[] {
            "EXTREME HIGH",
            "HIGH",
            "MEDIUM",
            "LOW"});
            this.pro_priority.Location = new System.Drawing.Point(279, 197);
            this.pro_priority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pro_priority.Name = "pro_priority";
            this.pro_priority.Size = new System.Drawing.Size(142, 28);
            this.pro_priority.TabIndex = 22;
            this.pro_priority.Text = "Select";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(306, 571);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.submit);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(675, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clear);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Problem Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Room No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Building No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Campus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Problem Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Problem Priority:";
            // 
            // Pro_Room
            // 
            this.Pro_Room.Location = new System.Drawing.Point(212, 318);
            this.Pro_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_Room.Name = "Pro_Room";
            this.Pro_Room.Size = new System.Drawing.Size(181, 26);
            this.Pro_Room.TabIndex = 12;
            // 
            // Pro_building
            // 
            this.Pro_building.Location = new System.Drawing.Point(570, 274);
            this.Pro_building.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_building.Name = "Pro_building";
            this.Pro_building.Size = new System.Drawing.Size(198, 26);
            this.Pro_building.TabIndex = 11;
            // 
            // Pro_title
            // 
            this.Pro_title.Location = new System.Drawing.Point(244, 155);
            this.Pro_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_title.Name = "Pro_title";
            this.Pro_title.Size = new System.Drawing.Size(310, 26);
            this.Pro_title.TabIndex = 10;
            // 
            // pro_Campus
            // 
            this.pro_Campus.FormattingEnabled = true;
            this.pro_Campus.Items.AddRange(new object[] {
            "Atse Tewodros Campus",
            "Atse Fasil Campus",
            "Maraki Campus",
            "GC Campus",
            "Tseda Campus"});
            this.pro_Campus.Location = new System.Drawing.Point(210, 277);
            this.pro_Campus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pro_Campus.Name = "pro_Campus";
            this.pro_Campus.Size = new System.Drawing.Size(182, 28);
            this.pro_Campus.TabIndex = 8;
            this.pro_Campus.Text = "Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fill the following Informations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 43);
            this.panel1.TabIndex = 23;
            // 
            // Pro_disc
            // 
            this.Pro_disc.Location = new System.Drawing.Point(306, 358);
            this.Pro_disc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_disc.Multiline = true;
            this.Pro_disc.Name = "Pro_disc";
            this.Pro_disc.Size = new System.Drawing.Size(358, 190);
            this.Pro_disc.TabIndex = 13;
            this.Pro_disc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pro_disc_KeyPress);
            // 
            // no_more
            // 
            this.no_more.AutoSize = true;
            this.no_more.BackColor = System.Drawing.Color.White;
            this.no_more.Location = new System.Drawing.Point(308, 360);
            this.no_more.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.no_more.Name = "no_more";
            this.no_more.Size = new System.Drawing.Size(188, 20);
            this.no_more.TabIndex = 24;
            this.no_more.Text = "No more than 300 letters!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Problem category";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(639, 91);
            this.category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(264, 28);
            this.category.TabIndex = 25;
            this.category.Text = "Select";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 579);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ticket No";
            // 
            // ticketNo
            // 
            this.ticketNo.Location = new System.Drawing.Point(570, 580);
            this.ticketNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticketNo.Name = "ticketNo";
            this.ticketNo.ReadOnly = true;
            this.ticketNo.Size = new System.Drawing.Size(198, 26);
            this.ticketNo.TabIndex = 26;
            // 
            // UserApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 688);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ticketNo);
            this.Controls.Add(this.category);
            this.Controls.Add(this.no_more);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pro_priority);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pro_disc);
            this.Controls.Add(this.Pro_Room);
            this.Controls.Add(this.Pro_building);
            this.Controls.Add(this.Pro_title);
            this.Controls.Add(this.pro_Campus);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(460, 180);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserApply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserApply";
            this.Load += new System.EventHandler(this.UserApply_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pro_priority;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pro_Room;
        private System.Windows.Forms.TextBox Pro_building;
        private System.Windows.Forms.TextBox Pro_title;
        private System.Windows.Forms.ComboBox pro_Campus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Pro_disc;
        private System.Windows.Forms.Label no_more;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ticketNo;
    }
}