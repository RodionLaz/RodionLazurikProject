using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
        

        if (Application["visited"]== null)
        {
            Application["visited"] = 0; 
        }

        if (Session["visitors"] == null)
        {
            Session["visitors"] = "";
            Application["visited"]= int.Parse(Application["visited"].ToString()) + 1;
            
        }
        
        
        
    }
}