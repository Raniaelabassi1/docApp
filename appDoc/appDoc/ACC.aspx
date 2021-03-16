<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ACC.aspx.cs" Inherits="appDoc.ACC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <form id="form1" runat="server">
        <div style="background-image: url('L.jpg'); height: 669px; width: 100%;">
             <nav class="navbar navbar-expand-lg navbar-light bg-light">
  
    <a class="navbar-brand" href="#">MEDICAL CENTER</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation" data-target="#ACC">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" href="ACC.aspx">Accueil</a>
        </li>
        
      </ul>
         <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active"  href="PatientInterf.aspx">Patient</a></li>
        
      </ul>
       <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active"  href="DocINTERFACE.aspx">Docteur</a>
        </li>
        
      </ul>
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active"  href="DepartInterf.aspx">Departement</a>
        </li>
        
        
      </ul>
      
     </div>
</nav>
        </div>
    </form>
</body>
</html>
