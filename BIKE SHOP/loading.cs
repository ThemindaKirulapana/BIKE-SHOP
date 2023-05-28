using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKE_SHOP
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
        int startpoint=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            presentage.Text = startpoint + "%";

            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();

                loging log = new loging();
                log.Show();
                this.Hide();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
