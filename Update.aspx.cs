using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Update : System.Web.UI.Page
{
    public static string originalEmail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserEmail"] == null)
        {
            Response.Redirect("login.aspx");
        }
        if (!IsPostBack) { 
            if (Request.QueryString["email"] != null && Request.QueryString["email"].ToString() != "") { 
            string email = Request.QueryString["email"].ToString().Trim();
            originalEmail = email;
            string Sql = "SELECT * FROM Users WHERE UserEmail ='" + email + "'";


            Connect con = new Connect();
            DataSet ds = con.GetData(Sql, "Users");




            fname.Value = ds.Tables["Users"].Rows[0]["UserFname"].ToString().Trim();
            lname.Value = ds.Tables["Users"].Rows[0]["UserLname"].ToString().Trim();
                addres.Value = ds.Tables["Users"].Rows[0]["UserAddres"].ToString().Trim();
                age.Value = ds.Tables["Users"].Rows[0]["UserAge"].ToString();
                mail.Value = ds.Tables["Users"].Rows[0]["UserEmail"].ToString().Trim();
                pass.Value = ds.Tables["Users"].Rows[0]["UserPass"].ToString().Trim();
                string Gender = ds.Tables["Users"].Rows[0]["UserGander"].ToString().Trim();
                City.Value = ds.Tables["Users"].Rows[0]["UserCity"].ToString().Trim();
                string hobby = ds.Tables["Users"].Rows[0]["UserHobby"].ToString().Trim();
                notes.Value = ds.Tables["Users"].Rows[0]["UserNotes"].ToString().Trim();


                if (Gender == "גבר")
            {
                man.Checked = true;
            }
            else
            {
                woman.Checked = true;
            }
            if (hobby.IndexOf("שחיה") != -1)
            {
                swim.Checked = true;

            }
            if (hobby.IndexOf("ריצה") != -1)
            {
                run.Checked = true;

            }
            if (hobby.IndexOf("כדורגל") != -1)
            {
                football.Checked = true;

            }
            if (hobby.IndexOf("כדורסל") != -1)
            {
                basketball.Checked = true;

            }

      
        }
            else
            {
                Response.Redirect("showusers.aspx");
            }
                   

      }
        else
        {

        
        if (Request.Form["update"] != null&& Request.Form["update"].ToString() != "")
        {
            string Email = mail.Value.Trim();
           
            string Fname = fname.Value.Trim();
            string Lname = lname.Value.Trim();
            string Age = age.Value.Trim();
            string Password = pass.Value.Trim();
            string Address = addres.Value.Trim();
            string city = City.Value.Trim();
            string gender = man.Value;
               string Notes = notes.Value;
            if (woman.Checked)
            {
                gender = woman.Value;
            }

            string hobby = "";
            if (swim.Checked)
            {
               hobby += " שחיה";
               hobby += ",";

            }
            if (run.Checked )
            {
                hobby += " ריצה";
                    hobby += ",";

                }
            if (football.Checked)
            {
                hobby += "כדורגל ";
                    hobby += ",";

                }
            if (basketball.Checked)
            {
                hobby += "כדורסל ";

            }
             string Sql = "SELECT COUNT(UserFname) FROM Users WHERE UserEmail = N'" + Email + "' AND UserEmail <> N'" + originalEmail +"'";
            Connect con = new Connect();
            object obj = con.GetObject(Sql);
            int results = int.Parse(obj.ToString());
            if (results != 0)
            {
                error.InnerHtml = "האימייל קיים";

            }
            else
            {
                    string StrSql = "UPDATE Users SET UserFname = N'" + Fname + "',UserLname = N'" + Lname + "', UserAge =" + Age + ", UserPass = N'" + Password + "', UserEmail = N'" + Email + "',  UserAddres = N'" + Address + "', UserCity = N'" + city + "', UserGander = N'" + gender + "', UserHobby =N'" + hobby + "', UserNotes =N'" +Notes + "'  WHERE UserEmail = '" + originalEmail + "'";
                    con.InsertUpdateDelete(StrSql);
                    if (Session["admin"] == null)
                    {
                        Session["UserName"] = Fname + "-" + Lname;
                        Session["UserEmail"] = Email;

                    }

                    Response.Redirect("ShowUsers.aspx");


                }

            }
        }

    }


}