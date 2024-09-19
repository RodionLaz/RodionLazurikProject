using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("shabag ");
        Response.Write("<br /><span style='color:green;font-size:40px'>h</scpan><span style='color:green;font-size:40px'>e</scpan><span style='color:green;font-size:40px'>l</scpan><span style='color:green;font-size:40px'>l</scpan><span style='color:green;font-size:40px'>o</scpan>");
        Response.Write("<br /><span style='color:red;font-size:60px'>s</scpan><span style='color:green;font-size:50px'>a</scpan><span style='color:yellow;font-size:40px'>l</scpan><span style='color:blue;font-size:30px'>o</scpan><span style='color:black;font-size:20px'>m</scpan>");
        //Response.Redirect("ragister.html");
        //Response.Redirect("https://he.wikipedia.org/");


    }
}