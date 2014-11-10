<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWebUI.aspx.cs" Inherits="ManytoManyWeb.MainWebUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 196px; width: 601px; margin-left: 141px; margin-top: 55px">
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="studentEntryButton" runat="server" Text="Student Entry" Height="92px" Width="244px" OnClick="studentEntryButton_Click" />
        </div>
        <br/>
    <div>
        <asp:Button ID="courseEntryButton" runat="server" Text="Course Entry" Height="92px" Width="244px" OnClick="courseEntryButton_Click" />
        </div>
        <br/>
    <div>
        <asp:Button ID="enrollmentButton" runat="server" Text="Enrollment" Height="92px" Width="244px" OnClick="enrollmentButton_Click" />
        </div>
    </form>
    </body>
</html>
