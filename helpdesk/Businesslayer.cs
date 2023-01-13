using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class Businesslayer
    {
        database ob = new database();
        SqlConnection con;
      
        public void commandonly(string query) {
            try
            {
               con= ob.createconnection();
               SqlCommand com = new SqlCommand(query,con);
               com.ExecuteNonQuery();
               com.Dispose();

            }
            catch (Exception ex)
            {
                con.Close();
            }
            finally { con.Close(); }
        
        }
       

    }
    class database {
        
        SqlConnection con = new SqlConnection(@"Data Source=MIKIAS\SQLEXPRESS;Initial Catalog=helpdesk1;Integrated Security=True");
        
        public SqlConnection createconnection() {

            if (con != null)
            {
                con.Open();
               
            }
            else { con.Close(); }
            return con;
        }
    }
}
