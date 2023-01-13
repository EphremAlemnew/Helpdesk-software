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
    public partial class FeedofExperts : Form
    {
        public FeedofExperts()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
       
        private void FeedofExperts_Load(object sender, EventArgs e)
        {
            pop();
        }
        public void pop()
        {

            con = ob.createconnection();
            string query = "SELECT * FROM Expert_FeedBack ORDER BY Sent_Date DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Data.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.Data.Rows[e.RowIndex];
                fullname.Text = row.Cells["Sender_Name"].Value.ToString();
                comment.Text = row.Cells["Comments"].Value.ToString();
                 SentDate.Text = row.Cells["Sent_Date"].Value.ToString();
                expertName.Text = row.Cells["Expert_fullname"].Value.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
