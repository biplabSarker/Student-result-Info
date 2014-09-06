using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Model
{
   public class LoginUser
    {
        public DataSet getUser(string UserName, string Passward)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select * from Login where UserName='"+UserName+"' and Passward='"+Passward+"'";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);

            objConnection.Close();
            return objDataSet;
        }
    }
}
