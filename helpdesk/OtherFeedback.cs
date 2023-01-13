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
    public partial class OtherFeedback : Form
    {
        public OtherFeedback()
        {
            InitializeComponent();
        }
        SqlConnection con;
        database ob = new database();
        Businesslayer ob1 = new Businesslayer();
            DateTime a = DateTime.Now;
        private void send(object sender, EventArgs e)
        {
            string b = "";
            if (comment.Text == "" ||  fullname.Text == "") { MessageBox.Show("Please fill all information!"); }
            else
            {
                try
                {
                    string query="insert into Other_FeedBack values('" + comment.Text + "','" + b + "','" + a.ToString() + "','" + fullname.Text + "')";

                    ob1.commandonly(query);
                    MessageBox.Show("Thank You for your Feedbacks!");
                    comment.Text = "";
                    fullname.Text = "";
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
