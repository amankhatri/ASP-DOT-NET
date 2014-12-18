<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="_3_ViewState.WebForm4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Text1_onclick() {

        }

        function Text2_onclick() {

        }

// ]]>
    </script>
</head>
<body style="height: 108px; width: 842px">
    <form id="form1" runat="server">
    <div>
    
        ASP.NET Server Control&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        HTML Control&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Text1" type="text" onclick="return Text1_onclick()" /><br />
        <br />
        Converted from HTML to ASP&nbsp;&nbsp;
        <input id="Text2" type="text" runat = "server" onclick="return Text2_onclick()" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" 
            Width="68px" />
        <br />
    
    </div>
    </form>
</body>
</html>
