using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryEntity.models
{
    [Table("TableDocteur")]
    public class Docteur
    {
        [Key]
        
        public Int32 IDdoc { get; set; }

       
        public String NomDoc { get; set; }
        public String Specialité { get; set; }

        public Int32 TelDoc { get; set; }

       
        public Docteur() { }
    }
}
