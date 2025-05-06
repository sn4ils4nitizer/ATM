<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="ATM.AccountDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: linear-gradient(to right, #FFD194, #D191FF);">
    <form id="form1" runat="server">
        <h1 style="text-align: center;">Account Details</h1>
        <div style="text-align: center;"> 
            <asp:Label ID="Label4" runat="server" Text="Account Number: " Width="172px"></asp:Label>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label3" runat="server" Text="Account Type: " Width="172px"></asp:Label>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label1" runat="server" Text="First Name: " Width="172px"></asp:Label>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label2" runat="server" Text="Last Name: " Width="172px"></asp:Label>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Label5" runat="server" Text="Balance: " Width="172px" BackColor="SteelBlue"></asp:Label>
            <asp:Label ID="ActualBalance" runat="server" Text="" Width="172px" BackColor="LightBlue"></asp:Label>
        </div>
        <div style="text-align: center;">
            <asp:Button ID="Deposit" runat="server" OnClick="Deposit_Click" Text="Deposit" Width="172px"/>
        </div>
        <div style="text-align: center;">
            <asp:Button ID="Withdrawal" runat="server" OnClick="Withdrawal_Click" Text="Withdrawal" Width="172px"/>
        </div>
        <div style="text-align: center;">
            <asp:Label ID="Interest" runat="server" Text=""></asp:Label>
        </div>
        <div style="text-align: center;">
            <br />
            <br />
            <asp:Button ID="Logout" runat="server" OnClick="Logout_Click" Text="Logout" Width="172px"/>
        </div>
    </form>
</body>
</html>
