<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountCreation.aspx.cs" Inherits="ATM.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: linear-gradient(to right, #FFD194, #D191FF);">
    <form id="form1" runat="server">
        <h1 style="text-align: center;">Create Account</h1>
        <div style="text-align: center;">
            
            <asp:Label ID="Label1" runat="server" Text="First Name: " Width="172px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="172px"></asp:TextBox>
            
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label2" runat="server" Text="Last Name: " Width="172px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="172px"></asp:TextBox>
        </div>
         <div style="text-align: center;">
     <asp:Label ID="Label3" runat="server" Text="Account Type:" Width="172px"></asp:Label>
     <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="172px">
         <asp:ListItem Text="Select an option" Value=""></asp:ListItem>
         <asp:ListItem Text="Savings" Value="Savings"></asp:ListItem>
         <asp:ListItem Text="Checking" Value="Checking"></asp:ListItem>
         <asp:ListItem Text="Business" Value="Business"></asp:ListItem>
     </asp:DropDownList>
 </div>
        <div style="text-align: center">
            <asp:Label ID="Label4" runat="server" Text="Password: " Width="172px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="172px"></asp:TextBox>
        </div>
        <div style="text-align: center;">
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="244px"> </asp:Button>
        </div>
    </form>
</body>
</html>
