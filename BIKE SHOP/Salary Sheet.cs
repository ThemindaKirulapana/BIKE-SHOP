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
    public partial class Salary_Sheet : Form
    {
        public Salary_Sheet()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(txtB_salary.Text !="" && txtOt_hours.Text!="")
            {
                try
                {
                    double Basic_sal = Convert.ToDouble(txtB_salary.Text);
                    double OT_Hours = Convert.ToDouble(txtOt_hours.Text);
                    double Allowence = 30000;
                    double sal;

                    if (15 > OT_Hours && OT_Hours > 10)
                    {
                        sal = Basic_sal + (OT_Hours * 5000) + Allowence;
                    }
                    else if (10 > OT_Hours && OT_Hours > 5)
                    {
                        sal = Basic_sal + (OT_Hours * 3000) + Allowence;
                    }
                    else
                    {
                        sal = Basic_sal + (OT_Hours * 100) + Allowence;
                    }
                    txtSalary.Text = Convert.ToString(sal);
                }
                catch(Exception SDE)
                {
                    MessageBox.Show(SDE.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Enter OT hours Or Basic Salary ");
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtSheetId.Text == null && txtEmp_NIC.Text == null)
            {
                MessageBox.Show("Fill Data");
            }
            else
            {
                try
                {
                    Databace_Con databace_Con5 = new Databace_Con();

                    SqlConnection conn = new SqlConnection(databace_Con5.connect);
                    conn.Open();

                    string sql = "INSERT INTO SALARY_SHEET(SHEET_ID,EMP_NIC,BASIC_SAL,OT_HOURS,SALRY) VALUES('" + txtSheetId.Text + "','" + txtEmp_NIC.Text + "','" + txtB_salary.Text + "','" + txtOt_hours.Text + "','" + txtSalary.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ADD");
                    conn.Close();
                }
                catch (Exception SDE)
                {
                    MessageBox.Show(SDE.Message);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Databace_Con databace_Con5 = new Databace_Con();

                SqlConnection conn = new SqlConnection(databace_Con5.connect);
                conn.Open();

                string sql = "DELETE FROM SALARY_SHEET WHERE  SHEET_ID='" + txtSheetId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                conn.Close();
            }
            catch (Exception SDE)
            {
                MessageBox.Show(SDE.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Databace_Con databace_Con6 = new Databace_Con();
            SqlConnection connt = new SqlConnection(databace_Con6.connect);

            string sql = "SELECT * FROM SALARY_SHEET";
            SqlCommand Cmd=new SqlCommand(sql, connt);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataTable DT =new DataTable();
            adapter.Fill(DT);

            GridViewSALARY.DataSource = DT;
            connt.Close();


        }

        private void buttonBCK_Click(object sender, EventArgs e)
        {
            STAFF_EMPLPYEE_MAIN sTAFF_EMPLPYEE = new STAFF_EMPLPYEE_MAIN();
            this.Hide();
            sTAFF_EMPLPYEE.Show();
        }
    }
}
