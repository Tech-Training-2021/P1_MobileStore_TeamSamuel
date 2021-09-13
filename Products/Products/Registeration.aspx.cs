using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Products
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string queryR = "InsertReg";
            string queryL = "InsertLog";
            int CN_id;
            string f_name = tb_F_Name.Text;
            string l_name = tb_L_Name.Text;
            string dob = tb_Dob.Text;
            string mobile = tb_Phone.Text;
            string email = tb_Email.Text;
            string username = tb_Username.Text;
            string password = tb_Password.Text;
            string locations = tb_Locations.Text;
            string ConString = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(ConString))
            {

                using (SqlCommand cmd = new SqlCommand(queryR, connection))
                {
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@F_Name", f_name);
                    cmd.Parameters.AddWithValue("@L_Name", l_name);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Locations", locations);
                    CN_id = Convert.ToInt32(cmd.ExecuteScalar());




                    //connection.Close();
                }
                using (SqlCommand cmd = new SqlCommand(queryL, connection))
                {

                    //cmd.Connection = connection;
                    //connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@C_Id", CN_id);


                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}