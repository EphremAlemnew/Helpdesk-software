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
    public partial class All_Experts : Form
    {
        public All_Experts()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        private void All_Experts_Load(object sender, EventArgs e)
        {
            con = ob.createconnection();
            string query = "SELECT [Expert_ID]  ,[First_name]  ,[Last_name]  ,[Gender]  ,[DoB]   ,[Email_Address]  ,[Phone_No]  ,[Experts_In]  ,[Educational_level]  ,[Campus] ,[Building_No] ,[Room_No],[image] FROM [dbo].[Expert]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            allexpertdata.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
