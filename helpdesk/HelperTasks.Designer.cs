namespace WindowsFormsApplication1
{
    partial class HelperTasks
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pro_disc = new System.Windows.Forms.TextBox();
            this.Pro_Room = new System.Windows.Forms.TextBox();
            this.Pro_building = new System.Windows.Forms.TextBox();
            this.pro_Campus = new System.Windows.Forms.TextBox();
            this.pro_priority = new System.Windows.Forms.TextBox();
            this.SentDate = new System.Windows.Forms.TextBox();
            this.Pro_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.taskData = new System.Windows.Forms.DataGridView();
            this.expert_name = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dear Expert You have the following Tasks to do!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 79;
            this.label3.Text = "Problem Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Room No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Building No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "Campus:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = "Sent Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 82;
            this.label10.Text = "Expert Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "Problem Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Problem Priority:";
            // 
            // Pro_disc
            // 
            this.Pro_disc.Location = new System.Drawing.Point(610, 345);
            this.Pro_disc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_disc.Multiline = true;
            this.Pro_disc.Name = "Pro_disc";
            this.Pro_disc.ReadOnly = true;
            this.Pro_disc.Size = new System.Drawing.Size(358, 190);
            this.Pro_disc.TabIndex = 74;
            // 
            // Pro_Room
            // 
            this.Pro_Room.Location = new System.Drawing.Point(634, 283);
            this.Pro_Room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_Room.Name = "Pro_Room";
            this.Pro_Room.ReadOnly = true;
            this.Pro_Room.Size = new System.Drawing.Size(181, 26);
            this.Pro_Room.TabIndex = 73;
            // 
            // Pro_building
            // 
            this.Pro_building.Location = new System.Drawing.Point(657, 242);
            this.Pro_building.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_building.Name = "Pro_building";
            this.Pro_building.ReadOnly = true;
            this.Pro_building.Size = new System.Drawing.Size(198, 26);
            this.Pro_building.TabIndex = 72;
            // 
            // pro_Campus
            // 
            this.pro_Campus.Location = new System.Drawing.Point(620, 205);
            this.pro_Campus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pro_Campus.Name = "pro_Campus";
            this.pro_Campus.ReadOnly = true;
            this.pro_Campus.Size = new System.Drawing.Size(266, 26);
            this.pro_Campus.TabIndex = 68;
            // 
            // pro_priority
            // 
            this.pro_priority.Location = new System.Drawing.Point(711, 166);
            this.pro_priority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pro_priority.Name = "pro_priority";
            this.pro_priority.ReadOnly = true;
            this.pro_priority.Size = new System.Drawing.Size(266, 26);
            this.pro_priority.TabIndex = 69;
            // 
            // SentDate
            // 
            this.SentDate.Location = new System.Drawing.Point(668, 131);
            this.SentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SentDate.Name = "SentDate";
            this.SentDate.ReadOnly = true;
            this.SentDate.Size = new System.Drawing.Size(310, 26);
            this.SentDate.TabIndex = 70;
            // 
            // Pro_title
            // 
            this.Pro_title.Location = new System.Drawing.Point(668, 89);
            this.Pro_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pro_title.Name = "Pro_title";
            this.Pro_title.ReadOnly = true;
            this.Pro_title.Size = new System.Drawing.Size(310, 26);
            this.Pro_title.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "Address";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.DarkSlateGray;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(530, 540);
            this.send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(112, 35);
            this.send.TabIndex = 63;
            this.send.Text = "DONE";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // taskData
            // 
            this.taskData.AllowUserToOrderColumns = true;
            this.taskData.BackgroundColor = System.Drawing.Color.White;
            this.taskData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskData.Location = new System.Drawing.Point(16, 49);
            this.taskData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taskData.Name = "taskData";
            this.taskData.Size = new System.Drawing.Size(498, 600);
            this.taskData.TabIndex = 62;
            this.taskData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestData_CellContentClick);
            // 
            // expert_name
            // 
            this.expert_name.FormattingEnabled = true;
            this.expert_name.Location = new System.Drawing.Point(668, 49);
            this.expert_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expert_name.Name = "expert_name";
            this.expert_name.Size = new System.Drawing.Size(307, 28);
            this.expert_name.TabIndex = 83;
            this.expert_name.Text = "Select";
            this.expert_name.SelectedIndexChanged += new System.EventHandler(this.expert_name_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(646, 552);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 50);
            this.label11.TabIndex = 84;
            this.label11.Text = "If any thing is empty,\r\n you have to select your Name";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(525, 621);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(367, 25);
            this.label12.TabIndex = 86;
            this.label12.Text = "Click on Sent_Date record to View";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelperTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 735);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.expert_name);
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
            this.Controls.Add(this.Pro_building);
            this.Controls.Add(this.pro_Campus);
            this.Controls.Add(this.pro_priority);
            this.Controls.Add(this.SentDate);
            this.Controls.Add(this.Pro_title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.send);
            this.Controls.Add(this.taskData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HelperTasks";
            this.Text = "HelperDash";
            this.Load += new System.EventHandler(this.HelperTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pro_disc;
        private System.Windows.Forms.TextBox Pro_Room;
        private System.Windows.Forms.TextBox Pro_building;
        private System.Windows.Forms.TextBox pro_Campus;
        private System.Windows.Forms.TextBox pro_priority;
        private System.Windows.Forms.TextBox SentDate;
        private System.Windows.Forms.TextBox Pro_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.DataGridView taskData;
        private System.Windows.Forms.ComboBox expert_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}