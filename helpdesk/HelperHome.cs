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
    public partial class HelperHome : Form
    {
        public HelperHome()
        {
            InitializeComponent();
            Expert_Dashboard.BackColor = Color.WhiteSmoke;
            Expert_Dashboard.ForeColor = Color.Gray;
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

        private void helpdash(object sender, EventArgs e)
        {
            color();
            Dashboard.BackColor = Color.WhiteSmoke;
            Dashboard.ForeColor = Color.Gray;
            loadform(new HelperTasks());
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

        private void Expert_dash(object sender, EventArgs e)
        {
            color();
            Expert_Dashboard.BackColor = Color.WhiteSmoke;
            Expert_Dashboard.ForeColor = Color.Gray;
            loadform(new HelperDash());
        }
        
        private void HelperHome_Load_1(object sender, EventArgs e)
        {
            loadform(new HelperDash());
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color();
            feedback.BackColor = Color.WhiteSmoke;
            feedback.ForeColor = Color.Gray;
            loadform(new FeedofExperts());
        }
        public void color() {
            feedback.BackColor = Color.Gray;
            feedback.ForeColor = Color.WhiteSmoke;
            Expert_Dashboard.BackColor = Color.Gray;
            Expert_Dashboard.ForeColor = Color.WhiteSmoke;
            Dashboard.BackColor = Color.Gray;
            Dashboard.ForeColor = Color.WhiteSmoke;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heLogIn b = new heLogIn();
            this.Hide();
            b.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            elabel.Text = "LOG OUT";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            elabel.Text = "Expert";
        }

    }
}
