<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionHijacking.aspx.cs" Inherits="SessionHijackingPreventionAspNet.SessionHijacking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

      
    <asp:Label ID="lblAdmin" Visible="false"  runat="server" >Show user the whole website</asp:Label>

        &nbsp;<br />
        <br />

        <asp:Button ID="btnAdmin" runat="server" Text="Admin" OnClick="btnAdmin_Click"/>
    </div>
    </form>
</body>
</html>
