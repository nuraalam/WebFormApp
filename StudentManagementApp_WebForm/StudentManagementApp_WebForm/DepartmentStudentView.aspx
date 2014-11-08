<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentStudentView.aspx.cs" Inherits="StudentManagementApp_WebForm.DepartmentStudentView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 373px; width: 392px; margin-left: 78px; margin-top: 100px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Department"></asp:Label>
        <asp:DropDownList ID="departmentDropDownList" runat="server" Height="26px" style="margin-left: 46px; margin-top: 0px;" Width="185px">
        </asp:DropDownList>
    
    </div>
    <div>
        <asp:Button ID="showButton" runat="server" style="margin-left: 187px" Text="Show" Width="114px" OnClick="showButton_Click" />
        </div>
        <br/>
    <div>
        <asp:Label ID="Label2" runat="server" Text="RegNo"></asp:Label>        
        <asp:DropDownList ID="regNoDropDownList" runat="server" Height="26px" style="margin-left: 74px" Width="185px" AutoPostBack="true" EnableViewState="true" OnSelectedIndexChanged="regNoDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        <br/>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" style="margin-left: 81px" Width="172px"></asp:TextBox>
        </div>
        <br/>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" style="margin-left: 83px" Width="170px"></asp:TextBox>
        </div>
        <br/>
    <div>
        <asp:Label ID="msgLevel" runat="server"></asp:Label>
        </div>
    </form>
    </body>
</html>
