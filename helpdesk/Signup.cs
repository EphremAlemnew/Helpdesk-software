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
    public partial class Signup : Form
    {
        string auth = "",ID="";

        public Signup()
        {
            InitializeComponent();
            Ninvisible.Visible = false;
            Cinvisible.Visible = false;
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        public void confirm()
        {
            con = ob.createconnection();
            string query = "Select * from Expert where Expert_ID='" + E_ID.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            { 
            auth= srd.GetValue(12).ToString();
            }
            con.Close();
        }
        
        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void back(object sender, EventArgs e)
        {
            heLogIn s = new heLogIn();
            this.Hide();
            s.Show();
        }

        private void Sign_up(object sender, EventArgs e)
        {
            
            
            string Signpass = Signpassword.Text;
            string SignConPass = SignConfirmPass.Text;

                if (Signpass == SignConPass)
                {
                    try
                    {
                        confirm();
                        if (signAuthentication.Text == "" || SignConfirmPass.Text == "" || signFirstname.Text == "" || SignLastname.Text == "" || Signusername.Text == "" || E_ID.Text == "")
                        {
                            MessageBox.Show("Please fill all information");
                        }
                        else if (auth != signAuthentication.Text)
                        {
                            MessageBox.Show("The authentication number is not Correct!");
                        }
                        else
                        {
                            
                            string querry = "insert into SignUp values('" + signFirstname.Text + "','" + SignLastname.Text + "','" + Signusername.Text + "','" + SignConfirmPass.Text + "','" + E_ID.Text + "')";
                            ob1.commandonly(querry);
                            MessageBox.Show("You have successfuly siggned up!");
                            heLogIn s = new heLogIn();
                            this.Hide();
                            s.Show();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                }
                else
                {
                    MessageBox.Show("Password is Not Confirmed correctly");

                }
           
        }

        private void maximize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void signAuthentication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                error.SetError(this.signAuthentication, "Numbers Only");
            }
            else { error.Clear(); }
        }

        private void signFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                error.SetError(this.signFirstname, "Letters Only");
               
            }
            else { error.Clear(); }
        }

        private void signLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
                error.SetError(this.SignLastname, "Letters Only");
            }
            else { error.Clear(); }
        }

       
        private void Nvisible_Click(object sender, EventArgs e)
        {
            if (Ninvisible.Visible == false)
            {
                Ninvisible.Visible = true;
            }
            Nvisible.Visible = false;
            Signpassword.UseSystemPasswordChar = false;
        }

        private void Ninvisible_Click(object sender, EventArgs e)
        {
            if (Nvisible.Visible == false)
            {
                Nvisible.Visible = true;
            }
            Ninvisible.Visible = false;
            Signpassword.UseSystemPasswordChar = true;
        }

        private void Cvisible_Click(object sender, EventArgs e)
        {
            if (Cinvisible.Visible == false)
            {
                Cinvisible.Visible = true;
            }
            Cvisible.Visible = false;
            SignConfirmPass.UseSystemPasswordChar = false;
        }

        private void Cinvisible_Click(object sender, EventArgs e)
        {
            if (Cvisible.Visible == false)
            {
                Cvisible.Visible = true;
            }
            Cinvisible.Visible = false;
            SignConfirmPass.UseSystemPasswordChar = true;
        }

      

        
    }
}
