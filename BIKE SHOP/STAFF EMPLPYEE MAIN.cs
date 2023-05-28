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

namespace BIKE_SHOP
{
    public partial class STAFF_EMPLPYEE_MAIN : Form
    {
        public STAFF_EMPLPYEE_MAIN()
        {
            InitializeComponent();
        }

        private void btnBackmain_Click(object sender, EventArgs e)
        {
            MAIN main8=new MAIN();
            this.Close();
            main8.Show();
        }

        private void buttoNsAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

                string sql2 = "INSERT INTO EMPLOYEE(EMP_NIC,EMP_NAME, EMP_ADD,EMP_AGE,EMP_TYPE,EMP_MAIL,EMP_CONTACT) VALUES('" + textEmp_NIC.Text + "','" + texTname.Text + "','" + textADD.Text + "','" + textage_EMP.Text + "','" + textEMPtype.Text + "','" + textmailEMP.Text + "','" + textNUM_EMP.Text + "')";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("ADD");
                
                con1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void btnEmployeeRecords_Click(object sender, EventArgs e)
        {
            Employee_Rrcord EMP=new Employee_Rrcord();
            this.Hide();

            EMP.Show();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

                string sql2 = "DELETE FROM EMPLOYEE WHERE EMP_NIC='" + textEmp_NIC.Text + "'";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("DELETED");

                con1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

                string sql2 = "UPDATE EMPLOYEE SET EMP_NAME='" + texTname.Text + "',EMP_ADD='" + textADD.Text + "',EMP_AGE='" + textage_EMP.Text + "',EMP_TYPE='" + textEMPtype.Text + "',EMP_MAIL='" + textmailEMP.Text + "'WHERE EMP_NIC='" + textEmp_NIC.Text + "'";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                MessageBox.Show("updated");

                con1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void bTNSalarySheet_Click(object sender, EventArgs e)
        {
            Salary_Sheet salary_Sheet = new Salary_Sheet();
            this.Hide();
            salary_Sheet.Show();
        }
    }
}
