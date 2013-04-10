<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OldDefault.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager EnablePartialRendering="true" ID="objScriptManager" runat="server">
    </asp:ScriptManager>
    <div id="lblDiv">
    <asp:UpdatePanel runat="server">
    <ContentTemplate>
    <object id="HelpdeskKPIControl1" 
classid="http:HelpdeskKPIControl.dll#HelpdeskKPIControl.Dashboard" 
height="768" width="1024"  VIEWASTEXT>    
        <PARAM NAME="InVandaag" ID="objInVandaag" runat="server" VALUE="0" />
        <PARAM NAME="UitVandaag" ID="objUitVandaag" runat="server" VALUE="0" />
        <PARAM NAME="InWeek" ID="objInWeek" runat="server" VALUE="0" />
        <PARAM NAME="UitWeek" ID="objUitWeek" runat="server" VALUE="0" />
        <PARAM NAME="InMaand" ID="objInMaand" runat="server" VALUE="0" />
        <PARAM NAME="UitMaand" ID="objUitMaand" runat="server" VALUE="0" />
    </object>  
    </ContentTemplate>
    </asp:UpdatePanel>

    </div>  
    </form>

</body>
</html>
