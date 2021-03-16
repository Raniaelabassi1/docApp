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
using System.Configuration;

namespace ClassLibraryO
{
    public class DoctOper
    {
        
        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DocteurDb;Integrated Security=True");
        public DataTable GetAllDocteur()
        {
            DataTable Dtable = new DataTable();
            SqlCommand Com = new SqlCommand();
            Com.Connection = Con;
            Com.CommandText = "select * from TableDocteur";
            Con.Open();
            SqlDataAdapter Dadapter = new SqlDataAdapter(Com);
            Dadapter.Fill(Dtable);
            Con.Close();
            return Dtable;
        }

        public Docteur GetDoctorByIdAndName(int IdDoc, String DocName)
        {
            Docteur Doc = new Docteur();
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            Con.Open();
            com.CommandText = "Select * from TableDocteur where IDdoc ='" + IdDoc.ToString() + "' and NomDoc ='" + DocName + "'";
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Doc.IDdoc = int.Parse(reader[0].ToString());
                    Doc.NomDoc = reader[1].ToString();

                    Doc.Specialité = reader[2].ToString();
                    Doc.TelDoc = int.Parse(reader[3].ToString());

                }
            }

            return Doc;
        }

        public void AddDocteur(Docteur newDoc)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Insert into TableDocteur (NomDoc,Specialité,TelDoc) values ('" + newDoc.NomDoc + "' ,'" + newDoc.Specialité + "' ,'" + newDoc.TelDoc + "')";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();
        }

        public void DeleteDocteur(Docteur newDoc)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete From TableDocteur where IDdoc ='" + newDoc.IDdoc.ToString() + "'";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();
        }

        public void update(Docteur newDoc)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Update TableDocteur SET  NomDoc ='" + newDoc.NomDoc + "' , Specialité ='" + newDoc.Specialité + "' , TelDoc ='" + newDoc.TelDoc + "'  where IDdoc ='" + newDoc.IDdoc.ToString() + "'  ";
           Con.Open();
            com.ExecuteNonQuery();
            Con.Close();


        }

    }

}

