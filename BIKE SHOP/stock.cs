using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BIKE_SHOP
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MAIN M1 =new MAIN();
            M1.Show();
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Databace_Con DB1 = new Databace_Con();

            SqlConnection con4 = new SqlConnection(DB1.connect) ;
            con4.Open();

            string sql9 = "SELECT * FROM BIKE_K";
            SqlCommand command=new SqlCommand(sql9,con4);   

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
             
            grdStock.DataSource = dt;

            con4.Close();



        }

        private void grdStock_SelectionChanged(object sender, EventArgs e)
        {
            if (grdStock.SelectedRows.Count > 0)
            {
               

            }
        }
    }
}
