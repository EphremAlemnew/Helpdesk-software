namespace WindowsFormsApplication1
{
    partial class HelperHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperHome));
            this.mainpannel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Expert_Dashboard = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.LogRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.LogRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpannel
            // 
            this.mainpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpannel.Location = new System.Drawing.Point(291, 58);
            this.mainpannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainpannel.Name = "mainpannel";
            this.mainpannel.Size = new System.Drawing.Size(1002, 736);
            this.mainpannel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.elabel);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 243);
            this.panel1.TabIndex = 0;
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
            this.button4.Location = new System.Drawing.Point(4, 2);
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
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.LogRight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // elabel
            // 
            this.elabel.AutoSize = true;
            this.elabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elabel.ForeColor = System.Drawing.Color.White;
            this.elabel.Location = new System.Drawing.Point(93, 175);
            this.elabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elabel.Name = "elabel";
            this.elabel.Size = new System.Drawing.Size(104, 34);
            this.elabel.TabIndex = 2;
            this.elabel.Text = "Expert";
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
            this.button3.Location = new System.Drawing.Point(938, 5);
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
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 58);
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
            this.button8.Location = new System.Drawing.Point(850, 5);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 52);
            this.button8.TabIndex = 6;
            this.button8.Text = "__";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.minimize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.Expert_Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.feedback);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 794);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Expert_Dashboard
            // 
            this.Expert_Dashboard.BackColor = System.Drawing.Color.Gray;
            this.Expert_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Expert_Dashboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Expert_Dashboard.FlatAppearance.BorderSize = 0;
            this.Expert_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expert_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expert_Dashboard.ForeColor = System.Drawing.Color.White;
            this.Expert_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Expert_Dashboard.Image")));
            this.Expert_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Expert_Dashboard.Location = new System.Drawing.Point(4, 258);
            this.Expert_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Expert_Dashboard.Name = "Expert_Dashboard";
            this.Expert_Dashboard.Size = new System.Drawing.Size(286, 52);
            this.Expert_Dashboard.TabIndex = 0;
            this.Expert_Dashboard.Text = "DASHBOARD";
            this.Expert_Dashboard.UseVisualStyleBackColor = false;
            this.Expert_Dashboard.Click += new System.EventHandler(this.Expert_dash);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Gray;
            this.Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(4, 320);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(286, 52);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "YOUR TASKS";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.helpdash);
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
            this.feedback.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.feedback.Location = new System.Drawing.Point(4, 382);
            this.feedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(286, 60);
            this.feedback.TabIndex = 0;
            this.feedback.Text = "FEEDBACKS";
            this.feedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.Click += new System.EventHandler(this.button2_Click);
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
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // HelperHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 794);
            this.Controls.Add(this.mainpannel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HelperHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelperHome";
            this.Load += new System.EventHandler(this.HelperHome_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.LogRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label elabel;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Expert_Dashboard;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ContextMenuStrip LogRight;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}