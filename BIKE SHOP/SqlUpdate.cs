using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKE_SHOP
{
    internal class SqlUpdate
    {
        

        public string status = "SOLD";

        public void Upadete(string sttm)
        { 
            

            try
            {

                Databace_Con db1 = new Databace_Con();

                SqlConnection con1 = new SqlConnection(db1.connect);
                con1.Open();

                string sql2 = "UPDATE BIKE_K SET  STATUS_K='" + status + "' WHERE CHASSIS_NUM='"+sttm+"'";

                SqlCommand cmd = new SqlCommand(sql2, con1);
                cmd.ExecuteNonQuery();

                
               
                con1.Close();
            }
            catch (Exception wx)
            {
                MessageBox.Show(wx.Message);
            }
        }
    }
}
