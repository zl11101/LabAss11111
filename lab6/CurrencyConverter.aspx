<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="lab6.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Convert:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;Chinese yuan to Dollars<p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="  OK  " />
        </p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        Dollars</form>
</body>
</html>
