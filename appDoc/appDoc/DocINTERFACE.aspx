<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocINTERFACE.aspx.cs" Inherits="appDoc.DocINTERFACE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
               <div style="height: 689px; background-image: url('M.jpg');">
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="IDdocteur :      "></asp:Label>
            <asp:TextBox ID="IDdocteur" runat="server" Width="294px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="NomDocteur :"></asp:Label>
&nbsp;<asp:TextBox ID="NomDocteur" runat="server" Width="294px"></asp:TextBox>
                    <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="specialité :"></asp:Label>
&nbsp;<asp:TextBox ID="specialité" runat="server" Width="294px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="TelDoc"></asp:Label>
&nbsp;<asp:TextBox ID="TelDoc" runat="server" Width="372px"></asp:TextBox>
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
            
         
            <asp:GridView ID="GridDocteur" runat="server" Width="350px">
            </asp:GridView>
            
         
        </div>
        </div>
        </div>
    </form>
</body>
</html>
