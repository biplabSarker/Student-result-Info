using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Model;

namespace View
{
    public partial class ViewEnrolmentByCourse : Form
    {
        public ViewEnrolmentByCourse()
        {
            InitializeComponent();
        }

        private void ViewEnrolmentByCourse_Load(object sender, EventArgs e)
        {
            Enrolment objEnrolment = new Enrolment();
            DataSet objDataset = objEnrolment.showEnrolByCourse();
            dataGridView1.DataSource = objDataset.Tables[0];
            
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
