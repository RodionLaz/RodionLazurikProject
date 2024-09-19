<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>רודיון לזוריק</title>
     <link  rel="stylesheet" href="Style/InfoPage.css"/>
    <style type="text/css">
        body {
            background-image: url('Images/ukrainaflag.png');
            background-repeat:no-repeat;
            background-size:cover;
                    
          
            direction: rtl;     
        }
        h1 {
            animation: color-change 1s infinite;
            text-align:center;
         }



    @keyframes color-change {
          0% { color: yellow; }
          50% { color: blue; }
          100% { color: yellow; }
     }
    </style>





</head>

<body>




    <div id="Date" onclick="DisplayDate()">

    </div>

    <table style="margin: 0 auto; left: 400px;" border="0" >
        <tr style="">

            
                               


                <td>
                     
                <%if (Session["UserName"] == null)
                    {

                     %>
               
                                

                </td>
                                 <td   class="navbartd">
                 <a href="ragister.html"><img src="Images/register_icon.png" width="40" height="40" /> </a>
                
                <div>הרשמה</div>
            </td>
                <td   class="navbartd">
                 <a href="Login.aspx"><img  src="Images/login_icon.png" width="40" height="40"/></a>
                
                <div>כניסה למניוים</div>
            </td>

                <td>
                     שלום אורח 
                    </td>
                     <%}%>
                    

                        <td>
                       <% if(Session["admin"] != null){ %>

                   </td>
                    <td>

                <a href="ShowUsers.aspx"><img src="Images/showusers.png" width="40" height="40"/></a>
                        <div>רשומים</div>
          </td>
                                                      <td  class="navbartd">
                <a href="search.aspx"> <img  src="Images/search.png" width="40" height="40"/></a>
                <div>דף חיפוש</div>
            </td>

                                                <td>
                       <a href="logout.aspx"><img src ="Images/logout_icon.png"  width="40" height="40"/></a>
                            <div>התנתקות</div>
                         </td>
                        <td>
                                    שלום <%=Session["UserName"] %>
                    <img src="Images/admin.png" style="width:25px;height:25px"/>
                </td>


                <%} %>
                
                 <%
                      else if(Session["UserName"] != null)
                     {
                %>

                    
               
                        <td>
                       <a href="ShowUsers.aspx"><img src ="Images/update_icon.png"  width="40" height="40"/></a>
                            <div>עדכון פרטים</div>

                         </td>
                                    <td>
                       <a href="logout.aspx"><img src ="Images/logout_icon.png"  width="40" height="40"/></a>
                            <div>התנתקות</div>

                         </td>

                        <td>
                         שלום <%=Session["UserName"]%>
                    </td>

                   <%}%>
                    
                

           
            <td  class="navbartd">
                <a href="InfoPage2.html"> <img  src="Images/city.png" width="40" height="40"/></a>
                <div>ערים באוקראינה</div>
            </td>
                            <td class="navbartd">
                <a href="InfoPage4.html"> <img src="Images/turist_icon.png" width="40" height="40" /></a>
                <div>תיירות  באוקראינה</div>
            </td>
                            <td class="navbartd">
                <a href="infoPage5.html"><img src="Images/food_icon.png" width="40" height="40" /></a>
                <div>אוכל</div>
            </td>
            <td   class="navbartd">
                <a href="InfoPage3.html"> <img  src="Images/militry_icon.png" width="40" height="40"/></a>
                <div>צבא אוקראינה</div>
            </td>
            <td  class="navbartd">
                
                <a href="infoPage1.html"><img src="Images/history2_icon.png" width="40" height="40" /></a>
                <div>היסטוריה</div>
            </td>
             <td  class="navbartd">
                <div>כמות אנשים שביקרו באתר : <%=Application["visited"] %></div>
            </td>
        </tr>
    </table>
    <h1>  ברוכים הבאים לאתר שלי</h1>




    

   
    <form id="form1" runat="server">

        


        

    </form>  
    <div style="font-size:40px;text-align:center;position:absolute;top:300px;left:450px;"> 
        <p style="color:blue">

    האתר מיועד לאנשים המתענינים באחת המדינות המענינות באירופה 

            </p>
        <br />
        <div style="font-size:larger;color:yellow">אוקראינה</div>
        </div>
    
</body>



</html>
