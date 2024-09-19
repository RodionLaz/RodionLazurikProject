using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserEmail"] == null)
        {
            Response.Redirect("login.aspx");
        }
        if (Request.QueryString["Delete"] != null && Request.QueryString["Delete"] != "")
        {
            string email = Request.QueryString["Delete"];
            string strsql = "DELETE FROM Users WHERE UserEmail ='" + email + "'";
            Connect con = new Connect();
            con.InsertUpdateDelete(strsql);
            if (Session["admin"] == null)
            {
                Session.Abandon();
            }
            Response.Redirect("ShowUsers.aspx");

        }
        else
        {
            Response.Redirect("ShowUsers.aspx");
        }

            
    }
}