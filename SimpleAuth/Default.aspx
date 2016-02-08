<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleAuth.Default" %>

<html>
<head>
  <title>Forms Authentication - Default Page</title>
</head>


<body>
  <h3>
    Todo fue un exito, Enel.</h3>
  <asp:Label ID="Welcome" runat="server" />
  <form id="Form1" runat="server">
    <asp:Button ID="Submit1" OnClick="Signout_Click" 
       Text="Desconectar" runat="server" /><p>
  </form>
</body>
</html>