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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        int a;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
      

       
        private void Admin_easy_Accept(object sender, EventArgs e)
        {
            MessageBox.Show("Problem is Accepted Successfully!");
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "SELECT TOP 1 * FROM UserApply ORDER BY Sent_Date DESC";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                category.Text = srd.GetValue(0).ToString();
                problem_Title.Text = srd.GetValue(1).ToString();
                Priority.Text = srd.GetValue(2).ToString();
                Requested_date.Text = srd.GetValue(7).ToString();
            } con.Close();
            con = ob.createconnection();
            SqlCommand com1 = new SqlCommand("SELECT TOP 1 * FROM Expert_FeedBack ORDER BY Sent_Date DESC", con);
            SqlDataReader srd1 = com1.ExecuteReader();
            while (srd1.Read())
            {
                expertName.Text = srd1.GetValue(0).ToString();
                EComment.Text = srd1.GetValue(1).ToString();
                SentDate.Text = srd1.GetValue(3).ToString();
                senderName.Text = srd1.GetValue(4).ToString();

            } con.Close();
            con = ob.createconnection();
            SqlCommand com2 = new SqlCommand("SELECT TOP 1 * FROM Other_FeedBack ORDER BY Sent_Date DESC", con);
            SqlDataReader srd2 = com2.ExecuteReader();
            while (srd2.Read())
            {

                Ocomment.Text = srd2.GetValue(0).ToString();
                SentDate2.Text = srd2.GetValue(2).ToString();
                SenderName2.Text = srd2.GetValue(3).ToString();

            }
            con.Close();
            

    

        }
    }
}
