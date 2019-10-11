<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonusassignmentpart3.aspx.cs" Inherits="bonusassignment.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Raffle Bundle</h1>
        <div>
            <h2>Number of tickets ordered:</h2>
            <asp:TextBox runat="server" ID ="ticketsordered"></asp:TextBox>
        </div>
        <div>
            <asp:Button runat ="server" Text="Order"/>
        </div>
        <div runat="server" id="summarytickets"></div>
    </form>
</body>
</html>
