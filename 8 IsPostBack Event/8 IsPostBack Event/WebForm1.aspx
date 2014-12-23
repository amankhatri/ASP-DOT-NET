<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_8_IsPostBack_Event.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <th> Employee Details Form </th>
    <tr>
    <td>
    First Name :
    </td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    Last Name :
    </td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    City :
    </td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </td>
    </tr>
    </table>
        <asp:Button ID="Button1" runat="server" Text="Register Employee" 
            onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
