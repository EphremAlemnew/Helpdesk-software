namespace WindowsFormsApplication1
{
    partial class Admin_feedBack
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.feedOtherBt = new System.Windows.Forms.Button();
            this.feedExpertBt = new System.Windows.Forms.Button();
            this.Admin_feedbackPannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Admin_feedbackPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.feedOtherBt);
            this.panel1.Controls.Add(this.feedExpertBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 54);
            this.panel1.TabIndex = 0;
            // 
            // feedOtherBt
            // 
            this.feedOtherBt.FlatAppearance.BorderSize = 0;
            this.feedOtherBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedOtherBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedOtherBt.ForeColor = System.Drawing.Color.White;
            this.feedOtherBt.Location = new System.Drawing.Point(494, 0);
            this.feedOtherBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedOtherBt.Name = "feedOtherBt";
            this.feedOtherBt.Size = new System.Drawing.Size(513, 57);
            this.feedOtherBt.TabIndex = 2;
            this.feedOtherBt.Text = "Other type of feedback";
            this.feedOtherBt.UseVisualStyleBackColor = true;
            this.feedOtherBt.Click += new System.EventHandler(this.admin_otherFeedback);
            // 
            // feedExpertBt
            // 
            this.feedExpertBt.FlatAppearance.BorderSize = 0;
            this.feedExpertBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedExpertBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedExpertBt.ForeColor = System.Drawing.Color.White;
            this.feedExpertBt.Location = new System.Drawing.Point(1, -2);
            this.feedExpertBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedExpertBt.Name = "feedExpertBt";
            this.feedExpertBt.Size = new System.Drawing.Size(498, 57);
            this.feedExpertBt.TabIndex = 1;
            this.feedExpertBt.Text = "Feedback on Experts";
            this.feedExpertBt.UseVisualStyleBackColor = true;
            this.feedExpertBt.Click += new System.EventHandler(this.admin_onExpert);
            // 
            // Admin_feedbackPannel
            // 
            this.Admin_feedbackPannel.Controls.Add(this.label1);
            this.Admin_feedbackPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin_feedbackPannel.Location = new System.Drawing.Point(0, 54);
            this.Admin_feedbackPannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Admin_feedbackPannel.Name = "Admin_feedbackPannel";
            this.Admin_feedbackPannel.Size = new System.Drawing.Size(1011, 740);
            this.Admin_feedbackPannel.TabIndex = 1;
            this.Admin_feedbackPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.Admin_feedbackPannel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Select the type of feedback";
            // 
            // Admin_feedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 794);
            this.Controls.Add(this.Admin_feedbackPannel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_feedBack";
            this.Text = "Admin_feedBack";
            this.panel1.ResumeLayout(false);
            this.Admin_feedbackPannel.ResumeLayout(false);
            this.Admin_feedbackPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button feedExpertBt;
        private System.Windows.Forms.Button feedOtherBt;
        private System.Windows.Forms.Panel Admin_feedbackPannel;
        private System.Windows.Forms.Label label1;



    }
}