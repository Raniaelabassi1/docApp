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
    public partial class DocINTERFACE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoctOper Doc = new DoctOper();
            GridDocteur.DataSource = Doc.GetAllDocteur();
            GridDocteur.DataBind();

        }

        protected void AjouterButt_Click(object sender, EventArgs e)
        {
            Docteur NewDoc = new Docteur();
            DoctOper Doc = new DoctOper();

            NewDoc.NomDoc = NomDocteur.Text;
            NewDoc.Specialité = specialité.Text;
            NewDoc.TelDoc =  Int32.Parse(TelDoc.Text);
            Doc.AddDocteur(NewDoc);
        }
        protected void chercherButt_Click(object sender, EventArgs e)
        {

            DoctOper Doc = new DoctOper();
            String nom = NomDocteur.Text;
            int id = int.Parse(IDdocteur.Text);
            Doc.GetDoctorByIdAndName(id, nom);

        }

        protected void suppButt_Click(object sender, EventArgs e)
        {
            Docteur NewDoc = new Docteur();
            DoctOper Doc = new DoctOper();
            NewDoc.IDdoc = int.Parse(IDdocteur.Text);
            NewDoc.NomDoc = NomDocteur.Text;
            NewDoc.Specialité = specialité.Text;
            NewDoc.TelDoc = int.Parse(TelDoc.Text);
            Doc.DeleteDocteur(NewDoc);
        }

        protected void modifButt_Click(object sender, EventArgs e)
        {
            Docteur NewDoc = new Docteur();
            DoctOper Doc = new DoctOper();
            NewDoc.IDdoc = int.Parse(IDdocteur.Text);
            NewDoc.NomDoc = NomDocteur.Text;
            NewDoc.Specialité = specialité.Text;
            NewDoc.TelDoc = int.Parse(TelDoc.Text);
            Doc.update(NewDoc);


        }
    }
}