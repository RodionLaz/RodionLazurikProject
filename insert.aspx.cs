using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["fname"]!= null && Request.QueryString["fname"] != "") 
        {
            string Fname = Request.QueryString["fname"].ToString().Trim();
            string Lname = Request.QueryString["lname"].ToString().Trim();
            string City = Request.QueryString["city"].ToString().Trim();
            string Addres = Request.QueryString["address"].ToString().Trim();
            int Age = int.Parse(Request.QueryString["age"].ToString());
            string Mail = Request.QueryString["mail"].ToString().Trim();
            string Pass = Request.QueryString["pass"].ToString().Trim();
            string Gender = Request.QueryString["gender"].ToString().Trim();
            string Hobby = Request.QueryString["hobby"].ToString().Trim();
            string Notes =  Request.QueryString["info"].ToString().Trim();
            if (IsEmailExists(Mail))
            {
                string StrSql = "INSERT INTO Users (UserFname,UserLname,UserAddres,UserAge,UserEmail,UserPass,UserGander,UserCity,UserHobby,UserNotes) VALUES(N'" + Fname + "',N'" + Lname + "',N'" + Addres + "'," + Age + ",N'" + Mail + "',N'" + Pass + "', N'" + Gender + "',N'" + City + "',N'" + Hobby + "',N'" + Notes + "' )";
                Connect con = new Connect();
                int result = con.InsertUpdateDelete(StrSql);
                if (result != 0)
                {
                    Response.Redirect("ShowUsers.aspx");
                }
                else 
                {
                    
                    
                }
            }
            else
            {
                Div1.InnerHtml = "האימייל כבר קיים";
            }





        }
        else
        {
            Response.Redirect("Main.aspx");
        }





    }
    public bool IsEmailExists(string email)
    {
        string sql = "SELECT COUNT(UserFname) FROM Users WHERE UserEmail = '" + email + "'";
         
        Connect con = new Connect();
        object obj = con.GetObject(sql);
        int results = int.Parse(obj.ToString());
        if (results !=0)
        {
            return false;
        }
        return true;


    }


}