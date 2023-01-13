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
    public partial class sendFeedback : Form
    {
        public sendFeedback()
        {
            InitializeComponent();
            loadform(new FeedBackOnExpert());
            feedOnExpert.BackColor = Color.WhiteSmoke;
            feedOnExpert.ForeColor = Color.DarkSlateGray;
        }
        public void loadform(object Form)
        {
            if (this.send_feedback_pannel.Controls.Count > 0)
                this.send_feedback_pannel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.send_feedback_pannel.Controls.Add(f);
            this.send_feedback_pannel.Tag = f;
            f.Show();
        }

        private void Feed_on_expert(object sender, EventArgs e)
        {
            loadform(new FeedBackOnExpert());
            feedOnExpert.BackColor = Color.WhiteSmoke;
            feedOnExpert.ForeColor = Color.DarkSlateGray;
            otherFeed.ForeColor = Color.WhiteSmoke;
            otherFeed.BackColor = Color.DarkSlateGray;
        }

        private void Other_feedback(object sender, EventArgs e)
        {
            loadform(new OtherFeedback());
            otherFeed.BackColor = Color.WhiteSmoke;
            otherFeed.ForeColor = Color.DarkSlateGray;
            feedOnExpert.ForeColor = Color.WhiteSmoke;
            feedOnExpert.BackColor = Color.DarkSlateGray;
        }
    }
}
