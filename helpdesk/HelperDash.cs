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
    public partial class HelperDash : Form
    {
        public HelperDash()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        private void Expert_view(object sender, EventArgs e)
        {
            ExpertViewFull s = new ExpertViewFull();
            s.Show();
        }

        private void done(object sender, EventArgs e)
        {
            MessageBox.Show("Success!");
        }

        private void HelperDash_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "SELECT TOP 1 * FROM Expert_task ORDER BY Sent_Date DESC";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                expert_name.Text = srd.GetValue(0).ToString();
                category.Text = srd.GetValue(1).ToString();
                problem_Title.Text = srd.GetValue(2).ToString();
                Priority.Text = srd.GetValue(3).ToString();
                Requested_date.Text = srd.GetValue(7).ToString();
                description.Text = srd.GetValue(6).ToString();
            } con.Close();
            con = ob.createconnection();
            SqlCommand com1 = new SqlCommand("SELECT TOP 1 * FROM Expert_FeedBack ORDER BY Sent_Date DESC", con);
            SqlDataReader srd1 = com1.ExecuteReader();
            while (srd1.Read())
            {
                expertName.Text = srd1.GetValue(0).ToString();
                EComment.Text = srd1.GetValue(1).ToString();
                Erating.Text = srd1.GetValue(2).ToString();
                SentDate.Text = srd1.GetValue(3).ToString();
                senderName.Text = srd1.GetValue(4).ToString();

            } con.Close();
        }
    }
}
