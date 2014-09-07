using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Model
{
    public class Result
    {

        public bool getResult(string StudentId, string StudentName, string Term,string Gpa)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            try
            {
                string CommandeString = "INSERT INTO Result(StuId, StuName,Term,Gpa) values('" + StudentId + "','" + StudentName + "','"+Term+"','"+Gpa+"')";
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

        public DataSet showResult()
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select * from Result Order By StuId";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);

            objConnection.Close();
            return objDataSet;

        }

        public DataSet showResult(string s)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select * from Result where StuId='"+s+"'";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);

            objConnection.Close();
            return objDataSet;

        }


    }
}
