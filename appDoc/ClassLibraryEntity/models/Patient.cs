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

    [Table("TablePatient")]
    public class Patient
    {
        [Key]
        public Int32 IDpatient { get; set; }

        public String NomPatient { get; set; }

        public String sexe { get; set; }
        public String CIN { get; set; }
        public Int32 agePatient { get; set; }

        public Int32 TelPatient { get; set; }

       
        [ForeignKey("Docteur")] 
        public Int32 IdDoc { get; set; }

        public virtual ICollection<Docteur> Docteurs { get; set; }
        public virtual Docteur Docteur { get; set; }
       

        public Patient() { }
    }
}
