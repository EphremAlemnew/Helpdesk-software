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
    public partial class admin_otherfeedback : Form
    {
        public admin_otherfeedback()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();

        private void admin_otherfeedback_Load(object sender, EventArgs e)
        {
            pop();
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.Data.Rows[e.RowIndex];
                fullname.Text = row.Cells["Sender_Name"].Value.ToString();
                comment.Text = row.Cells["comments"].Value.ToString();
                 SentDate.Text = row.Cells["Sent_Date"].Value.ToString();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
         

        private void delete_Click(object sender, EventArgs e)
        {
        if(MessageBox.Show("Are You sure","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
            string query = "Delete Other_FeedBack where Sent_Date='" + SentDate.Text + "'";
            ob1.commandonly(query);
                pop();
        }
       
        fullname.Text = "";
        SentDate.Text = "";
        comment.Text = "";
        

        
            }
        public void pop()
        {

            con = ob.createconnection();
            string query = "SELECT [comments],[Sent_Date] ,[Sender_Name] FROM [dbo].[Other_FeedBack]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Data.DataSource = ds.Tables[0];
            con.Close();
        }
         
    }
}
