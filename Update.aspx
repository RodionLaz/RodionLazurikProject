<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <style>
        .class1{
         font-size:10px;   
        }
        body{
            background-image:url(Images/backgroundimg2.png)
        }
        input{
            width:120px;
            font-size:10px;
        }

        body{
            background-image:url(Images/backgroundimg2.png);
            background-repeat:no-repeat;
            background-size:cover;
            font-family: 'Guttman Hatzvi';
        }
        .subbutton{
              background-color: #4CAF50;
              border: none;
              color: white;
              padding: 15px 32px;
              text-align: center;
              text-decoration: none;
              display: inline-block;
              font-size: 16px;
        }
        
    </style>
    <script type="text/javascript" lang="ja">
        var mone = 0;
        function CheckForm() {
           

            
             

            //בדיקת שם
            var Fname = document.getElementById("fname").value;
            var Lname = document.getElementById("lname").value;
            if (Fname == "") {
                document.getElementById("error").innerHTML ="מלא שם פרטי";
                return false;
            }

            if (Fname.length < 2 || Fname.length > 10) {
                document.getElementById("error").innerHTML = "כמות תוים בשם פרטי בין 2 ל10 ";
                return false;
            }
            if (IsOnlyHebrew(Fname) == false) {
                document.getElementById("error").innerHTML = "השם הפרטי רק בעברית";
                return false;
            }
            if (IsOnlyHebrew(Lname) == false) {
                document.getElementById("error").innerHTML = "השם משפחה  רק בעברית";
                return false;
            }
            //בדיקת שם משפחה
            var Lname = document.getElementById("lname").value;
            if (Lname == "") {
                document.getElementById("error").innerHTML = "מלא שם משפחה ";
                return false;
            }
            if (Lname.length < 2 || Lname.length > 20) {
                document.getElementById("error").innerHTML ="כמות תוים בשם משפחה בין 2 20 ";
                return false;
            }
            if (IsOnlyHebrew(Lname) == false) {
                alert("שם משפחה רק בעברית ובלי מספרים");
                return false;
            }
            // בדיקת כתובת
            var address = document.getElementById("addres").value;
            if (address == "") {
                document.getElementById("error").innerHTML = "מלא כתובת ";
                return false;
            }
            //בדיקת גיל
            var Age = document.getElementById("age").value;
            if (Age == "") {
                document.getElementById("error").innerHTML = "מלא  גיל ";
                return false;
            }
            if (IsOnlyNumber(Age) == false) {
                document.getElementById("error").innerHTML = "רק מספרים בגיל";
                return false;
            }
            if (Age > 80 || Age < 10) {
                document.getElementById("error").innerHTML = "הגיל בין 10 ל80 ";
                return false;
            }
            //בדיקת אימייל
            var Mail = document.getElementById("mail").value;
            var x = Mail.indexOf("@");

            if (Mail == "") {
                document.getElementById("error").innerHTML = "מלא האימייל ";
                return false;
            }

            if (Mail.indexOf("@") == -1 || Mail.indexOf("@") != Mail.lastIndexOf("@")) {
                document.getElementById("error").innerHTML = "@ חסר או יש יותר מאחד";
                return false;
            }
            if (Mail.indexOf("@.") != -1) {
                document.getElementById("error").innerHTML = "אסור נקודה אחרי @";
                return false;
            }
            //בדיקת סיסמא
            var Pass = document.getElementById("pass").value;
            if (Pass == "") {
                document.getElementById("error").innerHTML = "מלא סיסמא ";
                return false;
            }
            if (Pass.length < 4 || Pass.length > 20) {
                document.getElementById("error").innerHTML = "כמות תוים בסיסמא בין 4 ל20 ";
                return false;
            }
            
            //בדיקה שנבחרו לפחות שתי תחביבים

            if (football.checked) mone++;
            if (basketball.checked) mone++;
            if (run.checked) mone++;
            if (swim.checked) mone++;

            if (mone < 2) {
                document.getElementById("error").innerHTML = "תבחר לפוחות שתי תחביבים";
                mone = 0;
                return false;


            }

            
            return true;
        }

        function IsOnlyHebrew(str) {
            for (var i = 0; i < str.length; i++) {
                if (!(str.charAt(i) >= 'א' && str.charAt(i) <= 'ת')) {
                    return false;
                }
            }
            return true;
        }

        function IsOnlyNumber(num) {


            for (var i = 0; i < num.length; i++) {
                if (!(num.charAt(i) >= '0' && num.charAt(i) <= '9')) {
                    return false;
                }
            }
            return true;

        }


        function IsOnlyEnglish(str) {

            for (var i = 0; i < str.length; i++) {
                if (!(str.charAt(i) >= 'a' && str.charAt(i) <= 'z')) {
                    return false;
                }
            }
            return true;
        }
        
    </script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return CheckForm()">

    




    <table style="margin:auto;direction:rtl" border="1" >
        <tr>
            <td colspan="9" style="text-align:center">עדכון פרטים</td>
        </tr>
        <tr>
                 <td  style="white-space:nowrap">
                      שם פרטי
                     </td>
                      <td >
                         שם משפחה
                    </td>
                    <td>
                    כתובת
                    </td>
                        <td>
                         גיל
                        </td>
                       <td>
                אימיל
               </td>
                         <td>
                        סיסמא
                         </td>
                     <td>
                      עיר
                            </td>
                        <td>
                מגדר
                            </td>
                                    <td>
                                תחביב
                            </td>
            <td>

            </td>
            </tr>
                 <tr>
                                         <td>
                     <input type="text" id="fname" name="fname" runat="server" />
                 </td>
                    <td>
                     <input type="text" id="lname" name="lname" runat="server"/>
                 </td>

                   

                

                   <td >
          <input type="text" id="addres" name="addres" runat="server" />
            </td>


               <td >
            <input type="text" id="age" name="age" runat="server"/>
                </td>
           
   

              <td >
            <input type="text" id="mail" name="mail" runat="server"/>
              </td>
             
              <td >
                <input type="text" id="pass" name="pass" runat="server"/>
           </td>


        
                

                            <td>
                                <select id="City" name="City" runat="server">
                                    
                                    <option value="תל אביב">תל אביב</option>
                                    <option value="חיפה">חיפה</option>
                                    <option value="בית אריה">בית אריה</option>
                                </select>
                            </td>
        
                        
                      

                            <td >
                                <input type="radio" id="man" name="gender" value="גבר" runat="server"/>&nbsp; גבר
                                <br />
                                <input type="radio" id="woman" name="gender" value="אישה" runat="server"/>&nbsp; אישה
                            </td>

                       

                            <td >
                                <input type="checkbox" id="swim" name="hobby" value="שחיה" runat="server"/>&nbsp; שחיה
                                <br />
                                <input type="checkbox" id="run" name="hobby" value="ריצה" runat="server"/>&nbsp; ריצה
                                <br />
                                <input type="checkbox" id="football" name="hobby" value="כדורגל" runat="server"/>&nbsp; כדורגל
                                <br />
                                <input type="checkbox" id="basketball" name="hobby" value="כדורסל" runat="server"/>&nbsp; כדורסל
                            </td>
                     <td>
                         <textarea runat="server" id="notes" name="notes"></textarea>
                     </td>

                        </tr>
        <tr>
            <td colspan="10">
                <div id="error" runat="server" style="text-align:center;color:red"></div>
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <input type="submit" id="update" value="update" name="update" runat="server"  class="subbutton" />
            </td>
        </tr>

    </table>
        </form>



</body>
</html>
