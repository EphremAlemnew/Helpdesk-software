namespace WindowsFormsApplication1
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uLabel = new System.Windows.Forms.Label();
            this.AskFOR = new System.Windows.Forms.Button();
            this.Acknow = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainpannel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.AskFOR);
            this.flowLayoutPanel1.Controls.Add(this.Acknow);
            this.flowLayoutPanel1.Controls.Add(this.Feed);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 794);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.uLabel);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 243);
            this.panel1.TabIndex = 0;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Gray;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(4, 3);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(58, 41);
            this.back.TabIndex = 0;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button4_Click);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            this.back.MouseHover += new System.EventHandler(this.back_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.LogRight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // uLabel
            // 
            this.uLabel.AutoSize = true;
            this.uLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uLabel.ForeColor = System.Drawing.Color.White;
            this.uLabel.Location = new System.Drawing.Point(100, 175);
            this.uLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uLabel.Name = "uLabel";
            this.uLabel.Size = new System.Drawing.Size(75, 34);
            this.uLabel.TabIndex = 2;
            this.uLabel.Text = "User";
            // 
            // AskFOR
            // 
            this.AskFOR.BackColor = System.Drawing.Color.Gray;
            this.AskFOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AskFOR.FlatAppearance.BorderSize = 0;
            this.AskFOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AskFOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskFOR.ForeColor = System.Drawing.Color.White;
            this.AskFOR.Image = ((System.Drawing.Image)(resources.GetObject("AskFOR.Image")));
            this.AskFOR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AskFOR.Location = new System.Drawing.Point(4, 258);
            this.AskFOR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AskFOR.Name = "AskFOR";
            this.AskFOR.Size = new System.Drawing.Size(273, 52);
            this.AskFOR.TabIndex = 0;
            this.AskFOR.Text = "ASK FOR HELP";
            this.AskFOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AskFOR.UseVisualStyleBackColor = false;
            this.AskFOR.Click += new System.EventHandler(this.ask);
            // 
            // Acknow
            // 
            this.Acknow.BackColor = System.Drawing.Color.Gray;
            this.Acknow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Acknow.FlatAppearance.BorderSize = 0;
            this.Acknow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acknow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acknow.ForeColor = System.Drawing.Color.White;
            this.Acknow.Image = ((System.Drawing.Image)(resources.GetObject("Acknow.Image")));
            this.Acknow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acknow.Location = new System.Drawing.Point(4, 320);
            this.Acknow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Acknow.Name = "Acknow";
            this.Acknow.Size = new System.Drawing.Size(273, 62);
            this.Acknow.TabIndex = 0;
            this.Acknow.Text = "ACKNOWLEDGMENT";
            this.Acknow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Acknow.UseVisualStyleBackColor = false;
            this.Acknow.Click += new System.EventHandler(this.Acknow_click);
            // 
            // Feed
            // 
            this.Feed.BackColor = System.Drawing.Color.Gray;
            this.Feed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Feed.FlatAppearance.BorderSize = 0;
            this.Feed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feed.ForeColor = System.Drawing.Color.White;
            this.Feed.Image = ((System.Drawing.Image)(resources.GetObject("Feed.Image")));
            this.Feed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Feed.Location = new System.Drawing.Point(4, 392);
            this.Feed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(273, 62);
            this.Feed.TabIndex = 0;
            this.Feed.Text = "SEND FEEDBACK";
            this.Feed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Feed.UseVisualStyleBackColor = false;
            this.Feed.Click += new System.EventHandler(this.send_click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.ContextMenuStrip = this.LogRight;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 49);
            this.panel2.TabIndex = 4;
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
            this.button8.Location = new System.Drawing.Point(807, -2);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 52);
            this.button8.TabIndex = 7;
            this.button8.Text = "__";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.minimize);
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
            this.button3.Location = new System.Drawing.Point(886, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.exit);
            // 
            // mainpannel
            // 
            this.mainpannel.ContextMenuStrip = this.LogRight;
            this.mainpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpannel.Location = new System.Drawing.Point(278, 49);
            this.mainpannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainpannel.Name = "mainpannel";
            this.mainpannel.Size = new System.Drawing.Size(950, 745);
            this.mainpannel.TabIndex = 5;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 794);
            this.Controls.Add(this.mainpannel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AskFOR;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label uLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel mainpannel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Acknow;
        private System.Windows.Forms.ContextMenuStrip LogRight;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}