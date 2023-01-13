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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        private void Requests_Load(object sender, EventArgs e)
        {
            pop();
            selectPannel.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                string query = "Delete UserApply where Ticket_Number='" + ticket_NO.Text + "'";
                ob1.commandonly(query);
                pop();
            }
        }

        private void requestData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.requestData.Rows[e.RowIndex];
                problem_cat.Text = row.Cells["Problem_Category"].Value.ToString();
                Pro_title.Text = row.Cells["Problem_title"].Value.ToString();
                pro_priority.Text = row.Cells["Problem_priority"].Value.ToString();
                pro_Campus.Text = row.Cells["Campus"].Value.ToString();
                Pro_building.Text = row.Cells["Building_No"].Value.ToString();
                Pro_Room.Text = row.Cells["Room_No"].Value.ToString();
                Pro_disc.Text =row.Cells["problem_Desc"].Value.ToString();
                SentDate.Text = row.Cells["Sent_Date"].Value.ToString();
                ticket_NO.Text = row.Cells["Ticket_Number"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void pop() {

            con = ob.createconnection();
            string query = "SELECT * FROM UserApply ORDER BY Sent_Date DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            requestData.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Send_ToExpert(object sender, EventArgs e)
        {
            selectPannel.Visible = true;
            con = ob.createconnection();
            string query = "SELECT * FROM Expert where Experts_in='"+problem_cat.Text+"'";
            
         SqlCommand com = new SqlCommand(query, con);
            SqlDataReader srd = com.ExecuteReader();
            while (srd.Read())
            {
                string a = srd.GetValue(1).ToString();
                string b = srd.GetValue(2).ToString();
                string c = a + " " + b;
                selectexpert.Items.Add(c);
                
            }
            con.Close();
        }

        private void send_Click(object sender, EventArgs e)
        {
            DateTime a = DateTime.Now;
            if (selectexpert.Text == "Select")
            {
                MessageBox.Show("Please choose expert name you want to assign at the bottom!");
            }
            else {
                con = ob.createconnection();
                string query = "insert into Expert_task values('" + selectexpert.Text+ "','" + problem_cat.Text + "','"+ Pro_title.Text+"','"+ pro_priority.Text+"','"+ pro_Campus.Text+"','"+ Pro_building.Text+"','"+ Pro_disc.Text+"','"+ a.ToString()+"','"+ Pro_Room.Text+"','"+ticket_NO.Text+"','NO','NO')";
                SqlCommand com = new SqlCommand(query, con);
                
                com.ExecuteNonQuery();
                MessageBox.Show("Task is assigned successfully!");
                con.Close();

                con = ob.createconnection();
                SqlCommand cmd = new SqlCommand("Delete UserApply where Ticket_Number='" + ticket_NO.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pop();
                con.Close();
                foreach (var g in this.Controls)
                {
                    if (g is TextBox)
                    {

                        ((TextBox)g).Text = string.Empty;
                    }
                }

               
            }
        }
    }
}
