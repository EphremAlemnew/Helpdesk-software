namespace WindowsFormsApplication1
{
    partial class All_Experts
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
            this.allexpertdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allexpertdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL EXPERTS INFORMATION";
            // 
            // allexpertdata
            // 
            this.allexpertdata.AllowUserToAddRows = false;
            this.allexpertdata.AllowUserToDeleteRows = false;
            this.allexpertdata.BackgroundColor = System.Drawing.Color.White;
            this.allexpertdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allexpertdata.Location = new System.Drawing.Point(4, 64);
            this.allexpertdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allexpertdata.Name = "allexpertdata";
            this.allexpertdata.ReadOnly = true;
            this.allexpertdata.Size = new System.Drawing.Size(886, 631);
            this.allexpertdata.TabIndex = 2;
            // 
            // All_Experts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 794);
            this.Controls.Add(this.allexpertdata);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "All_Experts";
            this.Text = "All_Experts";
            this.Load += new System.EventHandler(this.All_Experts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allexpertdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView allexpertdata;
    }
}