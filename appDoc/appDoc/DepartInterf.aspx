<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartInterf.aspx.cs" Inherits="appDoc.DepartInterf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div style="height: 689px; background-image: url('V.jpg');">
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="IDdepartement :      "></asp:Label>
            <asp:TextBox ID="IDdepartement" runat="server" Width="294px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="NomDepartement :"></asp:Label>
&nbsp;<asp:TextBox ID="NomDepartement" runat="server" Width="294px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
&nbsp;<asp:TextBox ID="Description" runat="server" Width="372px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
           
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="AjouterButt" runat="server" OnClick="AjouterButt_Click" Text="AJOUTER" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="suppButt" runat="server" OnClick="suppButt_Click" Text="SUPPRIMER" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="modifButt" runat="server" Text="MODIFIER" OnClick="modifButt_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="chercherButt" runat="server" Text="CHERCHER" OnClick="chercherButt_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            
         
            <asp:GridView ID="GridDep" runat="server" Width="350px">
            </asp:GridView>
            
         
        </div>
    </form>
</body>
</html>
