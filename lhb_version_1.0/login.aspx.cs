using System;
using System.Data.SqlClient;
using System.Configuration;
using ClassLibrary1;



namespace lhb_version_1._0.Views.Page
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 ca = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String id0 = name.Text.ToString();
            String key = pass.Text.ToString();
            ca.LF(id0,key);
        }
    }
}