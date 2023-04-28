using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BUtton1_CLick(object sender, EventArgs e)
        {
            Session.Remove("Uname");
            Response.Redirect("LoginWebForm.aspx");
        }
    }
}