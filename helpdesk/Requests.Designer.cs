namespace WindowsFormsApplication1
{
    partial class Requests
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
            this.label1 = new System.Windows.Forms.Label();
            this.requestData = new System.Windows.Forms.DataGridView();
            this.send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pro_disc = new System.Windows.Forms.TextBox();
            this.Pro_Room = new System.Windows.Forms.TextBox();
            this.problem_cat = new System.Windows.Forms.TextBox();
            this.Pro_building = new System.Windows.Forms.TextBox();
            this.Pro_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SendToExpert = new System.Windows.Forms.Button();
            this.SentDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pro_priority = new System.Windows.Forms.TextBox();
            this.pro_Campus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.selectPannel = new System.Windows.Forms.Panel();
            this.selectexpert = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ticket_NO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.requestData)).BeginInit();
            this.selectPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "REQUESTS";
            // 
            // requestData
            // 
            this.requestData.AllowUserToOrderColumns = true;
            this.requestData.BackgroundColor = System.Drawing.Color.White;
            this.requestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestData.Location = new System.Drawing.Point(8, 56);
            this.requestData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requestData.Name = "requestData";
            this.requestData.Size = new System.Drawing.Size(498, 637);
            this.requestData.TabIndex = 1;
            this.requestData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestData_CellContentClick);
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.DarkSlateGray;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(522, 615);
            this.send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(112, 35);
            this.send.TabIndex = 44;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Problem Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Room No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Building No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Campus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Problem Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Problem Priority:";
            // 
            // Pro_disc
            // 
            this.Pro_disc.Location = new System.Drawing.Point(603, 299);
            this.Pro_disc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_disc.Multiline = true;
            this.Pro_disc.Name = "Pro_disc";
            this.Pro_disc.ReadOnly = true;
            this.Pro_disc.Size = new System.Drawing.Size(358, 143);
            this.Pro_disc.TabIndex = 51;
            // 
            // Pro_Room
            // 
            this.Pro_Room.Location = new System.Drawing.Point(626, 232);
            this.Pro_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_Room.Name = "Pro_Room";
            this.Pro_Room.ReadOnly = true;
            this.Pro_Room.Size = new System.Drawing.Size(181, 26);
            this.Pro_Room.TabIndex = 50;
            // 
            // problem_cat
            // 
            this.problem_cat.Location = new System.Drawing.Point(689, 5);
            this.problem_cat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.problem_cat.Name = "problem_cat";
            this.problem_cat.ReadOnly = true;
            this.problem_cat.Size = new System.Drawing.Size(282, 26);
            this.problem_cat.TabIndex = 47;
            // 
            // Pro_building
            // 
            this.Pro_building.Location = new System.Drawing.Point(650, 196);
            this.Pro_building.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_building.Name = "Pro_building";
            this.Pro_building.ReadOnly = true;
            this.Pro_building.Size = new System.Drawing.Size(198, 26);
            this.Pro_building.TabIndex = 49;
            // 
            // Pro_title
            // 
            this.Pro_title.Location = new System.Drawing.Point(663, 45);
            this.Pro_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_title.Name = "Pro_title";
            this.Pro_title.ReadOnly = true;
            this.Pro_title.Size = new System.Drawing.Size(310, 26);
            this.Pro_title.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Address";
            // 
            // SendToExpert
            // 
            this.SendToExpert.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SendToExpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendToExpert.ForeColor = System.Drawing.Color.White;
            this.SendToExpert.Location = new System.Drawing.Point(522, 509);
            this.SendToExpert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendToExpert.Name = "SendToExpert";
            this.SendToExpert.Size = new System.Drawing.Size(196, 35);
            this.SendToExpert.TabIndex = 44;
            this.SendToExpert.Text = "ASSIGN AN EXPERT";
            this.SendToExpert.UseVisualStyleBackColor = false;
            this.SendToExpert.Click += new System.EventHandler(this.Send_ToExpert);
            // 
            // SentDate
            // 
            this.SentDate.Location = new System.Drawing.Point(661, 85);
            this.SentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SentDate.Name = "SentDate";
            this.SentDate.ReadOnly = true;
            this.SentDate.Size = new System.Drawing.Size(310, 26);
            this.SentDate.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(517, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 58;
            this.label9.Text = "Sent Date";
            // 
            // pro_priority
            // 
            this.pro_priority.Location = new System.Drawing.Point(704, 120);
            this.pro_priority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pro_priority.Name = "pro_priority";
            this.pro_priority.ReadOnly = true;
            this.pro_priority.Size = new System.Drawing.Size(266, 26);
            this.pro_priority.TabIndex = 48;
            // 
            // pro_Campus
            // 
            this.pro_Campus.Location = new System.Drawing.Point(613, 159);
            this.pro_Campus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pro_Campus.Name = "pro_Campus";
            this.pro_Campus.ReadOnly = true;
            this.pro_Campus.Size = new System.Drawing.Size(266, 26);
            this.pro_Campus.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Problem Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 25);
            this.label11.TabIndex = 59;
            this.label11.Text = "Select_Expert";
            // 
            // selectPannel
            // 
            this.selectPannel.Controls.Add(this.selectexpert);
            this.selectPannel.Controls.Add(this.label11);
            this.selectPannel.Location = new System.Drawing.Point(506, 553);
            this.selectPannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectPannel.Name = "selectPannel";
            this.selectPannel.Size = new System.Drawing.Size(485, 52);
            this.selectPannel.TabIndex = 60;
            // 
            // selectexpert
            // 
            this.selectexpert.FormattingEnabled = true;
            this.selectexpert.Location = new System.Drawing.Point(140, 12);
            this.selectexpert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectexpert.Name = "selectexpert";
            this.selectexpert.Size = new System.Drawing.Size(325, 28);
            this.selectexpert.TabIndex = 60;
            this.selectexpert.Text = "Select";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(646, 616);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 35);
            this.delete.TabIndex = 44;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(516, 655);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(367, 25);
            this.label12.TabIndex = 87;
            this.label12.Text = "Click on Sent_Date record to View";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(516, 458);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 25);
            this.label13.TabIndex = 89;
            this.label13.Text = "Ticket no";
            // 
            // ticket_NO
            // 
            this.ticket_NO.Location = new System.Drawing.Point(626, 456);
            this.ticket_NO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticket_NO.Name = "ticket_NO";
            this.ticket_NO.ReadOnly = true;
            this.ticket_NO.Size = new System.Drawing.Size(181, 26);
            this.ticket_NO.TabIndex = 88;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 794);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ticket_NO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.selectPannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pro_disc);
            this.Controls.Add(this.Pro_Room);
            this.Controls.Add(this.problem_cat);
            this.Controls.Add(this.Pro_building);
            this.Controls.Add(this.pro_Campus);
            this.Controls.Add(this.pro_priority);
            this.Controls.Add(this.SentDate);
            this.Controls.Add(this.Pro_title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SendToExpert);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.send);
            this.Controls.Add(this.requestData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Requests";
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestData)).EndInit();
            this.selectPannel.ResumeLayout(false);
            this.selectPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView requestData;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pro_disc;
        private System.Windows.Forms.TextBox Pro_Room;
        private System.Windows.Forms.TextBox problem_cat;
        private System.Windows.Forms.TextBox Pro_building;
        private System.Windows.Forms.TextBox Pro_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SendToExpert;
        private System.Windows.Forms.TextBox SentDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pro_priority;
        private System.Windows.Forms.TextBox pro_Campus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel selectPannel;
        private System.Windows.Forms.ComboBox selectexpert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ticket_NO;
    }
}