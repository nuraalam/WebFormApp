<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="StudentManagmentApp.StudentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
            <asp:DropDownList ID="departmentDropDownList" runat="server">
            </asp:DropDownList>
        </div>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
        <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
    
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        </div>
    <div style="margin-top: 0px">
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        </div>
    <div>
        <asp:Label ID="displayStudentEntryMessage" runat="server"></asp:Label>
        </div>
    </form>
    </body>
</html>
