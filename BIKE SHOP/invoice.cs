using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BIKE_SHOP
{
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MAIN m1 = new MAIN();
            this.Close();
            m1.Show();

        }

        private void bTNcal_Click(object sender, EventArgs e)
        {
            if(textprice.Text!="" && txtDis.Text!="")
            {
                try
                {
                    double price = Convert.ToDouble(textprice.Text);
                    double dis = Convert.ToDouble(txtDis.Text);
                    double final_Bill;

                    final_Bill = price - dis;

                    txtbillFinal.Text = final_Bill.ToString();

                }
                catch(Exception QW)
                {
                    MessageBox.Show(QW.Message);
                }


            }
            else
            {
                MessageBox.Show("please fill data for calculate");
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con dbcon = new Databace_Con();

                SqlConnection con7 = new SqlConnection(dbcon.connect);
                con7.Open();

                string sql24 = "INSERT INTO INVOICE(INVOICE_ID, NIC,CHASSIS_NUM,PRICE,DISCOUNT,F_BILL)VALUES('" + txtIId.Text + "','" + txtNIC.Text + "','" + txtChas_num.Text + "','" + textprice.Text + "','" + txtDis.Text + "','" + txtbillFinal.Text + "')";

                SqlCommand cmd34 = new SqlCommand(sql24, con7);
                cmd34.ExecuteNonQuery();


                

                MessageBox.Show("add");
                con7.Close();


                string able= txtChas_num.Text;
                SqlUpdate aqlo=new SqlUpdate();
                aqlo.Upadete(able);
                

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


           
        }

        private void buttonSeeBike_Click(object sender, EventArgs e)
        {
           try
            {

                Databace_Con dvb = new Databace_Con();
                SqlConnection conn = new SqlConnection(dvb.connect);
                conn.Open();

                String sql = "SELECT * FROM BIKE_K  ";

                SqlCommand cmd45 = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd45);
                DataTable DT1 = new DataTable();
                adapter.Fill(DT1);

                grdBikeStocks.DataSource = DT1;

                conn.Close();

            }
            catch(Exception cs)
            {
                MessageBox.Show(cs.Message);
            }
        }

        private void buttonCustomerSee_Click(object sender, EventArgs e)
        {
            Databace_Con dvb = new Databace_Con();
            SqlConnection conn = new SqlConnection(dvb.connect);
            conn.Open();

            String sql = "SELECT * FROM CUSTOMER  ";

            SqlCommand cmd45 = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd45);
            DataTable DT1 = new DataTable();
            adapter.Fill(DT1);

            GRDcusRecords.DataSource = DT1;

            conn.Close();
        }

        private void BTNdlete_Click(object sender, EventArgs e)
        {
            Databace_Con dbcon = new Databace_Con();

            SqlConnection con7 = new SqlConnection(dbcon.connect);
            con7.Open();

            string sql24 = "DELETE FROM INVOICE WHERE INVOICE_ID='" + txtIId.Text + "'";

            SqlCommand cmd34 = new SqlCommand(sql24, con7);
            cmd34.ExecuteNonQuery();
            MessageBox.Show("DELETED");
            con7.Close();
        }

        private void btnSeeiNVOICERecords_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con dvb = new Databace_Con();
                SqlConnection conn = new SqlConnection(dvb.connect);
                conn.Open();

                String sql = "SELECT * FROM INVOICE  ";

                SqlCommand cmd45 = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd45);
                DataTable DT1 = new DataTable();
                adapter.Fill(DT1);

                grdINVOICE.DataSource = DT1;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtbillFinal.Text = null;
            txtChas_num.Text = null;
            txtNIC.Text = null;
            txtIId.Text = null;
            txtDis.Text = null;

        }

        private void btnupdat_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con dbcon = new Databace_Con();

                SqlConnection con7 = new SqlConnection(dbcon.connect);
                con7.Open();

                string sql24 = "UPDATE INVOICE SET NIC='" + txtNIC.Text + "',CHASSIS_NUM='" + txtChas_num.Text + "',PRICE='" + textprice.Text + "',DISCOUNT='" + txtDis.Text + "',F_BILL='" + txtbillFinal.Text + "'WHERE INVOICE_ID='" + txtIId.Text + "'";

                SqlCommand cmd34 = new SqlCommand(sql24, con7);
                cmd34.ExecuteNonQuery();
                MessageBox.Show("UPDATED");
                Clear();
                con7.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void grdBikeStocks_SelectionChanged(object sender, EventArgs e)
        {
            if (grdBikeStocks.SelectedRows.Count > 0) 
            {
                textprice.Text = grdBikeStocks.SelectedRows[0].Cells[8].Value + string.Empty;
                txtChas_num.Text = grdBikeStocks.SelectedRows[0].Cells[0].Value + string.Empty;
            }
        }

        private void GRDcusRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (GRDcusRecords.SelectedRows.Count > 0)
            {
                txtNIC.Text = GRDcusRecords.SelectedRows[0].Cells[0].Value + string.Empty;
                
            }
        }
    }
}
