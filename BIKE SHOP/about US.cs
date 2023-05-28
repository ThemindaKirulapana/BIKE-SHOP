using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //Provides prosess  class which  has some methods  can run exteanal 

namespace BIKE_SHOP
{
    public partial class About_us : Form
    {
        public About_us()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100066797019457");
        }

        private void BtnBCK_Click(object sender, EventArgs e)
        {
            MAIN mAIN = new MAIN();
            this.Hide();
            mAIN.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("renuka.kirulapana@gmail.com");
        }
    }
}
