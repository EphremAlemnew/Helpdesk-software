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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            AskFOR.BackColor = Color.WhiteSmoke;
            AskFOR.ForeColor = Color.Gray;
        }

      
        private void exit(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void User_Load(object sender, EventArgs e)
        {
            loadform(new UserApply());
        }
        public void loadform(object Form) {
        if(this.mainpannel.Controls.Count>0)
            this.mainpannel.Controls.RemoveAt(0);
        Form f = Form as Form;
        f.TopLevel = false;
        f.Dock = DockStyle.Fill;
        this.mainpannel.Controls.Add(f);
        this.mainpannel.Tag = f;
        f.Show();
        
        }

        

       

        private void ask(object sender, EventArgs e)
        {
            loadform(new UserApply());
            Feed.ForeColor = Color.WhiteSmoke;
            Feed.BackColor = Color.Gray;
            AskFOR.BackColor = Color.WhiteSmoke;
            AskFOR.ForeColor = Color.Gray;
            Acknow.ForeColor = Color.WhiteSmoke;
            Acknow.BackColor = Color.Gray;
            
        }


        private void send_click(object sender, EventArgs e)
        {
            AskFOR.ForeColor = Color.WhiteSmoke;
            AskFOR.BackColor = Color.Gray;
            Feed.BackColor = Color.WhiteSmoke;
            Feed.ForeColor = Color.Gray;
            Acknow.ForeColor = Color.WhiteSmoke;
            Acknow.BackColor = Color.Gray;

            loadform(new sendFeedback());
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            heLogIn b = new heLogIn();
            this.Hide();
            b.Show();
        }

        private void Acknow_click(object sender, EventArgs e)
        {
            loadform(new Acknowledgment());
            Acknow.BackColor = Color.WhiteSmoke;
            Acknow.ForeColor = Color.Gray;
            Feed.ForeColor = Color.WhiteSmoke;
            Feed.BackColor = Color.Gray;
            AskFOR.ForeColor = Color.WhiteSmoke;
            AskFOR.BackColor = Color.Gray;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heLogIn b = new heLogIn();
            this.Hide();
            b.Show();
        
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            uLabel.Text = "LOG OUT";
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            uLabel.Text = "User";
        }
       

        
    }
}
