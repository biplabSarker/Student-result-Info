using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Model
{
    public class Batch
    {

        public bool getBatch(string BName, string BRoll, string BTerm)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\StudentResultInfo\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            try
            {
                string CommandeString = "INSERT INTO Batch(BatchName, Term, Roll) values('" + BName + "','" + BTerm + "','" + BRoll + "')";
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
    }
}
