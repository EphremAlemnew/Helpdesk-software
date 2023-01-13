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
    public partial class Admin_feedBack : Form
    {
        public Admin_feedBack()
        {
            InitializeComponent();
            loadform(new admin_feedbackOnExpert());
            feedExpertBt.BackColor = Color.WhiteSmoke;
            feedExpertBt.ForeColor = Color.DarkSlateGray;
        }
        public void loadform(object Form)
        {
            if (this.Admin_feedbackPannel.Controls.Count > 0)
                this.Admin_feedbackPannel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Admin_feedbackPannel.Controls.Add(f);
            this.Admin_feedbackPannel.Tag = f;
            f.Show();
        }
        private void admin_onExpert(object sender, EventArgs e)
        {
            loadform(new admin_feedbackOnExpert());
            feedExpertBt.BackColor = Color.WhiteSmoke;
            feedExpertBt.ForeColor = Color.DarkSlateGray;
            feedOtherBt.ForeColor = Color.WhiteSmoke;
            feedOtherBt.BackColor = Color.DarkSlateGray;


        }

        private void admin_otherFeedback(object sender, EventArgs e)
        {
            loadform(new admin_otherfeedback());
            feedOtherBt.BackColor = Color.WhiteSmoke;
            feedOtherBt.ForeColor = Color.DarkSlateGray;
            feedExpertBt.ForeColor = Color.WhiteSmoke;
            feedExpertBt.BackColor = Color.DarkSlateGray;
           
        }

        private void Admin_feedbackPannel_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
