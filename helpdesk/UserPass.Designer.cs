namespace WindowsFormsApplication1
{
    partial class UserPass
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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.currentUser = new System.Windows.Forms.TextBox();
            this.currentPass = new System.Windows.Forms.TextBox();
            this.tochange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.NewUser = new System.Windows.Forms.TextBox();
            this.changebt = new System.Windows.Forms.Button();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changepannel = new System.Windows.Forms.Panel();
            this.Userpas = new System.Windows.Forms.Panel();
            this.Auser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Apass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Button();
            this.logPannel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.changepannel.SuspendLayout();
            this.Userpas.SuspendLayout();
            this.logPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "Current User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Current Password";
            // 
            // currentUser
            // 
            this.currentUser.Location = new System.Drawing.Point(280, 36);
            this.currentUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentUser.Name = "currentUser";
            this.currentUser.ReadOnly = true;
            this.currentUser.Size = new System.Drawing.Size(300, 26);
            this.currentUser.TabIndex = 61;
            // 
            // currentPass
            // 
            this.currentPass.Location = new System.Drawing.Point(282, 72);
            this.currentPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentPass.Name = "currentPass";
            this.currentPass.ReadOnly = true;
            this.currentPass.Size = new System.Drawing.Size(298, 26);
            this.currentPass.TabIndex = 62;
            // 
            // tochange
            // 
            this.tochange.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tochange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tochange.ForeColor = System.Drawing.Color.White;
            this.tochange.Location = new System.Drawing.Point(249, 114);
            this.tochange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tochange.Name = "tochange";
            this.tochange.Size = new System.Drawing.Size(191, 35);
            this.tochange.TabIndex = 60;
            this.tochange.Text = "CLICK TO CHANGE";
            this.tochange.UseVisualStyleBackColor = false;
            this.tochange.Click += new System.EventHandler(this.tochange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "New User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "New Password";
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(191, 41);
            this.NewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(298, 26);
            this.NewPass.TabIndex = 62;
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(189, 5);
            this.NewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(300, 26);
            this.NewUser.TabIndex = 61;
            // 
            // changebt
            // 
            this.changebt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.changebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changebt.ForeColor = System.Drawing.Color.White;
            this.changebt.Location = new System.Drawing.Point(375, 113);
            this.changebt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changebt.Name = "changebt";
            this.changebt.Size = new System.Drawing.Size(112, 35);
            this.changebt.TabIndex = 60;
            this.changebt.Text = "CHANGE";
            this.changebt.UseVisualStyleBackColor = false;
            this.changebt.Click += new System.EventHandler(this.changebt_click);
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Location = new System.Drawing.Point(189, 77);
            this.ConfirmPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(298, 26);
            this.ConfirmPass.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Confirm Password";
            // 
            // changepannel
            // 
            this.changepannel.Controls.Add(this.NewUser);
            this.changepannel.Controls.Add(this.label2);
            this.changepannel.Controls.Add(this.NewPass);
            this.changepannel.Controls.Add(this.ConfirmPass);
            this.changepannel.Controls.Add(this.changebt);
            this.changepannel.Controls.Add(this.label3);
            this.changepannel.Controls.Add(this.label1);
            this.changepannel.Location = new System.Drawing.Point(93, 157);
            this.changepannel.Name = "changepannel";
            this.changepannel.Size = new System.Drawing.Size(497, 168);
            this.changepannel.TabIndex = 65;
            // 
            // Userpas
            // 
            this.Userpas.Controls.Add(this.currentUser);
            this.Userpas.Controls.Add(this.changepannel);
            this.Userpas.Controls.Add(this.tochange);
            this.Userpas.Controls.Add(this.label10);
            this.Userpas.Controls.Add(this.currentPass);
            this.Userpas.Controls.Add(this.label8);
            this.Userpas.Location = new System.Drawing.Point(121, 264);
            this.Userpas.Name = "Userpas";
            this.Userpas.Size = new System.Drawing.Size(687, 369);
            this.Userpas.TabIndex = 66;
            // 
            // Auser
            // 
            this.Auser.Location = new System.Drawing.Point(139, 22);
            this.Auser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Auser.Name = "Auser";
            this.Auser.Size = new System.Drawing.Size(300, 26);
            this.Auser.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "User Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Apass
            // 
            this.Apass.Location = new System.Drawing.Point(141, 58);
            this.Apass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Apass.Name = "Apass";
            this.Apass.Size = new System.Drawing.Size(298, 26);
            this.Apass.TabIndex = 68;
            this.Apass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 70;
            this.label5.Text = "Password";
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show.ForeColor = System.Drawing.Color.White;
            this.Show.Location = new System.Drawing.Point(338, 94);
            this.Show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(101, 35);
            this.Show.TabIndex = 71;
            this.Show.Text = "OK";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.show_Click);
            // 
            // logPannel
            // 
            this.logPannel.Controls.Add(this.Auser);
            this.logPannel.Controls.Add(this.Show);
            this.logPannel.Controls.Add(this.label5);
            this.logPannel.Controls.Add(this.Apass);
            this.logPannel.Controls.Add(this.label4);
            this.logPannel.Location = new System.Drawing.Point(198, 121);
            this.logPannel.Name = "logPannel";
            this.logPannel.Size = new System.Drawing.Size(467, 137);
            this.logPannel.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(637, 30);
            this.label6.TabIndex = 69;
            this.label6.Text = "You have to confirm user name and password First";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 720);
            this.Controls.Add(this.logPannel);
            this.Controls.Add(this.Userpas);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserPass";
            this.Text = "NET_M";
            this.changepannel.ResumeLayout(false);
            this.changepannel.PerformLayout();
            this.Userpas.ResumeLayout(false);
            this.Userpas.PerformLayout();
            this.logPannel.ResumeLayout(false);
            this.logPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox currentUser;
        private System.Windows.Forms.TextBox currentPass;
        private System.Windows.Forms.Button tochange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox NewUser;
        private System.Windows.Forms.Button changebt;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel changepannel;
        private System.Windows.Forms.Panel Userpas;
        private System.Windows.Forms.TextBox Auser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Apass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Panel logPannel;
        private System.Windows.Forms.Label label6;

    }
}