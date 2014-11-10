<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryWebUI.aspx.cs" Inherits="ManytoManyWeb.StudentEntryWebUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 107px; margin-left: 107px; margin-top: 71px;">
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label1" runat="server" Text="RegNo" Width="100px"></asp:Label>
        <asp:TextBox ID="regNoTextBox" runat="server" style="margin-left: 40px" Width="358px"></asp:TextBox>
    
    </div>
        <br/>
         <div>    
        <asp:Label ID="Label2" runat="server" Text="Name" Width="100px"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" style="margin-left: 40px" Width="358px"></asp:TextBox>
    
    </div>
        <br/>
         <div>    
        <asp:Label ID="Label3" runat="server" Text="Email" Width="100px"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" style="margin-left: 40px" Width="358px"></asp:TextBox>
    
    </div>
        <br/>
        <div>
            <asp:Button ID="saveButton" runat="server" Height="50px" style="margin-left: 245px" Text="Save" Width="260px" OnClick="saveButton_Click" />
        </div>
        <br/>
        <div>
            <asp:Button ID="goToMainUiButton" runat="server" Height="50px" style="margin-left: 245px" Text="Go To Main UI" Width="260px" OnClick="goToMainUiButton_Click1" />
        </div>
    </form>
</body>
</html>
