<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="StudentManagmentApp.StudentView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
        <asp:DropDownList ID="regNoDropDownList" runat="server">
        </asp:DropDownList>
    
    </div>
    <div>
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        </div>
    </form>
    </body>
</html>
