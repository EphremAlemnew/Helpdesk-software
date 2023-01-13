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
    public partial class heLogIn : Form
    {
        //global variables
        int count, attempt;
        String userUser;
        String userPass;
        string pass;
        string user;
        SqlConnection con;
        //conection class calling
        database ob = new database();
        public heLogIn()
        {
            InitializeComponent();
            invisible.Visible = false;
            username.Focus();
        }
        //timer function
        void dis(){

            if (attempt == 3) {
                
                count = 20;
                attempt = 0;
                username.Enabled = false;
                password.Enabled = false;
                log_IN.Enabled = false;
                timer1.Enabled = true;
                label5.Text = "You Have reached three attempts, please try later after";
   
            }
        
        
        
        }
        

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        //log in click
        private void LogIn(object sender, EventArgs e)
        {
            try
            {
                //Data retrival from database
                con=ob.createconnection();
                string query = "Select * from SignUp where User_Name='" + username.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader srd = com.ExecuteReader();
                while (srd.Read())
                {
                user = srd.GetValue(2).ToString();
                pass = srd.GetValue(3).ToString();}
                con.Close();
                con = ob.createconnection();
                SqlCommand com1 = new SqlCommand("Select * from UserPassword where ID=1", con);
                SqlDataReader sdr = com1.ExecuteReader();
                while (sdr.Read())
                {
                    userUser = sdr.GetValue(1).ToString();
                    userPass = sdr.GetValue(2).ToString();
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //validation
            if(username.Text==user && password.Text==pass){


                success();
                HelperHome s = new HelperHome();
                this.Hide();
                s.Show();
            }
            else if (username.Text == userUser && password.Text == userPass)
            {
                success();
                User s = new User();
                this.Hide();
                s.Show();
            }
            else if (username.Text == "Admin" && password.Text == "Admin123")
            {
                success();
                admin s = new admin();
                this.Hide();
                s.Show();
            }
            else
            {
                incorrect();
            }
           
            

        }
        //incorrect function
        private void incorrect()
        {
            DialogResult l = MessageBox.Show("Either password or username is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (l == DialogResult.OK)
            {
                username.Clear();
                password.Clear();
                username.Focus();
                attempt = attempt + 1;
                dis();
            }
        }
        //success function
        private void success() {
            MessageBox.Show("You have successfuly logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void creat(object sender, EventArgs e)
        {
            Signup s = new Signup();
            this.Hide();
            s.Show();
        }
        //timer 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 0) {

                username.Enabled = true;
                password.Enabled = true;
                log_IN.Enabled = true;
                timer1.Enabled = false;
                label5.Text = "";
                label6.Text = "";
            }
            else
            {
                label6.Text = "" + count + " seconds!";
                count = count - 1;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void forgot(object sender, EventArgs e)
        {
            forgotPassword s = new forgotPassword();
            this.Hide();
            s.Show();
        }

        private void visible_click(object sender, EventArgs e)
        {
            if (invisible.Visible == false) {
                invisible.Visible = true;
            }
            visible.Visible = false;
            password.UseSystemPasswordChar = false;
        }

        private void invisble_click(object sender, EventArgs e)
        {
            if (visible.Visible == false) {
                visible.Visible = true;
            }
            invisible.Visible = false;
            password.UseSystemPasswordChar = true;
        }

        private void heLogIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
