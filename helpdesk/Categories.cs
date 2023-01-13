using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Categories : Form
    {
        SqlConnection con;
        string id;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        public Categories()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            con = ob.createconnection();
             string query1 = "Select * from Categories where Category_ID='" + Cat_Search.Text + "'";
             SqlCommand com1 = new SqlCommand(query1, con);
             SqlDataReader srd = com1.ExecuteReader();
            while (srd.Read())
            {
                id = srd.GetValue(0).ToString();
            }
            con.Close();
            if (Category_ID.Text == id)
            { MessageBox.Show("Sorry the Category ID is already registerd"); }

            else if (Category_ID.Text == "" || Category_Name.Text == "" || Category_Desc.Text == "") { MessageBox.Show("Please fill all informations"); }
            else
            {
                try
                {
                    
                    string query = "insert into Categories values('" + Category_ID.Text + "','" + Category_Name.Text + "','" + Category_Desc.Text + "')";
                    ob1.commandonly(query);
                    MessageBox.Show("Category is add Successfuly!");
                    pop();
                }catch(Exception ex){MessageBox.Show("Sorry the Category ID is already registerd");

                
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            
            string query = "update Categories set Category_Name='"+Category_Name.Text+"' ,Category_Description='"+Category_Desc.Text+"' where Category_ID='" + Category_ID.Text + "'";
            ob1.commandonly(query);
            MessageBox.Show("Category is Updated Successfuly!");
            pop();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (Category_ID.Text == "")
            {
                MessageBox.Show("No data is Searched");
            }
            else
            {
                if (MessageBox.Show("Are You sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    
                    string query = "Delete Categories Where Category_ID='" + Category_ID.Text + "'";
                    ob1.commandonly(query);
                    MessageBox.Show("Category is Deleted Successfuly!");
                    pop();
                    Clear();
                }
            }
        }
        public void Clear()
        {
            
            foreach (var g in this.Controls)
            {
                if (g is TextBox)
                {
                    ((TextBox)g).Text = string.Empty;
                }
            }
        }

        private void Search(object sender, EventArgs e)
        {
            con=ob.createconnection();
            if(Cat_Search.Text==""){
                MessageBox.Show("No ID is Inserted");
            }
            else{
             string query = "Select * from Categories where Category_ID='" + Cat_Search.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                Category_ID.Text= srd.GetValue(0).ToString();
               Category_Name.Text = srd.GetValue(1).ToString();
                Category_Desc.Text= srd.GetValue(2).ToString();
            }
            con.Close();
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            catData.Visible = false;
            pop();

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            catData.Visible = true;
        }

        private void catData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.catData.Rows[e.RowIndex];
                Category_ID.Text = row.Cells["Category_ID"].Value.ToString();
                Category_Name.Text = row.Cells["Category_Name"].Value.ToString();
                Category_Desc.Text = row.Cells["Category_Description"].Value.ToString();
               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void pop()
        {

            con = ob.createconnection();
            string query = "SELECT * FROM Categories ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            catData.DataSource = ds.Tables[0];
            con.Close();
        }
      
    }
}
