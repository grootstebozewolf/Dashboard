<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelpdeskKPIWebApplication._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <object id="HelpdeskKPIControl1" height="768" width="588"
            classid="http:AGaugeApp.dll#AGaugeApp.Dashboard"> 
            <param name="InVandaag" value="3"/>   
            <param name="UitVandaag" value="3"/>  
            <param name="InWeek" value="75"/>  
            <param name="UitWeek" value="80"/>  
            <param name="Totaal" value="269"/>  
         </object>  
         </center>
    </div>
    </form>
</body>
</html>
