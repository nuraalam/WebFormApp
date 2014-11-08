<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEntry.aspx.cs" Inherits="StudentManagmentApp.DepartmentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
    
        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </div>
    <div>
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" style="height: 26px" Text="Save" />
        </div>
    </form>
    </body>
</html>
