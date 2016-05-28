<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Information.aspx.cs" Inherits="Information" EnableViewStateMac="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body style="align-content:center">
    <form id="Info" runat="server" method="post" action="Details.aspx">
    <div>
    <table style="float:inherit">
        <tr>
            <td>
                First Name:
            </td>
            <td>
                <input id="txtFirstName" name="txtFirstName" type="text" />
            </td>
        </tr>
        <tr>
            <td>
                Last Name:
            </td>
            <td>
                <input id="txtLastName" name="txtLastName" type="text" />
            </td>
        </tr>
        <tr>
            <td>
                Address :
            </td>
            <td>
                <textarea id="txtAreaAdd" name="txtAreaAdd" cols="20" rows="2"></textarea>
            </td>
        </tr>
        <tr>
            <td>
                <input id="SubmitInfo" type="submit" value="submit" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
