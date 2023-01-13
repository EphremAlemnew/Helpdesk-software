namespace WindowsFormsApplication1
{
    partial class AdminDash
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
            this.admin_dash1 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.TextBox();
            this.Requested_date = new System.Windows.Forms.TextBox();
            this.problem_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_dash2 = new System.Windows.Forms.Panel();
            this.expertName = new System.Windows.Forms.TextBox();
            this.SentDate = new System.Windows.Forms.TextBox();
            this.EComment = new System.Windows.Forms.TextBox();
            this.senderName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.admin_dash3 = new System.Windows.Forms.Panel();
            this.Ocomment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SenderName2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SentDate2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.admin_dash1.SuspendLayout();
            this.admin_dash2.SuspendLayout();
            this.admin_dash3.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_dash1
            // 
            this.admin_dash1.Controls.Add(this.category);
            this.admin_dash1.Controls.Add(this.Priority);
            this.admin_dash1.Controls.Add(this.Requested_date);
            this.admin_dash1.Controls.Add(this.problem_Title);
            this.admin_dash1.Controls.Add(this.label3);
            this.admin_dash1.Controls.Add(this.label6);
            this.admin_dash1.Controls.Add(this.label4);
            this.admin_dash1.Controls.Add(this.label2);
            this.admin_dash1.Controls.Add(this.label1);
            this.admin_dash1.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_dash1.Location = new System.Drawing.Point(0, 0);
            this.admin_dash1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin_dash1.Name = "admin_dash1";
            this.admin_dash1.Size = new System.Drawing.Size(996, 212);
            this.admin_dash1.TabIndex = 0;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(156, 91);
            this.category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(349, 26);
            this.category.TabIndex = 9;
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(84, 166);
            this.Priority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Size = new System.Drawing.Size(229, 26);
            this.Priority.TabIndex = 9;
            // 
            // Requested_date
            // 
            this.Requested_date.Location = new System.Drawing.Point(147, 129);
            this.Requested_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Requested_date.Name = "Requested_date";
            this.Requested_date.ReadOnly = true;
            this.Requested_date.Size = new System.Drawing.Size(256, 26);
            this.Requested_date.TabIndex = 9;
            // 
            // problem_Title
            // 
            this.problem_Title.Location = new System.Drawing.Point(128, 51);
            this.problem_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.problem_Title.Name = "problem_Title";
            this.problem_Title.ReadOnly = true;
            this.problem_Title.Size = new System.Drawing.Size(378, 26);
            this.problem_Title.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Problem Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Requested Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "There is new request from the user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem Title";
            // 
            // admin_dash2
            // 
            this.admin_dash2.Controls.Add(this.expertName);
            this.admin_dash2.Controls.Add(this.SentDate);
            this.admin_dash2.Controls.Add(this.EComment);
            this.admin_dash2.Controls.Add(this.senderName);
            this.admin_dash2.Controls.Add(this.label5);
            this.admin_dash2.Controls.Add(this.label8);
            this.admin_dash2.Controls.Add(this.label16);
            this.admin_dash2.Controls.Add(this.label9);
            this.admin_dash2.Controls.Add(this.label10);
            this.admin_dash2.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_dash2.Location = new System.Drawing.Point(0, 212);
            this.admin_dash2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin_dash2.Name = "admin_dash2";
            this.admin_dash2.Size = new System.Drawing.Size(996, 238);
            this.admin_dash2.TabIndex = 1;
            this.admin_dash2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // expertName
            // 
            this.expertName.Location = new System.Drawing.Point(124, 88);
            this.expertName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expertName.Name = "expertName";
            this.expertName.ReadOnly = true;
            this.expertName.Size = new System.Drawing.Size(256, 26);
            this.expertName.TabIndex = 9;
            // 
            // SentDate
            // 
            this.SentDate.Location = new System.Drawing.Point(106, 126);
            this.SentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SentDate.Name = "SentDate";
            this.SentDate.ReadOnly = true;
            this.SentDate.Size = new System.Drawing.Size(256, 26);
            this.SentDate.TabIndex = 9;
            // 
            // EComment
            // 
            this.EComment.Location = new System.Drawing.Point(530, 48);
            this.EComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EComment.Multiline = true;
            this.EComment.Name = "EComment";
            this.EComment.ReadOnly = true;
            this.EComment.Size = new System.Drawing.Size(350, 179);
            this.EComment.TabIndex = 9;
            // 
            // senderName
            // 
            this.senderName.Location = new System.Drawing.Point(124, 48);
            this.senderName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.senderName.Name = "senderName";
            this.senderName.ReadOnly = true;
            this.senderName.Size = new System.Drawing.Size(294, 26);
            this.senderName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Expert Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sent Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(450, 49);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Comment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(469, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "There is new feedback on experts from the user";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sender Name";
            // 
            // admin_dash3
            // 
            this.admin_dash3.Controls.Add(this.Ocomment);
            this.admin_dash3.Controls.Add(this.label11);
            this.admin_dash3.Controls.Add(this.SenderName2);
            this.admin_dash3.Controls.Add(this.label17);
            this.admin_dash3.Controls.Add(this.SentDate2);
            this.admin_dash3.Controls.Add(this.label13);
            this.admin_dash3.Controls.Add(this.label14);
            this.admin_dash3.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_dash3.Location = new System.Drawing.Point(0, 450);
            this.admin_dash3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.admin_dash3.Name = "admin_dash3";
            this.admin_dash3.Size = new System.Drawing.Size(996, 240);
            this.admin_dash3.TabIndex = 2;
            // 
            // Ocomment
            // 
            this.Ocomment.Location = new System.Drawing.Point(525, 54);
            this.Ocomment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ocomment.Multiline = true;
            this.Ocomment.Name = "Ocomment";
            this.Ocomment.ReadOnly = true;
            this.Ocomment.Size = new System.Drawing.Size(350, 179);
            this.Ocomment.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Comment";
            // 
            // SenderName2
            // 
            this.SenderName2.Location = new System.Drawing.Point(124, 57);
            this.SenderName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SenderName2.Name = "SenderName2";
            this.SenderName2.ReadOnly = true;
            this.SenderName2.Size = new System.Drawing.Size(256, 26);
            this.SenderName2.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Sender Name";
            // 
            // SentDate2
            // 
            this.SentDate2.Location = new System.Drawing.Point(123, 95);
            this.SentDate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SentDate2.Name = "SentDate2";
            this.SentDate2.ReadOnly = true;
            this.SentDate2.Size = new System.Drawing.Size(256, 26);
            this.SentDate2.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Sent Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(234, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(362, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "There is new feedback from the user";
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 737);
            this.Controls.Add(this.admin_dash3);
            this.Controls.Add(this.admin_dash2);
            this.Controls.Add(this.admin_dash1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDash";
            this.Text = "AdminDash";
            this.Load += new System.EventHandler(this.AdminDash_Load);
            this.admin_dash1.ResumeLayout(false);
            this.admin_dash1.PerformLayout();
            this.admin_dash2.ResumeLayout(false);
            this.admin_dash2.PerformLayout();
            this.admin_dash3.ResumeLayout(false);
            this.admin_dash3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admin_dash1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox Requested_date;
        private System.Windows.Forms.TextBox problem_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Priority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel admin_dash2;
        private System.Windows.Forms.TextBox expertName;
        private System.Windows.Forms.TextBox SentDate;
        private System.Windows.Forms.TextBox senderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel admin_dash3;
        private System.Windows.Forms.TextBox SentDate2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EComment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Ocomment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SenderName2;
        private System.Windows.Forms.Label label17;

    }
}