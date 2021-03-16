<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientInterf.aspx.cs" Inherits="appDoc.PatientInterf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div style="height: 689px; background-image: url('N.jpg');">
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Nom &amp; Prenom :      "></asp:Label>
            <asp:TextBox ID="Name" runat="server" Width="264px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="sexe :"></asp:Label>
&nbsp;<asp:TextBox ID="sexe" runat="server" Width="338px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="CIN"></asp:Label>
&nbsp;<asp:TextBox ID="cin" runat="server" Width="332px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="AGE  :"></asp:Label>
            <asp:TextBox ID="age" runat="server" Width="336px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="TEl  :"></asp:Label>
            <asp:TextBox ID="Tel" runat="server" Height="22px" Width="345px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp; Id :&nbsp;
            <asp:TextBox ID="Id" runat="server" Height="22px"  Width="348px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Ajoute" runat="server" OnClick="AjouterButt_Click" Text="AJOUTER" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="suppBut" runat="server" OnClick="suppButt_Click" Text="SUPPRIMER" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="modifButt" runat="server" Text="MODIFIER" OnClick="modifButt_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="chercherButt" runat="server" Text="CHERCHER" OnClick="chercherButt_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridPat" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="185px" Width="407px">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
