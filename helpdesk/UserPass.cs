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
    public partial class UserPass : Form
    {
        SqlConnection con;
        public UserPass()
        {
            InitializeComponent();
            changepannel.Visible=false;
            Userpas.Visible = false;
            pop();
        }
        database ob = new database();
        private void changebt_click(object sender, EventArgs e)
        {
            if (ConfirmPass.Text == "" || NewPass.Text == "" || NewUser.Text == "") { MessageBox.Show("Please fill the Username and Password!"); }
           else if (ConfirmPass.Text == NewPass.Text)
            {
                con = ob.createconnection();
                SqlCommand com = new SqlCommand("Update UserPassword set UserName='" + NewUser.Text + "',Password='" + NewPass.Text + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Password is changed successfuly");
                con.Close();
                pop();
                NewPass.Text = "";
                ConfirmPass.Text = "";
                NewUser.Text = "";
            }
            else { MessageBox.Show("Please Confirm password correctly"); }
        }

        private void tochange_Click(object sender, EventArgs e)
        {
            changepannel.Visible = true;
        }
        void pop()
        {
            con = ob.createconnection();
            SqlCommand com = new SqlCommand("Select * from UserPassword where ID=1", con);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                currentUser.Text = sdr.GetValue(1).ToString();
                currentPass.Text = sdr.GetValue(2).ToString();
            }
            con.Close();
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            if (Auser.Text == "Admin" && Apass.Text == "Admin123")
            {
                Userpas.Visible = true;
                logPannel.Visible = false;

            }
            else { MessageBox.Show("Incorrect password");

            Apass.Text = "";
            Auser.Text = "";
            }
            
        }
        

       

        

    }
}
