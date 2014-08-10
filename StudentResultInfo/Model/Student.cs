using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Model
{
    public class ClsSqlServer
    {
        public DataSet getStudent()
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\StudentResultInfo\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
                string Commandestring = "Select * from Student";
                SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
                DataSet objDataSet=new DataSet();
                SqlDataAdapter objAdapter=new SqlDataAdapter(objCommande);
                 objAdapter.Fill(objDataSet);   
           
                objConnection.Close();
                return objDataSet;
            
        }


        public bool getStudent(string SName, string SRoll, string SSession)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\StudentResultInfo\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            try
            {
                string CommandeString = "INSERT INTO Student(StuName, StuRoll, StuSession) values('" + SName + "','"+ SRoll + "','" + SSession + "')";
                SqlCommand objCommande = new SqlCommand(CommandeString, objConnection);
                objCommande.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                objConnection.Close();
            }
        }
        public bool delStudent(string SName)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\StudentResultInfo\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "delete from Student Where StuName='"+SName+"'";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            objCommande.ExecuteNonQuery();

            objConnection.Close();
            return true;
            

        }



    }

}
