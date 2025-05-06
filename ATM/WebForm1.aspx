
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ATM.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: linear-gradient(to right, #FFD194, #D191FF);">
    <form id="form1" runat="server">
        <h1 style="text-align: center;">Welcome to the ATM</h1>
        <div style="text-align: center;">
            <asp:Label ID="Label1" runat="server" Text="Username:" Width="172px" style="margin-left: 172px"></asp:Label>
            <asp:TextBox ID="UserName" runat="server" Width="172px" placeholder="Username" />
            <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red" Width="172px"></asp:Label>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label2" runat="server" Text="Password: " Width="172px" ></asp:Label>
            <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="172px" placeholder="Password" />
        <div style="text-align: center;">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="172px" style="margin-left: 172px"/>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label3" runat="server" Text="Don't have an account?" Width="172px" style="color: red"></asp:Label>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create Account" Width="172px"/>
        </div>
    </form>
</body>
</html>
