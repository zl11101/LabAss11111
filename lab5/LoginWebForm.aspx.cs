﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SimpleDatabaseConnectionString"].ConnectionString);
            conn.Open();
            string querString = "Select username, Password from Logon where Username='"+txtUsername.Text+"'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(querString, conn);   

            DataSet ds1 = new DataSet();
            adapter.Fill(ds1,"Logon");
            if (ds1.Tables["Logon"].Rows.Count > 0)
            {
                lblCaption.Text = "Invalid Username";

            }
            else
            {
                if (ds1.Tables["Logon"].Rows[0][1].ToString().Trim()== txtPassword.Text.Trim())
                {
                    lblCaption.Text = "welcome," + txtUsername.Text;

                    
                    Session["Uname"] = txtUsername.Text;
                    Server.Transfer("Welcome.aspx");
                }
                else
                {
                    lblCaption.Text = "Invalid password";
                }
            }
            conn.Close();

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}