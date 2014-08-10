using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace View
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            AddStudentView objAddStudentView = new AddStudentView();
            objAddStudentView.Show();
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            ClsSqlServer objClsSqlServer = new ClsSqlServer();
            DataSet objDataSet = objClsSqlServer.getStudent();
           dataGridView1.DataSource=objDataSet.Tables[0];

        }

        

        private void StudentView_Load(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\StudentResultInfo\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select * from Student";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);
            objConnection.Close();
            dataGridView1.DataSource=objDataSet.Tables[0];
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            DeleteStudentView objDeleteStudentView = new DeleteStudentView();
            objDeleteStudentView.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
