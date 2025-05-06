<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepositScreen.aspx.cs" Inherits="ATM.DepositScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: linear-gradient(to right, #FFD194, #D191FF);">
    <form id="form1" runat="server">
        <div style="text-align: center;">
            <h1>Deposit</h1>
            <asp:Label ID="lblDepositAmount" runat="server" Text="Enter Deposit Amount:" />
            <asp:TextBox ID="txtDepositAmount" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <bt />
            <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
