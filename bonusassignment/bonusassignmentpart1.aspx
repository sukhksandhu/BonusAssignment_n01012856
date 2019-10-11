<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonusassignmentpart1.aspx.cs" Inherits="bonusassignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Enter x and y values to determine the quadrant</h1>
        <div>
            <h2>Enter first input x:</h2>
            <asp:TextBox runat="server" ID="quadrantfirstinput"></asp:TextBox>
            <asp:CustomValidator runat="server" ControlToValidate="quadrantfirstinput" 
                ErrorMessage="Please enter valid input (non-zero)" OnServerValidate="quadrantvalidate"></asp:CustomValidator>

            <h2>Enter second input y:</h2>
            <asp:TextBox runat="server" ID="quadrantsecondinput"></asp:TextBox>
            <asp:CustomValidator runat="server" ControlToValidate="quadrantsecondinput" ErrorMessage="Please enter valid input (non-zero)" OnServerValidate="quadrantvalidate"></asp:CustomValidator>
        </div>
        <div id="quadrantsummary" runat="server"></div>
        <asp:button runat="server" Text="Submit"/>
    </form>
</body>
</html>
