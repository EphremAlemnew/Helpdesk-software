namespace WindowsFormsApplication1
{
    partial class Categories
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
            this.Category_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Category_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_Desc = new System.Windows.Forms.TextBox();
            this.Cat_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.catData = new System.Windows.Forms.DataGridView();
            this.showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catData)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_ID
            // 
            this.Category_ID.Location = new System.Drawing.Point(141, 120);
            this.Category_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Category_ID.Name = "Category_ID";
            this.Category_ID.Size = new System.Drawing.Size(306, 26);
            this.Category_ID.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Category ID";
            // 
            // Category_Name
            // 
            this.Category_Name.Location = new System.Drawing.Point(141, 160);
            this.Category_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(306, 26);
            this.Category_Name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Description";
            // 
            // Category_Desc
            // 
            this.Category_Desc.Location = new System.Drawing.Point(171, 200);
            this.Category_Desc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Category_Desc.Multiline = true;
            this.Category_Desc.Name = "Category_Desc";
            this.Category_Desc.Size = new System.Drawing.Size(276, 326);
            this.Category_Desc.TabIndex = 7;
            // 
            // Cat_Search
            // 
            this.Cat_Search.Location = new System.Drawing.Point(308, 80);
            this.Cat_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cat_Search.Name = "Cat_Search";
            this.Cat_Search.Size = new System.Drawing.Size(240, 26);
            this.Cat_Search.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "MANAGE GATEGORIES";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(188, 551);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(321, 551);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gray;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(54, 551);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(124, 35);
            this.add.TabIndex = 11;
            this.add.Text = "ADD NEW";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(544, 77);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 39;
            this.button5.Text = "SEARCH";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Search);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Search by ID:";
            // 
            // catData
            // 
            this.catData.BackgroundColor = System.Drawing.Color.White;
            this.catData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catData.Location = new System.Drawing.Point(468, 123);
            this.catData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.catData.Name = "catData";
            this.catData.Size = new System.Drawing.Size(391, 405);
            this.catData.TabIndex = 41;
            this.catData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catData_CellContentClick);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.Gray;
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll.ForeColor = System.Drawing.Color.White;
            this.showAll.Location = new System.Drawing.Point(452, 551);
            this.showAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(124, 35);
            this.showAll.TabIndex = 10;
            this.showAll.Text = "SHOW ALL";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 794);
            this.Controls.Add(this.catData);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cat_Search);
            this.Controls.Add(this.Category_ID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Category_Desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Category_Name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Category_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Category_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Category_Desc;
        private System.Windows.Forms.TextBox Cat_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView catData;
        private System.Windows.Forms.Button showAll;
    }
}