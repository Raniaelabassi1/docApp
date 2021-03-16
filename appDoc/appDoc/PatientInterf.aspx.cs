using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Permissions;
using System.Runtime.Remoting.Messaging;
using ClassLibraryEntity.models;
using ClassLibraryEntity;
using ClassLibraryO;


namespace appDoc
{
    public partial class PatientInterf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PatientOper Doc = new PatientOper();
            GridPat.DataSource = Doc.GetAllPatient();
            GridPat.DataBind();

        }

        protected void AjouterButt_Click(object sender, EventArgs e)
        {
            PatientOper Doc = new PatientOper();
            Patient P = new Patient();
            P.NomPatient = Name.Text;
            P.agePatient = int.Parse(age.Text);
            P.CIN =cin.Text;
            P.sexe =sexe.Text;
            P.TelPatient = int.Parse(Tel.Text);
            Doc.AddPatient(P);
       

    }

        protected void suppButt_Click(object sender, EventArgs e)
        {
            PatientOper Doc = new PatientOper();
            Patient P = new Patient();
            P.NomPatient = Name.Text;
            P.agePatient = int.Parse(age.Text);
            P.CIN = cin.Text;
            P.sexe = sexe.Text;
            P.TelPatient = int.Parse(Tel.Text);
            P.IDpatient= int.Parse(Id.Text);
            Doc.DeletePatient(P);

        }

        protected void modifButt_Click(object sender, EventArgs e)
        {
            PatientOper Doc = new PatientOper();
            Patient P = new Patient();
            P.NomPatient = Name.Text;
            P.agePatient = int.Parse(age.ToString());
            P.CIN = cin.Text;
            P.sexe = sexe.Text;
            P.TelPatient = int.Parse(Tel.Text);
            P.IDpatient = int.Parse(Id.Text);
            Doc.updatePatient(P);

        }

        protected void chercherButt_Click(object sender, EventArgs e)
        {
            PatientOper Doc = new PatientOper();
          

            int id = int.Parse(Id.Text);
            String nom = Name.Text;
            Doc.GetPatientByIdAndName(id , nom);


        }

       
    }
}