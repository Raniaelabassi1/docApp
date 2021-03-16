using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ClassLibraryEntity.models
{
    [Table("TableDepartement")]
    public class Departement
    {
        [Key]
        public Int32 IDdep { get; set; }

        public String NomDep { get; set; }
        public String DescriptionDep { get; set; }


        [ForeignKey("Docteur")]
        public Int32 IdDoc { get; set; }

        public virtual ICollection<Docteur> Docteurs { get; set; }

        public virtual Docteur Docteur { get; set; }
       

        public Departement() { }
    }
}
