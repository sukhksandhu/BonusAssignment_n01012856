<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonusassignmentpart2.aspx.cs" Inherits="bonusassignment.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weekly Work/Study Schedule</h1>
        </div>
        <div>
            <h2>Select Your work days from the menu</h2>
           <asp:CheckBoxList runat="server" ID="workdays_selection">
               <asp:ListItem Value="mon">Monday</asp:ListItem>
               <asp:ListItem Value="tues">Tuesday</asp:ListItem>
               <asp:ListItem Value="wed">Wednesday</asp:ListItem>
               <asp:ListItem Value="thurs">Thursday</asp:ListItem>
               <asp:ListItem Value="fri">Friday</asp:ListItem>
               <asp:ListItem Value="sat">Saturday</asp:ListItem>
               <asp:ListItem Value="sun">Sunday</asp:ListItem>
            </asp:CheckBoxList>
    
        </div>
        <div runat="server" id="workdaysummary"></div>
        <asp:Button runat="server" text="Submit"/>
    </form>
</body>
</html>
