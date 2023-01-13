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
    public partial class ExpertViewFull : Form
    {
        public ExpertViewFull()
        {
            InitializeComponent();
        }

        private void back(object sender, EventArgs e)
        {
            this.Hide();
            HelperHome s = new HelperHome();
            s.Show();
        }

        private void done(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Success!");
        }
    }
}
