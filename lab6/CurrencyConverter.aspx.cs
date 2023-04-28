using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double n1 =Convert.ToDouble(TextBox1.Text);

            double result = 0.15 * n1;

            //TextBox1.Text = result.ToString();

            TextBox2.Text =result.ToString();
        }
    }
}