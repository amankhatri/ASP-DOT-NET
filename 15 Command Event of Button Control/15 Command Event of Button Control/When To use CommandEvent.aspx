<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="When To use CommandEvent.aspx.cs" Inherits="_15_Command_Event_of_Button_Control.When_To_use_CommandEvent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="PrintButton" runat="server" Text="Print" 
            oncommand="CommandButton_Click" CommandName="Print" 
              />
    <asp:Button ID="DeletButton" runat="server" Text="DeleteButton" 
            oncommand="CommandButton_Click" CommandName="Delete" 
              />
    <asp:Button ID="Top10Button" runat="server" Text="Show Top 10 Employees" 
            oncommand="CommandButton_Click" CommandName="Show" CommandArgument="TOP10" 
              />
    <asp:Button ID="Bottom10Button" runat="server" Text="Show Bottom 10 Employees" 
            oncommand="CommandButton_Click" CommandName="Show" CommandArgument="Bottom10" 
            />
    <asp:Label ID = "OutputLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
