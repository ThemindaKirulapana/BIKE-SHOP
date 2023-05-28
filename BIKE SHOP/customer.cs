using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace BIKE_SHOP
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MAIN m1 =new MAIN();
            m1.Show ();
            this.Close ();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Databace_Con dbcon = new Databace_Con();

                SqlConnection con76 = new SqlConnection(dbcon.connect);
                con76.Open();

                string sql24 = "INSERT INTO CUSTOMER(NIC,CUS_NAME,CUS_ADD,EMAIL,CONTACT_NUMBER)VALUES('" + txtNIC.Text + "','" + txtCUS_NAME.Text + "','" + txtADD.Text + "','" + txtEMAIL.Text + "','" + txtCONTACT.Text + "')";

                SqlCommand cmd34 = new SqlCommand(sql24, con76);
                cmd34.ExecuteNonQuery();
                MessageBox.Show("ADD");
                con76.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            //sending mail messege...............tO customer

            string from, pass, messagebody;
           
            
            MailMessage message = new MailMessage();
            string to = (txtEMAIL.Text).ToString();
            from = "renuka.kirulapana@gmail.com"; 
            pass = "hdhnqbbdogibcmvd";
                                      
            messagebody =$"Dear  Valuable Customer ('"+ txtCUS_NAME .Text+ "') You have been registered with our Motors as a Customer \n\n KIRULAPANAGE MOTORS\n\n  CONTACT NUMBER--0701809145";
            message.To.Add(to);
            message.From = new MailAddress(from);                      //using System.Net.Mail;
            message.Body = messagebody;
            message.Subject = "Register Customer";                    //email subject
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");      //using System.Net;
            smtp.EnableSsl = true;
            smtp.Port = 587;                                        //smtp port number
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;      //using System.Net;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);                              //send email
                MessageBox.Show("Sent A mail to Customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnvw_Click(object sender, EventArgs e)
        {
            Databace_Con dbcon23=new Databace_Con();

            SqlConnection con89=new SqlConnection (dbcon23.connect);
            con89.Open();

            string sql = "SELECT * FROM CUSTOMER";
            SqlCommand command = new SqlCommand(sql, con89);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewcus.DataSource = dt;

            con89.Close();



        }

        private void button1_Click(object sender, EventArgs e)//btn save Event
        {
            try
            {
                Databace_Con dbcon = new Databace_Con();

                SqlConnection con76 = new SqlConnection(dbcon.connect);
                con76.Open();

                string sql24 = "UPDATE CUSTOMER SET CUS_NAME='" + txtCUS_NAME.Text + "',CUS_ADD='" + txtADD.Text + "',EMAIL='" + txtEMAIL.Text + "', CONTACT_NUMBER='" + txtCONTACT.Text + "' WHERE NIC='" + txtNIC.Text + "'";

                SqlCommand cmd34 = new SqlCommand(sql24, con76);
                cmd34.ExecuteNonQuery();
                MessageBox.Show("Updated Sucsess");
                con76.Close();
            }
            catch(Exception exa)
            {
                Console.WriteLine(exa.Message);
            }
        }

        private void bTNDELETE_Click(object sender, EventArgs e)
        {
            Databace_Con dbcon = new Databace_Con();

            SqlConnection con76 = new SqlConnection(dbcon.connect);
            con76.Open();

            string sql24 = "DELETE FROM CUSTOMER WHERE  NIC='" + txtNIC.Text + "'";

            SqlCommand cmd34 = new SqlCommand(sql24, con76);
            cmd34.ExecuteNonQuery();
            MessageBox.Show("DELETED");
            con76.Close();
        }

        private void dataGridViewcus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewcus.SelectedRows.Count > 0)
            {

                txtNIC.Text = dataGridViewcus.SelectedRows[0].Cells[0].Value + string.Empty;
                txtCUS_NAME.Text = dataGridViewcus.SelectedRows[0].Cells[1].Value + string.Empty;
                txtADD.Text = dataGridViewcus.SelectedRows[0].Cells[2].Value + string.Empty;
                txtEMAIL.Text = dataGridViewcus.SelectedRows[0].Cells[3].Value + string.Empty;
                txtCONTACT.Text = dataGridViewcus.SelectedRows[0].Cells[4].Value + string.Empty;
                



            }
        }
    }
}
