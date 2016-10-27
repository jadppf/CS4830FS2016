<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="QueryString.aspx.cs" 
    Inherits="State.QueryString" 
    ValidateRequest="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="labelState" runat="server" Text="Page 0" />
        <br />
        <br />
        <asp:HyperLink ID="buttonPrevious" Text="Previous" Visible="false" runat="server" />
        &nbsp; &nbsp; &nbsp;
        <asp:HyperLink ID="buttonNext" Text="Next" runat="server" />
    </form>
</body>
</html>
