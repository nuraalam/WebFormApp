<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEntryWebUI.aspx.cs" Inherits="ManytoManyWeb.DepartmentEntryWebUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 107px; margin-top: 68px">
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label1" runat="server" Text="Code" Width="100px"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server" style="margin-left: 40px" Width="358px"></asp:TextBox>
    
    </div>
        <br/>
         <div>    
        <asp:Label ID="Label2" runat="server" Text="Name" Width="100px"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" style="margin-left: 40px" Width="358px"></asp:TextBox>
    
    </div>
        <br/>
        <div>
            <asp:Button ID="saveButton" runat="server" Height="50px" style="margin-left: 245px" Text="Save" Width="260px" />
        </div>
    </form>
</body>
</html>
