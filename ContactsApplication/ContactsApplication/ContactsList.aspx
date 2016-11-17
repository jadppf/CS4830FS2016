<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactsList.aspx.cs" Inherits="ContactsApplication.ContactsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    <div id="divContactsList" runat="server" visible="true">
    <h2>Contacts</h2>
    <asp:ListBox ID="listContacts" runat="server" Height="168px" Width="490px" />
    <br />
    <br />
    <asp:Button ID="buttonDeleteContact" Text="Delete selected contact" runat="server" OnClick="buttonDeleteContact_Click" /><br />
    <asp:Button ID="buttonAddContacts" Text="Add a new contacts" runat="server" OnClick="buttonAddContacts_Click" />
    </div>
    <div id="divAddContact" runat="server" visible="false">
        First Name: <asp:TextBox ID="textFirstName" runat="server" /> <br />
        Last Name: <asp:TextBox ID="textLastName" runat="server" /> <br />
        Phone: <asp:TextBox ID="textPhone" runat="server" /> <br />
        Email: <asp:TextBox ID="textEmail" runat="server" /> <br />
        <br />
        <asp:Button ID="buttonDoAdd" runat="server" Text="Add the new contact" OnClick="buttonDoAdd_Click" />
    </div>
    </center>
    </form>
</body>
</html>
