namespace WindowsFormsApplication1
{
    partial class sendFeedback
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.otherFeed = new System.Windows.Forms.Button();
            this.feedOnExpert = new System.Windows.Forms.Button();
            this.send_feedback_pannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.send_feedback_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.otherFeed);
            this.panel2.Controls.Add(this.feedOnExpert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 37);
            this.panel2.TabIndex = 1;
            // 
            // otherFeed
            // 
            this.otherFeed.FlatAppearance.BorderSize = 0;
            this.otherFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherFeed.ForeColor = System.Drawing.Color.White;
            this.otherFeed.Location = new System.Drawing.Point(312, 0);
            this.otherFeed.Name = "otherFeed";
            this.otherFeed.Size = new System.Drawing.Size(322, 37);
            this.otherFeed.TabIndex = 0;
            this.otherFeed.Text = "Other type of feedback";
            this.otherFeed.UseVisualStyleBackColor = true;
            this.otherFeed.Click += new System.EventHandler(this.Other_feedback);
            // 
            // feedOnExpert
            // 
            this.feedOnExpert.FlatAppearance.BorderSize = 0;
            this.feedOnExpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedOnExpert.ForeColor = System.Drawing.Color.White;
            this.feedOnExpert.Location = new System.Drawing.Point(0, 0);
            this.feedOnExpert.Name = "feedOnExpert";
            this.feedOnExpert.Size = new System.Drawing.Size(313, 37);
            this.feedOnExpert.TabIndex = 0;
            this.feedOnExpert.Text = "Feedback on Experts";
            this.feedOnExpert.UseVisualStyleBackColor = true;
            this.feedOnExpert.Click += new System.EventHandler(this.Feed_on_expert);
            // 
            // send_feedback_pannel
            // 
            this.send_feedback_pannel.Controls.Add(this.label1);
            this.send_feedback_pannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_feedback_pannel.Location = new System.Drawing.Point(0, 37);
            this.send_feedback_pannel.Name = "send_feedback_pannel";
            this.send_feedback_pannel.Size = new System.Drawing.Size(634, 447);
            this.send_feedback_pannel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Select the type of feedback you want to send";
            // 
            // sendFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 484);
            this.Controls.Add(this.send_feedback_pannel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sendFeedback";
            this.Text = "sendFeedback";
            this.panel2.ResumeLayout(false);
            this.send_feedback_pannel.ResumeLayout(false);
            this.send_feedback_pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button otherFeed;
        private System.Windows.Forms.Button feedOnExpert;
        private System.Windows.Forms.Panel send_feedback_pannel;
        private System.Windows.Forms.Label label1;

    }
}