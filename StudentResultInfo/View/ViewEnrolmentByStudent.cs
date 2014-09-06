using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class ViewEnrolmentByStudent : Form
    {
        public ViewEnrolmentByStudent()
        {
            InitializeComponent();
        }

        private void ViewEnrolmentByStudent_Load(object sender, EventArgs e)
        {
            Enrolment objEnrolment = new Enrolment();
            DataSet objDataset = objEnrolment.showEnrolByStudent();
            dataGridView1.DataSource = objDataset.Tables[0];
        }
    }
}
