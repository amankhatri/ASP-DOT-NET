<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2 JavaScript.aspx.cs" Inherits="_14_Button_LinkButton_and_ImageButton.WebForm2_JavaScript" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
            onclientclick="alert('You are about to submit this page')" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Confirm"
            onclientclick= "return confirm('Are you sure if you want to submit')" />
        <br />
    </div>
    </form>
</body>
</html>
