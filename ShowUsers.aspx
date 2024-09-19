<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowUsers.aspx.cs" Inherits="ShowUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



    <style>
        td {
    padding: 10px;
}
        tr:hover{
            background-color:yellow;
        }
        body{
            background-image:url(Images/backgroundimg2.png);
            background-repeat:no-repeat;
            background-size:cover;
            font-family: 'Guttman Hatzvi';
        }
        



    </style>

    <script lang="javascript" type="text/javascript">
        function SureDelete(name,email) {
            var isdelete = confirm("?" + name + " למחוק את ");
            if (isdelete == false) {
                return false;
            }
            else {
                document.location = "Delete.aspx?Delete=" + email + "";
            }
        }



    </script>
</head>

<body>

  <div style="font-size:80px;text-align:center">
                טבלת משתמשים 
   </div>

    <form id="form1" runat="server">
        <div>

        </div>
         <table style="margin:0 auto;top:50px;left:400px;" border="0">
        <tr>

            <td>
                <a href="Main.aspx"><img src="Images/home_icon.png" width="40" height="40" /></a>
                <div>דף ראשי</div>
            </td>
        </tr>
    </table>
        <br /><br /><br />
        <div>
            <%=tbl %>

        </div>
    </form>




</body>
</html>
