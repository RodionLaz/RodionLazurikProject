using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class ShowUsers : System.Web.UI.Page
{
    public string tbl;
    string strSql = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["UserEmail"] == null)
        {
            Response.Redirect("login.aspx");
        }
        
        if (Session["admin" ] != null)
        {
             strSql = "SELECT * FROM Users WHERE UserEmail <> 'admin@gmail.com'";
        }
        if(Session["admin"] == null)
        {
             strSql = "SELECT * FROM Users WHERE UserEmail ='" + Session["UserEmail"] + "'";
        }


        Connect con = new Connect();
        DataSet ds = con.GetData(strSql, "Users");
        tbl = " <table border = '1' style = 'margin:0 auto;direction:rtl;text-alignt:center;background-color:#0072c6; border-width:10px; border-color: #e6c200;> ";
        tbl += "<tr style='color:yellow;background-color:blue;font-size:34px'>";
        tbl += "<td> מספר </td>";
        tbl += "<td>עדכון </td>";
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
        tbl += "<td> מחק </td>";
        tbl += "</tr>";


        for (int i = 0; i < ds.Tables["Users"].Rows.Count; i++)
        {
            string name = ds.Tables["Users"].Rows[i]["UserFname"].ToString() + "-" + ds.Tables["Users"].Rows[i]["UserLname"].ToString();
            string email = ds.Tables["Users"].Rows[i]["UserEmail"].ToString();



            tbl += "<tr>";
            tbl += " <td>" + (i + 1) + "</td>";
            tbl += " <td><a href=Update.aspx?email=" + email + ">עדכון</a>  </td>";
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
            tbl += "<td><a href='#' onclick=SureDelete('" + name + "','" + email + "')>מחק</a></td>";
            tbl += "</tr>";
            //',' "+ email+ " '
        }
        tbl += "</table>";


    }

    

    
}