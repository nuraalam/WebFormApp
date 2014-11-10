<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enrollment.aspx.cs" Inherits="ManytoManyWeb.Enrollment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 119px; margin-top: 91px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Student RegNo" Width="150px"></asp:Label>
            <asp:DropDownList ID="studentRegNoDropDownList" runat="server" Width="308px">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Department" Width="150px"></asp:Label>
            <asp:DropDownList ID="departmentDropDownList" runat="server" Width="308px">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Enrollment Date"></asp:Label>
        </div>
        <div>
            <asp:Calendar ID="EnroollmentDateCalender" runat="server" Style="margin-left: 200px"></asp:Calendar>
        </div>
        <br />
        <div>
            <asp:Button ID="saveButton" runat="server" Height="50px" Style="margin-left: 245px" Text="Save" Width="213px" OnClick="saveButton_Click" />
        </div>
    </form>
</body>
</html>
