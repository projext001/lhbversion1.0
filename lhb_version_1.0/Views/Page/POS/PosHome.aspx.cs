using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebHelper;

namespace lhb_version_1._0.Views.Page.POS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Validate v = new Validate();
            int User_Id;
            int User_Ac;
            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                User_Id = Convert.ToInt32(reqCookies["Id"]);
                User_Ac = Convert.ToInt32(reqCookies["Ac"]);
                int[] a = { 1, 3 };
                Console.WriteLine("Acc no:  "+User_Ac);
                //v.PageAcc(a,User_Ac);
            }
            else HttpContext.Current.Response.Redirect("~/Views/Shared/error.aspx");
        }
    }
}