<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBook.aspx.cs" Inherits="PersonalLibraryManagmentSystemApp.BorrowBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 284px; margin-left: 150px; margin-top: 125px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Member No" Width="120px"></asp:Label>
            <asp:TextBox ID="enterMemberNoTextBox" runat="server" style="margin-left: 38px" Width="160px"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Select A Book" Width="120px"></asp:Label>
            <asp:DropDownList ID="selectABookDropDownList" runat="server" style="margin-left: 36px; margin-right: 80px" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="selectABookDropDownList_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Author" Width="120px"></asp:Label>
            <asp:TextBox ID="authorTextBox" runat="server" style="margin-left: 35px" Width="160px"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Publisher" Width="120px"></asp:Label>
            <asp:TextBox ID="publisherTextBox" runat="server" style="margin-left: 36px" Width="160px"></asp:TextBox>
        </div>
        <br/>
        <div>
            <asp:Button ID="borrowButton" runat="server" Height="44px" style="margin-left: 160px" Text="Borrow" Width="166px" OnClick="borrowButton_Click1" />
        </div>
        <br/>
        <div>
            <asp:Label ID="msgLevel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
