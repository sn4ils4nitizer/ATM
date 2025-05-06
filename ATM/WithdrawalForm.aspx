<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WithdrawalForm.aspx.cs" Inherits="ATM.WithdrawalForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head> 
<body style="background: linear-gradient(to right, #FFD194, #D191FF);">
    <form id="form1" runat="server">
        <div style="text-align: center;">
            <h1>Withdrawal</h1>
            <asp:Label ID="lblWithdrawalAmount" runat="server" Text="Enter Withdrawal Amount:" />
            <asp:TextBox ID="txtWithdrawalAmount" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
