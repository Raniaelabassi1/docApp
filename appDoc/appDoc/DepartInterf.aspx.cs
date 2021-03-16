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
    public partial class DepartInterf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartOper Doc = new DepartOper();
            GridDep.DataSource = Doc.GetAllDepartement();
            GridDep.DataBind();

        }

        protected void AjouterButt_Click(object sender, EventArgs e)
        {
            DepartOper Doc = new DepartOper();
            Departement newD = new Departement();
            newD.DescriptionDep =Description.Text;
            newD.NomDep =NomDepartement.Text;
            Doc.AddDepartement(newD);



        }

        protected void suppButt_Click(object sender, EventArgs e)
        {
            DepartOper Doc = new DepartOper();
            Departement newD = new Departement();
            newD.DescriptionDep = Description.Text;
            newD.NomDep = NomDepartement.Text;
            newD.IDdep=int.Parse(IDdepartement.Text);
            Doc.DeleteDepartement(newD);


        }

        protected void modifButt_Click(object sender, EventArgs e)
        {
            DepartOper Doc = new DepartOper();
            Departement newD = new Departement();
            newD.DescriptionDep = Description.Text;
            newD.NomDep = NomDepartement.Text;
            newD.IDdep = int.Parse(IDdepartement.Text);
            Doc.Updatedep(newD);

        }

        protected void chercherButt_Click(object sender, EventArgs e)
        {
            DepartOper Doc = new DepartOper();
            String nom = NomDepartement.Text;
            int id = int.Parse(IDdepartement.Text);
            Doc.GetDepartementByIdAndName(id,nom);

        }
    }
}