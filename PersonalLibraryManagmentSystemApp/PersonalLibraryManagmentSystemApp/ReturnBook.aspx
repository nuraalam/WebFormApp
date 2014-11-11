<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="PersonalLibraryManagmentSystemApp.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 108px; margin-top: 80px">
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Member No" Width="120px"></asp:Label>
            <asp:TextBox ID="enterMemberNoTextBox" runat="server" Style="margin-left: 38px" Width="160px" Height="35px"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="showBorrowedBookButton" runat="server" Height="44px" Style="margin-left: 160px" Text="Show Borrowed Books" Width="166px" OnClick="showBorrowedBookButton_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Borrowed Booklist" Width="150px"></asp:Label>
            <asp:DropDownList ID="borrowedBooklistDropDownList" runat="server" Style="margin-left: 6px; margin-right: 80px" Width="180px" AutoPostBack="True" Height="40px">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="returnButton" runat="server" Height="44px" Style="margin-left: 160px" Text="Return" Width="166px" OnClick="returnButton_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="msgLevel" runat="server"></asp:Label>
        </div>

        <br />
        <br />

    </form>
</body>
</html>
