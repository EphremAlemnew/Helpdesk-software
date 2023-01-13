namespace WindowsFormsApplication1
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.mainpannel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Alabel = new System.Windows.Forms.Label();
            this.dash = new System.Windows.Forms.Button();
            this.Rqe_st = new System.Windows.Forms.Button();
            this.expert = new System.Windows.Forms.Button();
            this.allexpert = new System.Windows.Forms.Button();
            this.Problem_Category = new System.Windows.Forms.Button();
            this.assign = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.usPass = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.LogRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.LogRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpannel
            // 
            this.mainpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpannel.Location = new System.Drawing.Point(343, 45);
            this.mainpannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainpannel.Name = "mainpannel";
            this.mainpannel.Size = new System.Drawing.Size(973, 749);
            this.mainpannel.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.dash);
            this.flowLayoutPanel1.Controls.Add(this.Rqe_st);
            this.flowLayoutPanel1.Controls.Add(this.expert);
            this.flowLayoutPanel1.Controls.Add(this.allexpert);
            this.flowLayoutPanel1.Controls.Add(this.Problem_Category);
            this.flowLayoutPanel1.Controls.Add(this.assign);
            this.flowLayoutPanel1.Controls.Add(this.feedback);
            this.flowLayoutPanel1.Controls.Add(this.usPass);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(343, 749);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Alabel);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 195);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.LogRight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alabel.ForeColor = System.Drawing.Color.White;
            this.Alabel.Location = new System.Drawing.Point(89, 149);
            this.Alabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(104, 34);
            this.Alabel.TabIndex = 2;
            this.Alabel.Text = "Admin";
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.Gray;
            this.dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dash.FlatAppearance.BorderSize = 0;
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.ForeColor = System.Drawing.Color.White;
            this.dash.Image = ((System.Drawing.Image)(resources.GetObject("dash.Image")));
            this.dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash.Location = new System.Drawing.Point(4, 210);
            this.dash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(328, 52);
            this.dash.TabIndex = 0;
            this.dash.Text = "DASHBOARD";
            this.dash.UseVisualStyleBackColor = false;
            this.dash.Click += new System.EventHandler(this.Admin_dash);
            // 
            // Rqe_st
            // 
            this.Rqe_st.BackColor = System.Drawing.Color.Gray;
            this.Rqe_st.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rqe_st.FlatAppearance.BorderSize = 0;
            this.Rqe_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rqe_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rqe_st.ForeColor = System.Drawing.Color.White;
            this.Rqe_st.Image = ((System.Drawing.Image)(resources.GetObject("Rqe_st.Image")));
            this.Rqe_st.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rqe_st.Location = new System.Drawing.Point(4, 272);
            this.Rqe_st.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rqe_st.Name = "Rqe_st";
            this.Rqe_st.Size = new System.Drawing.Size(328, 52);
            this.Rqe_st.TabIndex = 0;
            this.Rqe_st.Text = "REQUESTS";
            this.Rqe_st.UseVisualStyleBackColor = false;
            this.Rqe_st.Click += new System.EventHandler(this.request);
            // 
            // expert
            // 
            this.expert.BackColor = System.Drawing.Color.Gray;
            this.expert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expert.FlatAppearance.BorderSize = 0;
            this.expert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expert.ForeColor = System.Drawing.Color.White;
            this.expert.Image = ((System.Drawing.Image)(resources.GetObject("expert.Image")));
            this.expert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expert.Location = new System.Drawing.Point(4, 334);
            this.expert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(328, 52);
            this.expert.TabIndex = 0;
            this.expert.Text = "EXPERTS";
            this.expert.UseVisualStyleBackColor = false;
            this.expert.Click += new System.EventHandler(this.helper);
            // 
            // allexpert
            // 
            this.allexpert.BackColor = System.Drawing.Color.Gray;
            this.allexpert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.allexpert.FlatAppearance.BorderSize = 0;
            this.allexpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allexpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allexpert.ForeColor = System.Drawing.Color.White;
            this.allexpert.Image = ((System.Drawing.Image)(resources.GetObject("allexpert.Image")));
            this.allexpert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allexpert.Location = new System.Drawing.Point(4, 396);
            this.allexpert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allexpert.Name = "allexpert";
            this.allexpert.Size = new System.Drawing.Size(328, 52);
            this.allexpert.TabIndex = 0;
            this.allexpert.Text = "ALL EXPERTS";
            this.allexpert.UseVisualStyleBackColor = false;
            this.allexpert.Click += new System.EventHandler(this.all_experts);
            // 
            // Problem_Category
            // 
            this.Problem_Category.BackColor = System.Drawing.Color.Gray;
            this.Problem_Category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Problem_Category.FlatAppearance.BorderSize = 0;
            this.Problem_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Problem_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Problem_Category.ForeColor = System.Drawing.Color.White;
            this.Problem_Category.Image = ((System.Drawing.Image)(resources.GetObject("Problem_Category.Image")));
            this.Problem_Category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Problem_Category.Location = new System.Drawing.Point(4, 458);
            this.Problem_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Problem_Category.Name = "Problem_Category";
            this.Problem_Category.Size = new System.Drawing.Size(328, 52);
            this.Problem_Category.TabIndex = 0;
            this.Problem_Category.Text = "PROBLEM CATEGORY";
            this.Problem_Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Problem_Category.UseVisualStyleBackColor = false;
            this.Problem_Category.Click += new System.EventHandler(this.admin_Category);
            // 
            // assign
            // 
            this.assign.BackColor = System.Drawing.Color.Gray;
            this.assign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.assign.FlatAppearance.BorderSize = 0;
            this.assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign.ForeColor = System.Drawing.Color.White;
            this.assign.Image = ((System.Drawing.Image)(resources.GetObject("assign.Image")));
            this.assign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assign.Location = new System.Drawing.Point(4, 520);
            this.assign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(315, 52);
            this.assign.TabIndex = 0;
            this.assign.Text = "ASSIGNED TASKS";
            this.assign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.assign.UseVisualStyleBackColor = false;
            this.assign.Click += new System.EventHandler(this.Assigned_Tasks);
            // 
            // feedback
            // 
            this.feedback.BackColor = System.Drawing.Color.Gray;
            this.feedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.feedback.FlatAppearance.BorderSize = 0;
            this.feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback.ForeColor = System.Drawing.Color.White;
            this.feedback.Image = ((System.Drawing.Image)(resources.GetObject("feedback.Image")));
            this.feedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedback.Location = new System.Drawing.Point(4, 582);
            this.feedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(315, 52);
            this.feedback.TabIndex = 0;
            this.feedback.Text = "FEEDBACKS";
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.Click += new System.EventHandler(this.admin_Feedback);
            // 
            // usPass
            // 
            this.usPass.BackColor = System.Drawing.Color.Gray;
            this.usPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usPass.FlatAppearance.BorderSize = 0;
            this.usPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usPass.ForeColor = System.Drawing.Color.White;
            this.usPass.Image = ((System.Drawing.Image)(resources.GetObject("usPass.Image")));
            this.usPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usPass.Location = new System.Drawing.Point(4, 644);
            this.usPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usPass.Name = "usPass";
            this.usPass.Size = new System.Drawing.Size(315, 52);
            this.usPass.TabIndex = 0;
            this.usPass.Text = "USER PASSWORD";
            this.usPass.UseVisualStyleBackColor = false;
            this.usPass.Click += new System.EventHandler(this.UsPass_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(4, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "←";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.back);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1244, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.exit);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.ContextMenuStrip = this.LogRight;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 45);
            this.panel2.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(1171, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 52);
            this.button8.TabIndex = 5;
            this.button8.Text = "__";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.minimize_button);
            // 
            // LogRight
            // 
            this.LogRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem});
            this.LogRight.Name = "LogRight";
            this.LogRight.Size = new System.Drawing.Size(158, 34);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.lOGOUTToolStripMenuItem.Text = "LOG OUT";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 794);
            this.ContextMenuStrip = this.LogRight;
            this.Controls.Add(this.mainpannel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.Text = "admin";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.LogRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpannel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.Button Rqe_st;
        private System.Windows.Forms.Button expert;
        private System.Windows.Forms.Button allexpert;
        private System.Windows.Forms.Button Problem_Category;
        private System.Windows.Forms.Button assign;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button usPass;
        private System.Windows.Forms.ContextMenuStrip LogRight;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}