﻿namespace WindowsFormsApplication1
{
    partial class forgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassword));
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.SignConfirmPass = new System.Windows.Forms.TextBox();
            this.Signpassword = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.log_IN = new System.Windows.Forms.Button();
            this.signAuthentication = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.E_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Signusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ninvisible = new System.Windows.Forms.PictureBox();
            this.Nvisible = new System.Windows.Forms.PictureBox();
            this.Cinvisible = new System.Windows.Forms.PictureBox();
            this.Cvisible = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ninvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cinvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cvisible)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Gray;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(305, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "__";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.minimize);
            // 
            // SignConfirmPass
            // 
            this.SignConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignConfirmPass.Location = new System.Drawing.Point(164, 241);
            this.SignConfirmPass.Name = "SignConfirmPass";
            this.SignConfirmPass.Size = new System.Drawing.Size(173, 21);
            this.SignConfirmPass.TabIndex = 12;
            this.SignConfirmPass.UseSystemPasswordChar = true;
            this.SignConfirmPass.WordWrap = false;
            // 
            // Signpassword
            // 
            this.Signpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signpassword.Location = new System.Drawing.Point(164, 213);
            this.Signpassword.Name = "Signpassword";
            this.Signpassword.Size = new System.Drawing.Size(173, 21);
            this.Signpassword.TabIndex = 12;
            this.Signpassword.UseSystemPasswordChar = true;
            this.Signpassword.WordWrap = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(354, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.exit);
            // 
            // log_IN
            // 
            this.log_IN.BackColor = System.Drawing.Color.Gray;
            this.log_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_IN.ForeColor = System.Drawing.Color.White;
            this.log_IN.Location = new System.Drawing.Point(138, 278);
            this.log_IN.Name = "log_IN";
            this.log_IN.Size = new System.Drawing.Size(151, 23);
            this.log_IN.TabIndex = 14;
            this.log_IN.Text = "RESET PASSWORD";
            this.log_IN.UseVisualStyleBackColor = false;
            this.log_IN.Click += new System.EventHandler(this.log_IN_Click);
            // 
            // signAuthentication
            // 
            this.signAuthentication.Location = new System.Drawing.Point(164, 160);
            this.signAuthentication.MaxLength = 6;
            this.signAuthentication.Name = "signAuthentication";
            this.signAuthentication.Size = new System.Drawing.Size(173, 20);
            this.signAuthentication.TabIndex = 11;
            this.signAuthentication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signAuthentication_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(67, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Authentication No:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.back);
            // 
            // E_ID
            // 
            this.E_ID.Location = new System.Drawing.Point(164, 134);
            this.E_ID.Name = "E_ID";
            this.E_ID.Size = new System.Drawing.Size(173, 20);
            this.E_ID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(67, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Expert ID";
            // 
            // Signusername
            // 
            this.Signusername.Location = new System.Drawing.Point(164, 185);
            this.Signusername.Name = "Signusername";
            this.Signusername.Size = new System.Drawing.Size(173, 20);
            this.Signusername.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(66, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(67, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(67, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(113, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "FORGOT PASSWORD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Cinvisible);
            this.panel2.Controls.Add(this.Cvisible);
            this.panel2.Controls.Add(this.Ninvisible);
            this.panel2.Controls.Add(this.Nvisible);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.SignConfirmPass);
            this.panel2.Controls.Add(this.Signpassword);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.log_IN);
            this.panel2.Controls.Add(this.signAuthentication);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.E_ID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Signusername);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 347);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 347);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Ninvisible
            // 
            this.Ninvisible.Image = ((System.Drawing.Image)(resources.GetObject("Ninvisible.Image")));
            this.Ninvisible.Location = new System.Drawing.Point(311, 217);
            this.Ninvisible.Name = "Ninvisible";
            this.Ninvisible.Size = new System.Drawing.Size(24, 14);
            this.Ninvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ninvisible.TabIndex = 17;
            this.Ninvisible.TabStop = false;
            this.Ninvisible.Click += new System.EventHandler(this.Ninvisible_Click);
            // 
            // Nvisible
            // 
            this.Nvisible.Image = ((System.Drawing.Image)(resources.GetObject("Nvisible.Image")));
            this.Nvisible.Location = new System.Drawing.Point(310, 214);
            this.Nvisible.Name = "Nvisible";
            this.Nvisible.Size = new System.Drawing.Size(25, 20);
            this.Nvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nvisible.TabIndex = 18;
            this.Nvisible.TabStop = false;
            this.Nvisible.Click += new System.EventHandler(this.Nvisible_Click);
            // 
            // Cinvisible
            // 
            this.Cinvisible.Image = ((System.Drawing.Image)(resources.GetObject("Cinvisible.Image")));
            this.Cinvisible.Location = new System.Drawing.Point(311, 246);
            this.Cinvisible.Name = "Cinvisible";
            this.Cinvisible.Size = new System.Drawing.Size(24, 14);
            this.Cinvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cinvisible.TabIndex = 19;
            this.Cinvisible.TabStop = false;
            this.Cinvisible.Click += new System.EventHandler(this.Cinvisible_Click);
            // 
            // Cvisible
            // 
            this.Cvisible.Image = ((System.Drawing.Image)(resources.GetObject("Cvisible.Image")));
            this.Cvisible.Location = new System.Drawing.Point(310, 242);
            this.Cvisible.Name = "Cvisible";
            this.Cvisible.Size = new System.Drawing.Size(25, 20);
            this.Cvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cvisible.TabIndex = 20;
            this.Cvisible.TabStop = false;
            this.Cvisible.Click += new System.EventHandler(this.Cvisible_Click);
            // 
            // forgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 347);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ninvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cinvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cvisible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox SignConfirmPass;
        private System.Windows.Forms.TextBox Signpassword;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button log_IN;
        private System.Windows.Forms.TextBox signAuthentication;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox E_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Signusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Cinvisible;
        private System.Windows.Forms.PictureBox Cvisible;
        private System.Windows.Forms.PictureBox Ninvisible;
        private System.Windows.Forms.PictureBox Nvisible;
    }
}