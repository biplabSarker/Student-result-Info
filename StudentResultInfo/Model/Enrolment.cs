using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Enrolment
    {
        public bool getEnrolCourse(string StudentId, string CourseTitle)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            try
            {
                string CommandeString = "INSERT INTO Enrolment(StuId, CourseTitle) values('" + StudentId + "','" + CourseTitle +"')";
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

        public DataSet showEnrolByCourse()
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select Student.StuId, Student.StuName, Enrolment.CourseTitle, Course.CourseName From Student Inner Join Enrolment On Student.StuId=Enrolment.StuId Inner Join Course On Course.CourseTitle=Enrolment.CourseTitle  Order By Enrolment.CourseTitle ";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);

            objConnection.Close();
            return objDataSet;

        }

        public DataSet showEnrolByStudent()
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select Student.StuId, Student.StuName, Enrolment.CourseTitle, Course.CourseName From Student Inner Join Enrolment On Student.StuId=Enrolment.StuId Inner Join Course On Course.CourseTitle=Enrolment.CourseTitle  Order By Student.StuId ";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);

            objConnection.Close();
            return objDataSet;

        }


    }
}
