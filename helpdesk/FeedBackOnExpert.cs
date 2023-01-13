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
    public partial class FeedBackOnExpert : Form
    {
        public FeedBackOnExpert()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
        DateTime a = DateTime.Now;

        private void button2_Click(object sender, EventArgs e)
        {
            string b = " ";
            if (E_fullname.Text == "" || Comments.Text == "" || fullname.Text=="")
            {
                MessageBox.Show("Dear User Please fill all information!");
            }
            else{
            try
            {
                
                string query = "insert into Expert_FeedBack values('" + E_fullname.Text + "','" + Comments.Text + "','" + b + "','"+ a.ToString()+"','"+fullname.Text+"')";
                ob1.commandonly(query);
                MessageBox.Show("Thank You for your Feedbacks!");
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }}
    }
}
