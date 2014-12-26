<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_14_Button_LinkButton_and_ImageButton.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 183px">
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">SubmitLinkButton</asp:LinkButton>
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
            ImageUrl="~/Images/Submit.jpg" style="margin-top: 324px" Width="50px" 
            onclick="ImageButton1_Click" />
    </div>
    </form>
</body>
</html>
