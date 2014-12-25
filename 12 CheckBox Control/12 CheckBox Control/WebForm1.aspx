<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_12_CheckBox_Control.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="width:350px">
    <legend><b>Education</b></legend>

        <asp:CheckBox ID="GraduateCheckBox" runat="server" Text="Graduate" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="PostGraduateCheckBox" runat="server" Text="Post Graduate" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="DoctrateCheckBox" runat="server" Text="Doctrate" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />

    </fieldset>
    </div>
    </form>
</body>
</html>
