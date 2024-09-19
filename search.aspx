<%@ Page Language="C#" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style/InfoPage.css" />
       
    <style>
        body{
            direction:rtl;
            text-align:center;
        }
    </style>
</head>
<body>
    <table style="margin: 0 auto; left: 400px;" border="0">
        <tr style="">
            <td class="navbartd">
                <a href="InfoPage2.html"> <img src="Images/city.png" width="40" height="40" /></a>
                <div>ערים </div>
            </td>
            <td class="navbartd">
                <a href="InfoPage3.html"> <img src="Images/militry_icon.png" width="40" height="40" /></a>
                <div>צבא </div>
            </td>
            <td class="navbartd">
                <a href="InfoPage4.html"> <img src="Images/turist_icon.png" width="40" height="40" /></a>
                <div>תיירות  באוקראינה</div>
            </td>
            <td class="navbartd">
                <a href="infoPage1.html"><img src="Images/history2_icon.png" width="40" height="40" /></a>
                <div>היסטוריה</div>
            </td>
            <td class="navbartd">
                <a href="infoPage5.html"><img src="Images/food_icon.png" width="40" height="40" /></a>
                <div>אוכל</div>
            </td>
            <td class="navbartd">

                <a href="Main.aspx"><img src="Images/home_icon.png" width="40" height="40" /></a>
                <div>דף ראשי</div>
            </td>
        </tr>
    </table>
    <form id="form1" runat="server" method="get">
        <table border="1" style="margin:auto;">
            <tr >
                <td style="text-align:center;font-size:40px" colspan="3">חיפוש מנוי</td>
            </tr>
            <tr>
                <td>1</td>
                <td><input value="חפש" id="sreach" name="search" type="submit"/></td>
                <td><input value="הצג את כולם" name="showall" type="submit"/></td>
            </tr>
            <tr>
                <td>2</td>
                <td><input id="agedown" name="agedown"  value="מיין גיל סדר יורד" type="submit"/></td>
                <td><input id="ageup" name="ageup" value="מיון גיל סדר עולה" type="submit"/></td>
            </tr>
            <tr>
                <td>3</td>
                <td>חיפוש לפי אות ראשונה בשם פרטי</td>
                <td><input type="text" name="firstot" placeholder="חיפוש לפי אות ראשונה בשם פרטי" /></td>    
            </tr>
            <tr>
                <td>4</td>
                <td>חיפוש לפי אות אחרונה בשם משפחה</td>
                <td><input type="text" name="lastot" placeholder="חיפוש לפי אות אחרונה בשם משפחה"/></td>    
            </tr>
            <tr>
                <td>5</td>
                <td>חיפוש לפי גיל גדול שווה</td>
                <td><input type="text" name="agebigsame" placeholder="חיפוש לפי גיל גדול שווה" /></td>    
            </tr>
            <tr>
                <td>6</td>
                <td>חיפוש לפי טווח גילאים</td>
                <td>מגיל:<input type="text" name="minage" placeholder="מגיל"/><br />עד גיל:<input name="maxage" placeholder="עד גיל" type="text" /></td>    
                 
            </tr>
            <tr>
                
                    <td>7</td>
                    <td>מייל מסתיים ב :<input type="text" name="emailend" placeholder=""/></td>  
                    <td>וגם מתגורר בעיר:<input type="text" name ="city"/></td>  
                
            </tr>

             <tr>
                <td>8</td>
                 <td><input value="הצג גיל מקסימלי "  name="bigestage" type="submit"/></td>
                
                <td><input value="<%=maxage %>" type="text"  /></td>    
            </tr>
            <tr>
                
                    <td>9</td>
                    <td><input  value="כל האנשים הגדולים ממוצע הגילאים" type="submit" name="avg"/></td>
                    <td>מציג את הגיל הממוצע ==><input  value="<%=avgage %>" type="text"/></td>
               
            </tr>
        </table>
    </form>
    <br />
    <br />
    <div>
        <%=tbl %>
    </div>

</body>
</html>
