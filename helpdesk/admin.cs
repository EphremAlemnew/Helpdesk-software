using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            color();
            dash.ForeColor = Color.Gray;
            dash.BackColor = Color.WhiteSmoke;
            loadform(new AdminDash());
        }

        public void loadform(object Form)
        {
            if (this.mainpannel.Controls.Count > 0)
                this.mainpannel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpannel.Controls.Add(f);
            this.mainpannel.Tag = f;
            f.Show();
        }
        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void back(object sender, EventArgs e)
        {
            heLogIn b = new heLogIn();
            this.Hide();
            b.Show();
        }

        private void helper(object sender, EventArgs e)
        {
            color();
            expert.ForeColor = Color.Gray;
            expert.BackColor = Color.WhiteSmoke;
            loadform(new Helpers());
        }

        private void Admindash(object sender, EventArgs e)
        {
            color();
            dash.ForeColor = Color.Gray;
            dash.BackColor = Color.WhiteSmoke;
            loadform(new AdminDash());
        }

        private void request(object sender, EventArgs e)
        {
            color();
            Rqe_st.ForeColor = Color.Gray;
            Rqe_st.BackColor = Color.WhiteSmoke;
            loadform(new Requests());
        }

        private void all_experts(object sender, EventArgs e)
        {
            color();
            allexpert.ForeColor = Color.Gray;
            allexpert.BackColor = Color.WhiteSmoke;
            loadform(new All_Experts());
        }

        private void Admin_dash(object sender, EventArgs e)
        {
            color();
            dash.ForeColor = Color.Gray;
            dash.BackColor = Color.WhiteSmoke;
            loadform(new AdminDash());
        }

        private void admin_Load(object sender, EventArgs e)
        {
            loadform(new AdminDash());
        }
        public void color()
        {
            allexpert.BackColor = Color.Gray;
            allexpert.ForeColor = Color.White;
            feedback.BackColor = Color.Gray;
            feedback.ForeColor = Color.White;
            dash.BackColor = Color.Gray;
            dash.ForeColor = Color.White;
            Rqe_st.BackColor = Color.Gray;
            Rqe_st.ForeColor = Color.White;
            expert.BackColor = Color.Gray;
            expert.ForeColor = Color.White;
            Problem_Category.BackColor = Color.Gray;
            Problem_Category.ForeColor = Color.White;
            assign.BackColor = Color.Gray;
            assign.ForeColor = Color.WhiteSmoke;
            usPass.BackColor = Color.Gray;
            usPass.ForeColor = Color.WhiteSmoke;
    }

        private void admin_Feedback(object sender, EventArgs e)
        {
            color();
            feedback.ForeColor = Color.Gray;
            feedback.BackColor = Color.WhiteSmoke;
            loadform(new Admin_feedBack());
        }

        private void minimize_button(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void admin_Category(object sender, EventArgs e)
        {
            color();
            Problem_Category.ForeColor = Color.Gray;
            Problem_Category.BackColor = Color.WhiteSmoke;
            loadform(new Categories());
        }

        private void Assigned_Tasks(object sender, EventArgs e)
        {
            color();
            assign.ForeColor = Color.Gray;
            assign.BackColor = Color.WhiteSmoke;
            loadform(new Assigned_task());

        }

        private void UsPass_click(object sender, EventArgs e)
        {
            color();
            usPass.ForeColor = Color.Gray;
            usPass.BackColor = Color.WhiteSmoke;
            loadform(new UserPass());

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Alabel.Text = "LOG OUT";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Alabel.Text = "Admin";
        }
    }
}
