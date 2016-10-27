<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="State.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="labelPage" runat="server" Text="Page 0" />
        <br />
        <br />
        <asp:Button runat="server" ID="buttonPrevious" Text="Previous" OnClick="buttonPrevious_Click" Visible="false"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" ID="buttonNext" Text="Next" OnClick="buttonNext_Click" />
    </form>
</body>
</html>
