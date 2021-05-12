<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Redirecting...</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
           <center><asp:Label ID="Label1" runat="server" Text="Redirecting..."></asp:Label></center> 
        </p>
    </form>
    <script> 
<!-- Change the URL to yours//-->
        window.location.replace('https://www.yourpage.com'); 

    </script>
</body>
</html>
