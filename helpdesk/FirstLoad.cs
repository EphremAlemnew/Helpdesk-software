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
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
            members.Visible = false;
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int start = 0;
      
        private void Prog_time(object sender, EventArgs e)
        {
            start += 1;
            
            Myprogress.Value = start;
            if (Myprogress.Value == 50) {
                title.Visible = false;
                members.Visible = true;
            }
            else if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                heLogIn log = new heLogIn();
                this.Hide();
                log.Show();
            }


        }

        private void load_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

    }
}
