<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript" lang="ja">


        function CheckLogin() {
            document.getElementById('PassError').innerHTML = "";
            document.getElementById("EmailErorr").innerHTML = "";
           
            var Email = document.getElementById("email").value;
            if (Email == "") {
                
                
                document.getElementById("EmailErorr").innerHTML = "אימייל לא יכול להיות ריק";
                return false;
            }
           

            if (Email.indexOf("@") == -1 || Email.indexOf("@") != Email.lastIndexOf("@")) {
                document.getElementById('EmailErorr').innerHTML = "אסור יותר משטרודל אחד אחד או פחות מאחד";
                
                return false;
            }
            if (Email.indexOf(".") == -1) {
                document.getElementById('EmailErorr').innerHTML = "צריך שיהיה נקודה";

                return false;
            }
            if (Email.indexOf("@.") != -1) {
                document.getElementById('EmailErorr').innerHTML = "אסור נקדוה אחרי השטרודל";
               
                return false;
            }
            if (Email.indexOf(" ") != -1) {
                document.getElementById('EmailErorr').innerHTML = "אסור רווח באימייל";
                return false;
            }
            document.getElementById("EmailErorr").innerHTML = "";



            var Password = document.getElementById("Pass").value;
            if (Password == "") {
                document.getElementById('PassError').innerHTML = "הסיסמה לא יכולה להיות ריקה";
                
                return false;

            }
            document.getElementById('PassError').innerHTML = "";






         
        }




    </script>


    <style>
      body {
            background-image: url('Images/ukrainaflag.png');
            background-repeat:no-repeat;
            background-size:cover;
                    
          
            direction: rtl;     
        }



    </style>

</head>
<body>

    <table style="margin:auto;">
        <tr>
        <td style=" padding: 10px;">
            <div>שלום אורח</div>
        </td>
        <td class="navbartd"  style=" padding: 10px;">
            <a href="ragister.html"><img src="Images/register_icon.png" width="40" height="40" /> </a>

            <div>הרשמה</div>
        </td>

                    <td class="navbartd">

                <a href="Main.aspx"><img src="Images/home_icon.png" width="40" height="40" /></a>
                <div>דף ראשי</div>
            </td>
            </tr>
    </table>



    <form id="form1" runat="server" onsubmit="return CheckLogin()" method="get">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <table border="1" style="margin:0 auto;font-size:40px;border-radius: 10px;border-width:5px;background-color:cornflowerblue">
            <tr>
                <td colspan="3" style="text-align:center">
                    התחבר
                </td>
            </tr>
            <tr>
              <td>
                  אימייל
                </td>
                <td>
                    <input type="text" id ="email" name="email" style="text-align:center"/>

                </td>
              <td id ="EmailErorr" style="color:red">

 

                </td>

            </tr>

               <tr>
                <td>
                    סיסמא   

                   </td>
                <td>
                    <input type="password" id ="Pass" name="pass"/>

                </td>
                <td id ="PassError"  style="color:red">
     

                   </td>

            </tr>
            <tr>
                <td colspan="3" style="text-align:center">
                    <input type="submit" />
                </td>
            </tr>
            <tr>
                <td runat="server" id="error3" colspan="3">

                </td>
            </tr>
        </table>
        <div>

        </div>
    </form>
</body>
</html>
