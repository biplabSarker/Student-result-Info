using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;

namespace View
{
    public partial class DeleteStudentView : Form
    {
        public DeleteStudentView()
        {
            InitializeComponent();
        }


        private void DeleteStudentView_Load(object sender, EventArgs e)
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
            GrdDelView.DataSource=objDataSet.Tables[0];

        }

       

        private void DisplayStudent(string stuCode)
        {
            string Connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\users\\biplab\\documents\\visual studio 2010\\Projects\\StudentResultInfo\\View\\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            string Commandestring = "Select * from Student Where StuName='"+stuCode+"'";
            SqlCommand objCommande = new SqlCommand(Commandestring, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommande);
            objAdapter.Fill(objDataSet);
            String strStudentName = objDataSet.Tables[0].Rows[0][0].ToString();
            String strStudentRoll = objDataSet.Tables[0].Rows[0][1].ToString();
            String strStudentSession = objDataSet.Tables[0].Rows[0][2].ToString();

            txtDelStudentName.Text = strStudentName;
            txtDelStudentRoll.Text = strStudentRoll;
            txtDelStudentSession.Text = strStudentSession;
            objConnection.Close();
        }

        private void GrdDelView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String strSelectedStudent = GrdDelView.Rows[e.RowIndex].Cells[0].Value.ToString();
            DisplayStudent(strSelectedStudent);
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            ClsSqlServer objClsSqlServer = new ClsSqlServer();
            objClsSqlServer.delStudent(txtDelStudentName.Text);
 
        }

    }
}
