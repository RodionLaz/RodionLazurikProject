using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class search : System.Web.UI.Page
{
    public string tbl;
     string strSql = "";
    public int maxage,avgage;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Session["admin"] == null)
        {
            Response.Redirect("Main.aspx");
        }

        if (!Page.IsPostBack)
        {
            strSql = "SELECT * FROM USERS";
        }
        else{
            
            if (Request.QueryString["search"] != null && Request.QueryString["search"].ToString() != "")
            {
                strSql = "SELECT * FROM USERS";
            }
            if (Request.QueryString["agedown"] != null && Request.QueryString["agedown"].ToString() != "")
            {
                strSql = "SELECT * FROM USERS ORDER BY UserAge";
            }
             if(Request.QueryString["ageup"] != null && Request.QueryString["ageup"].ToString() != "")
            {
                strSql = "SELECT * FROM USERS ORDER BY UserAge DESC";
            }
             if(Request.QueryString["showall"] != null && Request.QueryString["showall"].ToString() != "")
            {
                strSql = "SELECT * FROM USERS";
            }
             if(Request.QueryString["firstot"] != null && Request.QueryString["firstot"].ToString() != "")
            {
                string ot = Request.QueryString["firstot"].ToString();
                strSql = "SELECT * FROM USERS WHERE UserFname LIKE N'" + ot + "%'";
            }
             if(Request.QueryString["lastot"] != null && Request.QueryString["lastot"].ToString() != "")
            {
                string ot = Request.QueryString["lastot"].ToString();
                strSql = "SELECT * FROM USERS WHERE UserLname LIKE N'%" + ot + "'";
            }

             if(Request.QueryString["agebigsame"] != null && Request.QueryString["agebigsame"].ToString() != "")
            {
                int age = int.Parse(Request.QueryString["agebigsame"].ToString());
                strSql = "SELECT * FROM USERS WHERE UserAge >=" + age + "";
            }

             if(Request.QueryString["maxage"] != null && Request.QueryString["maxage"].ToString() != "" && Request.QueryString["minage"] != null && Request.QueryString["minage"].ToString() != "")
            {
                int maxage = int.Parse(Request.QueryString["maxage"].ToString());
                int minage = int.Parse(Request.QueryString["minage"].ToString());
                strSql = "SELECT * FROM USERS WHERE UserAge BETWEEN " + minage + " AND " + maxage + "";
            }
            else if(Request.QueryString["emailend"] != null && Request.QueryString["emailend"].ToString() != ""&& Request.QueryString["city"] != null && Request.QueryString["city"].ToString() != "")
            {
                string end = Request.QueryString["emailend"].ToString();
                string city = Request.QueryString["city"].ToString();
                strSql = "SELECT * FROM USERS WHERE UserEmail LIKE '%" + end + "%' AND UserCity = N'" + city + "'";

            }
             if (Request.QueryString["emailend"] != null && Request.QueryString["emailend"].ToString() != "" && Request.QueryString["city"] != null && Request.QueryString["city"].ToString() != "")
            {
                string end = Request.QueryString["emailend"].ToString();
                string city = Request.QueryString["city"].ToString();
                strSql = "SELECT * FROM USERS WHERE UserEmail LIKE '%" + end + "' AND UserCity = N'" + city + "'";

            }
             if (Request.QueryString["bigestage"] != null && Request.QueryString["bigestage"].ToString() != "")
            {
                strSql = "SELECT * FROM USERS";
                string Str = "SELECT MAX (UserAge) FROM Users";
                Connect con = new Connect();
                object obj = con.GetObject(Str);
                int results = int.Parse(obj.ToString());
                maxage = results;
            }
             if (Request.QueryString["avg"] != null && Request.QueryString["avg"].ToString() != "")
            {

               
                string Str = "SELECT AVG (UserAge) FROM Users";
                Connect con = new Connect();
                object obj = con.GetObject(Str);
                int results = int.Parse(obj.ToString());
                avgage = results;
                strSql = "SELECT * FROM USERS WHERE UserAge >= " + avgage;
                
            }




        }



        showUsers(strSql);


    }

    public void showUsers(string strSql)
    {
        
        Connect con = new Connect();
        DataSet ds = con.GetData(strSql, "Users");
        tbl = " <table border = '1' style = 'margin:0 auto;direction:rtl;text-alignt:center;> ";
        tbl += "<tr style='color:yellow;background-color:blue;font-size:34px'>";
        tbl += "<td> מספר </td>";
        tbl += "<td> שם פרטי </td>";
        tbl += "<td> שם משפחה </td>";
        tbl += "<td> כתובת </td>";
        tbl += "<td> גיל </td>";
        tbl += "<td> מייל </td>";
        tbl += "<td> סיסמא </td>";
        tbl += "<td> מגדר </td>";
        tbl += "<td> עיר </td>";
        tbl += "<td> תחביבים </td>";
        tbl += "<td> הערות </td>";
        tbl += "</tr>";


        for (int i = 0; i < ds.Tables["Users"].Rows.Count; i++)
        {
            string name = ds.Tables["Users"].Rows[i]["UserFname"].ToString() + "-" + ds.Tables["Users"].Rows[i]["UserLname"].ToString();
            string email = ds.Tables["Users"].Rows[i]["UserEmail"].ToString();



            tbl += "<tr>";
            tbl += " <td>" + (i + 1) + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserFname"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserLname"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserAddres"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserAge"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserEmail"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserPass"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserGander"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserCity"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserHobby"].ToString() + "</td>";
            tbl += " <td>" + ds.Tables["Users"].Rows[i]["UserNotes"].ToString() + "</td>";
            tbl += "</tr>";
            //',' "+ email+ " '
        }
        tbl += "</table>";
        
    }
}