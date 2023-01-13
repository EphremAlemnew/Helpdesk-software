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
    public partial class Assigned_task : Form
    {
        public Assigned_task()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        private void Assigned_task_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "SELECT * FROM Expert_task ORDER BY Sent_Date DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            assignedData.DataSource = ds.Tables[0];
            con.Close();
        }

        private void assignedData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.assignedData.Rows[e.RowIndex];
            Expert_name.Text = row.Cells["Assigned_Expert"].Value.ToString();
            problem_cat.Text = row.Cells["Problem_Category"].Value.ToString();
            Pro_title.Text = row.Cells["Problem_title"].Value.ToString();
            pro_priority.Text = row.Cells["Problem_priority"].Value.ToString();
            pro_Campus.Text = row.Cells["Campus"].Value.ToString();
            Pro_building.Text = row.Cells["Building_No"].Value.ToString();
            Pro_Room.Text = row.Cells["Room_No"].Value.ToString();
            Pro_disc.Text = row.Cells["problem_Desc"].Value.ToString();
            SentDate.Text = row.Cells["Sent_Date"].Value.ToString();
            userAck.Text = row.Cells["UserAcknowledgment_Status"].Value.ToString();
            ExpertAck.Text = row.Cells["ExpertAcknowled_Status"].Value.ToString();
            
        }
    }
}
