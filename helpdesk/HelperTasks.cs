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
    public partial class HelperTasks : Form
    {
        public HelperTasks()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        string d;
        private void HelperTasks_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "Select * from Expert_task ";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                expert_name.Items.Add(srd.GetValue(0).ToString());
                d = srd.GetValue(9).ToString();
            }
            con.Close();  
        }

        private void requestData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.taskData.Rows[e.RowIndex];
                Pro_title.Text = row.Cells["Problem_title"].Value.ToString();
                pro_priority.Text = row.Cells["Problem_priority"].Value.ToString();
                pro_Campus.Text = row.Cells["Campus"].Value.ToString();
                Pro_building.Text = row.Cells["Building_No"].Value.ToString();
                Pro_Room.Text = row.Cells["Room_No"].Value.ToString();
                Pro_disc.Text = row.Cells["problem_Desc"].Value.ToString();
                SentDate.Text = row.Cells["Sent_Date"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void expert_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            pop();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "UPDATE [dbo].[Expert_task] SET [ExpertAcknowled_Status] ='YES' WHERE Ticket_Number='"+d+"'";
                con = ob.createconnection();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                con.Close();
                
                pop();
                foreach (var g in this.Controls)
                {
                    if (g is TextBox)
                    {

                        ((TextBox)g).Text = string.Empty;
                    }
                }
                
            }

        }
        public void pop() {

            con = ob.createconnection();
            string querry = "select * from Expert_task where Assigned_Expert='" + expert_name.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            taskData.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
