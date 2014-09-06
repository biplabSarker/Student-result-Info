using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace View
{
    public partial class ViewAddEnrolment : Form
    {
        public ViewAddEnrolment()
        {
            InitializeComponent();
            fillComboStudentId();
            fillcomboCourseId();

        }

        void fillComboStudentId()
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select StuId from Student";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(Commandestring,objConnection);
            try
            {
                DataSet objDataset = new DataSet();
                objDataAdapter.Fill(objDataset, "Student");
                cmbStudentId.ValueMember = "StuId";
                cmbStudentId.DataSource = objDataset.Tables["Student"];
            }
            catch
            {
                objConnection.Close();
            }
            cmbCourseTitle.Text = "";
        }
        void fillcomboCourseId()
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\Software Engineering Project\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select CourseTitle from Course";
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(Commandestring, objConnection);
            try
            {
                DataSet objDataset = new DataSet();
                objDataAdapter.Fill(objDataset, "Course");
                cmbCourseTitle.DisplayMember = "CourseTitle";
                cmbCourseTitle.DataSource = objDataset.Tables["Course"];
            }
            catch
            {
                objConnection.Close();
            }
            cmbStudentId.Text = "";
        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {
            Enrolment objEnrolment = new Enrolment();
            objEnrolment.getEnrolCourse(cmbStudentId.Text,cmbCourseTitle.Text);
            cmbCourseTitle.Text = "";
            cmbStudentId.Text = "";
        }

        private void ViewAddEnrolment_Load(object sender, EventArgs e)
        {

        }
       
    }
}
