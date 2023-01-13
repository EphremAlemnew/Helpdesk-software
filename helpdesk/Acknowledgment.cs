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
    public partial class Acknowledgment : Form
    {
        public Acknowledgment()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        private void Ack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure Expert is Done his work?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "UPDATE [dbo].[Expert_task]SET [UserAcknowledgment_Status] = 'YES' WHERE Ticket_Number='" + Tticket.Text + "'";
                ob1.commandonly(query);
                
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "Select * from Expert_task where Ticket_Number='" + Tticket .Text+ "' ";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                problem_cat.Text = srd.GetValue(0).ToString();
                Pro_title.Text = srd.GetValue(1).ToString();
                pro_priority.Text = srd.GetValue(2).ToString();
                pro_Campus.Text = srd.GetValue(3).ToString();
                Pro_building.Text = srd.GetValue(4).ToString();
                Pro_Room.Text = srd.GetValue(5).ToString();
                Pro_disc.Text = srd.GetValue(6).ToString();
                SentDate.Text = srd.GetValue(7).ToString();
            }
            con.Close(); 
        }
    }
}
