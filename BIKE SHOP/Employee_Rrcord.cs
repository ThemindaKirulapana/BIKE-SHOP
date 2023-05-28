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
    public partial class Employee_Rrcord : Form
    {
        public Employee_Rrcord()
        {
            InitializeComponent();
        }

        private void Employee_Rrcord_Load(object sender, EventArgs e)
        {

            try
            {

                Databace_Con dvb = new Databace_Con();
                SqlConnection conn = new SqlConnection(dvb.connect);
                conn.Open();

                String sql = "SELECT * FROM EMPLOYEE ";

                SqlCommand cmd45 = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd45);
                DataTable DT1 = new DataTable();
                adapter.Fill(DT1);

                GridViewEmpRecord.DataSource = DT1;

                conn.Close();

            }
            catch (Exception cs)
            {
                MessageBox.Show(cs.Message);
            }
        }

        private void buttonBCK_Click(object sender, EventArgs e)
        {
            STAFF_EMPLPYEE_MAIN sTAFF_EMPLPYEE_MAIN = new STAFF_EMPLPYEE_MAIN();
            this.Hide();   
            sTAFF_EMPLPYEE_MAIN.Show();
        }
    }
}
