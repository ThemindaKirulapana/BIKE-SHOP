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
    public partial class loging : Form
    {
        public loging()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(txtUSname.Text !="" ) //validation  not null user name text property
            {

                if(txtPW.Text != "" )  // validatin not null password property
                {

                   string Password = txtPW.Text.ToString(); // read password text property


                    // create sql connection

                    string Conect = @"Data Source=DESKTOP-SU692OL\SQLEXPRESS;Initial Catalog=KIRULAPANGE_MOTORS; Integrated Security=true";
                    //create class SqlConnecton class object paramiterized ( sql conecton veriable);
                    SqlConnection con2 = new SqlConnection(Conect);
                    //open with sqlConnection class object
                    con2.Open();

                    string sql = "SELECT * FROM ADMIN1 WHERE USER_NAM='" + txtUSname.Text + "' AND  PASSWOARD ='" + txtPW.Text + "' ";
                    //create a sql command object paramiterized ( sql qery veriable ,SqlConnection class object)
                    SqlCommand cmd = new SqlCommand(sql, con2);
                    // create  SqlDataReader object 
                    SqlDataReader rea= cmd.ExecuteReader();

                    if(rea.Read()==true) //  if  SqlDataReader Object true 
                    {
                        
                        MAIN main=new MAIN();
                        this.Hide();              // login to Main form
                       
                        main.Show();
                       
                        

                    }
                    else
                    {
                        MessageBox.Show("Please Enter User name or password corectly");
                    }


                }
                else
                {
                    MessageBox.Show("password not correct");
                }
            }
           else
            {
                MessageBox.Show("Enter user name correctly");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUSname.Text = "";
            txtPW.Text = "";
        }
    }
}
