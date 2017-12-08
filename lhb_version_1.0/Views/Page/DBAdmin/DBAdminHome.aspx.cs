using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lhb_version_1._0.Views.Page.DBAdmin
{
    public partial class DBAdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] number = { 4 };
            Class1 ca = new Class1();
            ca.AC(number, 4);
        }
    }
}