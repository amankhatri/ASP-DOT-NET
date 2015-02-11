<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_21_Retrieve_text_value_index_dropdownlist.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Text="Select Continent" Value= "-1"></asp:ListItem>
            
            <asp:ListItem Text="Asia" Value = "1"></asp:ListItem>
            <asp:ListItem Text="Europe" Value = "2"></asp:ListItem>
            <asp:ListItem Text="Africa" Value = "3"></asp:ListItem>
            <asp:ListItem Text="North America" Value = "4"></asp:ListItem>
            <asp:ListItem Text="South America" Value = "5"></asp:ListItem>
            
        </asp:DropDownList>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
