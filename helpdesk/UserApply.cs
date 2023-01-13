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
    public partial class UserApply : Form
    {
        SqlConnection con;
        int num;
        database ob = new database();
        public UserApply()
        {
            InitializeComponent();
           
            
        }

        private void exit(object sender, EventArgs e)
        {
            this.Hide();
        }
        DateTime a = DateTime.Now;
        
        private void submit(object sender, EventArgs e)
        {
            string c = "No";
            Random rnd = new Random();
            num = rnd.Next(1000,9999);
            
            ticketNo.Text = num.ToString();
            if (category.Text == "Select" || Pro_title.Text == "" || pro_priority.Text == "Select" || pro_Campus.Text == "Select" || Pro_building.Text == "" || Pro_disc.Text == "" || Pro_Room.Text == "")
            {
                MessageBox.Show("please fill all the information!");
            }//popu();
            else {

                con = ob.createconnection();
                string query = "insert into UserApply values('" + category.Text + "','" + Pro_title.Text + "','" + pro_priority.Text + "','" + pro_Campus.Text + "','" + Pro_building.Text + "', '" + Pro_Room.Text + "','" + Pro_disc.Text.Trim() + "','" + a.ToString() + "','"+ticketNo.Text+"','"+c+"')";
                SqlCommand com = new SqlCommand(query, con);

                com.ExecuteNonQuery();
                MessageBox.Show("Problem Is Sent Successfuly! You will have Response soon");
                con.Close();
                Clear();

                
            }
           
        }

        private void clear(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear() {
            foreach (var g in this.Controls)
            {
                if (g is TextBox)
                {
                    
                    ((TextBox)g).Text = string.Empty;
                }
            }
        }

        private void Pro_disc_KeyPress(object sender, KeyPressEventArgs e)
        {
           no_more.Visible=false;
            if(Pro_disc.Text == "")
            {
                no_more.Visible = true;
            
            }
            
        }

        private void UserApply_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "Select * from Categories ";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                category.Items.Add(srd.GetValue(1).ToString());
            }

            con.Close();
            Clear();
            Random rnd = new Random();
            num = rnd.Next(1000, 9999);

            ticketNo.Text = num.ToString();
        }
    }
}
