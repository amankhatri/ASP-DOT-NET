<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CachedEvent.aspx.cs" Inherits="_7_Server_Control_Events.CachedEvent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Text1_onclick() {

        }

        function Text1_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" 
            onclick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
