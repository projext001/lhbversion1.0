using System;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace ClassLibrary1
{
    public class Class1
    {
        public String Encr(String a)
        {
            Double b = 100 * Convert.ToDouble(a);
            return Convert.ToString(b);
        }

        public void AC(int[] a,int b)
        {
            if (a.Contains(b)) { }
            else { HttpContext.Current.Response.Redirect("~/Views/Shared/error.aspx"); ; }
        }
        public void LF(String a,String b)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString());
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "Select * from [Table] where uname=@name and pass=@pas";
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@name", a);
            comm.Parameters.AddWithValue("@pas", Encr(b));
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows){
                dr.Read();
                int d = Convert.ToInt32(dr[2]);
                if (d == 1) { HttpContext.Current.Response.Redirect("~/Views/Page/POS/PosHome.aspx"); }
                else if (d == 2) { HttpContext.Current.Response.Redirect("~/Views/Page/Manager/ManagerHome.aspx"); }
                else if (d == 3) { HttpContext.Current.Response.Redirect("~/Views/Page/BackEnd/BackEndHome.aspx"); }
                else if (d == 4) { HttpContext.Current.Response.Redirect("~/Views/Page/DBAdmin/DBAdminHome.aspx"); }
                else { }
            }
            else { HttpContext.Current.Response.Redirect("~/Views/Shared/error.aspx"); }            
        }
        /*
          int[] number = {1,2,3};
            Class1 ca = new Class1();
            ca.AC(number, 4))
          */
    }
}
