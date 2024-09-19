using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["email"] != null && Request.QueryString["email"] != "")
        {
            string Email = Request.QueryString["email"];
            string Pass = Request.QueryString["pass"];
            
            if (!checkuser(Email, Pass))
            {
                error3.InnerHtml = "אחד הפרטים לא נכון";

            }
            else
            {

                string strsql = "SELECT * FROM Users WHERE UserEmail = '" + Email + "'";
                // AND UserPass = '" + Pass + "'
                Connect con = new Connect();
                DataSet ds = con.GetData(strsql, "Users");
                string FullName = ds.Tables["Users"].Rows[0]["UserFname"].ToString() + " " + ds.Tables["Users"].Rows[0]["UserLname"].ToString();
                Session["UserName"] = FullName;
                Session["UserEmail"] = Email;
                if(Email == "admin@gmail.com")
                {
                    Session["admin"] = "";
                }

                Response.Redirect("main.aspx");


            }
            

        }

    }
    public static bool checkuser(string email, string pass)
    {
        string strsql = "SELECT COUNT(UserFname) FROM Users WHERE UserEmail = '" + email + "' AND UserPass = '" + pass  + "'";

        Connect con = new Connect();
        object obj = con.GetObject(strsql);
        int results = int.Parse(obj.ToString());
        if (results == 0)
        {
            return false;
        }
        return true;
    }
}