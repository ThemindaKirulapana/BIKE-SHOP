using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //LIBRARY OF SQL CONNECT



namespace BIKE_SHOP
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stock stol=new stock();
            this.Hide();
            
            stol.Show();

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            customer cus=new customer();
            this.Hide();
            
            cus.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            invoice invoice=new invoice();  
            this.Hide();
            
            invoice.Show();
        }

        private void btnsav_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

               
                string sql2 = "INSERT INTO BIKE_K(CHASSIS_NUM,ENGINE_NUM,BRAND,CATOGARY,FUEL_TYPE,BIKE_TYPE,CAPACITY,B_YEAR,PRICE) VALUES ('" + txtChas_num.Text + "','" + txtEngine.Text + "','" + combbrand.Text + "','" + txtcata.Text + "','" + combfuel.Text + "','" + combtype.Text + "','" + cmbCapa.Text + "','" + txtYear.Text + "','" + textprice.Text + "')";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("ADD");
               
                con1.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        public void clear()
        {
            txtChas_num.Text = "";
            txtEngine.Text = "";
            combbrand.Text = "";
            txtcata.Text = "";
            combfuel.Text = "";
            combtype.Text = "";
            cmbCapa.Text = "";
            txtYear.Text = "";
            textprice.Text = "";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

                string sql2 = "UPDATE BIKE_K SET ENGINE_NUM='" + txtEngine.Text + "',BRAND='" + combbrand.Text + "',CATOGARY='" + txtcata.Text + "',FUEL_TYPE='" + combfuel + "',BIKE_TYPE='" + combtype.Text + "',CAPACITY='" + cmbCapa.Text + "', B_YEAR='" + txtYear.Text + "',PRICE='" + textprice.Text + "'WHERE CHASSIS_NUM='" + txtChas_num.Text + "'";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("UPDATED");
                clear();
                con1.Close();
            }
            catch(Exception wx) 
            {
                MessageBox.Show(wx.Message);
            }

            
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
           try
            {
                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

                string sql2 = "DELETE FROM BIKE_K WHERE CHASSIS_NUM='" + txtChas_num.Text + "'";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("DELETED ");
                clear();
                con1.Close();
            }
            catch( Exception rt)
            {
                  MessageBox.Show (rt.Message);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            STAFF_EMPLPYEE_MAIN mainStaff=new STAFF_EMPLPYEE_MAIN();
            this.Hide();
            mainStaff.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_us about_Us = new About_us(); 
            this.Hide();
            about_Us.Show();    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            dateTimePicker1.Value = DateTime.Today;

            DateTime iDate;
            iDate = dateTimePicker1.Value;
        }
    }
}
