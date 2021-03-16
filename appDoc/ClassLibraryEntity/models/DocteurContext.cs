using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClassLibraryEntity.models
{
    class DocteurContext : DbContext
    {
        public DocteurContext() : base("DocteurDb")
        {

        }
       
       
        public DbSet<Docteur> DocteurSet { get; set; }
        public DbSet<Departement> DepartementSet { get; set; }
        public DbSet<Patient> PatientSet { get; set; }

    }
}
