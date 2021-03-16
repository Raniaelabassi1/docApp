using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryEntity.models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Runtime.Remoting.Messaging;
using ClassLibraryEntity;

namespace ClassLibraryO
{
    public class PatientOper
    {
        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DocteurDb;Integrated Security=True");

        public DataTable GetAllPatient()
        {
            DataTable Dtable = new DataTable();
            SqlCommand Com = new SqlCommand();
            Com.Connection = Con;
            Com.CommandText = "select * from TablePatient";
            Con.Open();
            SqlDataAdapter Dadapter = new SqlDataAdapter(Com);
            Dadapter.Fill(Dtable);
            Con.Close();
            return Dtable;
        }

        public Patient GetPatientByIdAndName(int IDpatient, String NomPatient)
        {
            Patient P = new Patient();
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            Con.Open();
            com.CommandText = "Select * from TablePatient where IDpatient ='" + IDpatient.ToString() + "' and NomPatient ='" + NomPatient + "'";
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    P.IDpatient = int.Parse(reader[0].ToString());
                    P.NomPatient = reader[1].ToString();

                    P.sexe = reader[2].ToString();
                    P.CIN = reader[3].ToString();

                    P.agePatient = int.Parse(reader[4].ToString());
                    P.TelPatient = int.Parse(reader[5].ToString());



                }
            }

            return P;
        }


        public void AddPatient(Patient newPat)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Insert into TablePatient ( NomPatient,sexe,CIN,agePatient,TelPatient) values ('" + newPat.NomPatient + "' ,'" + newPat.sexe + "' ,'" + newPat.CIN + "' ,'" + newPat.agePatient + "' ,'" + newPat.TelPatient + "')";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();
        }

        public void DeletePatient(Patient newPat)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete From TablePatient where IDpatient ='" + newPat.IDpatient.ToString() + "'";
           Con.Open();
            com.ExecuteNonQuery();
            Con.Close();


        }

        public void updatePatient(Patient newPat)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Update TablePatient SET NomPatient ='" + newPat.NomPatient + "'  , sexe'" + newPat.sexe + "' , CIN= '" + newPat.CIN + "' AND agePatient='" + newPat.agePatient + "' , TelPatient='" + newPat.TelPatient + "' where IDpatient ='" + newPat.IDpatient.ToString() + "' ";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();

        }





    }
}
