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
    public class DepartOper
    {
        SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DocteurDb;Integrated Security=True");

        public DataTable GetAllDepartement()
        {
            DataTable Dtable = new DataTable();
            SqlCommand Com = new SqlCommand();
            Com.Connection = Con;
            Com.CommandText = "select * from TableDepartement";
            Con.Open();
            SqlDataAdapter Dadapter = new SqlDataAdapter(Com);
            Dadapter.Fill(Dtable);
            Con.Close();
            return Dtable;
        }

        public void AddDepartement(Departement newDep)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Insert into TableDepartement ( NomDep,DescriptionDep) values ('" + newDep.NomDep + "' ,'" + newDep.DescriptionDep + "' )";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();
        }
        public Departement GetDepartementByIdAndName(int IDdep, String NomDep)
        {
            Departement D = new Departement();
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            Con.Open();
            com.CommandText = "Select * from TableDepartement where IDdep ='" + IDdep.ToString() + "' and NomDep ='" + NomDep + "'";
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    D.IDdep = int.Parse(reader[0].ToString());
                    D.NomDep = reader[1].ToString();

                    D.DescriptionDep = reader[2].ToString();




                }
            }

            return D;
        }

        public void DeleteDepartement(Departement newDep)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete From TableDepartement where IDdep ='" + newDep.IDdep.ToString() + "'";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();
        }


        public void Updatedep(Departement newDep)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Con;
            com.CommandType = CommandType.Text;
            com.CommandText = "Update TableDepartement SET NomDep='" + newDep.NomDep + "' , DescriptionDep='" + newDep.DescriptionDep + "' where IDdep ='" + newDep.IDdep.ToString() + "' ";
            Con.Open();
            com.ExecuteNonQuery();
            Con.Close();



        }

    }
}
