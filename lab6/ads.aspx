<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ads.aspx.cs" Inherits="lab6.ads" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto=style2">
        Ads 1
            <br />
            <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/App_Data/AdsListXMLFile.xml" KeywordFilter="ba1" />
            <br />
        </div>
        <div>
            <h2>This is my advertisement page</h2>
        </div>
        <div class="auto=style1">
            Ads 2
        </div>
        <p>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/App_Data/AdsListXMLFile.xml" KeywordFilter="ads2" />
        </p>
    </form>
        </body>
</html>
