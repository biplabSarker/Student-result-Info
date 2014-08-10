using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using View;

namespace Controller
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentView objStudentView = new StudentView();
            objStudentView.Show();
        }

        private void addBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBatchView objAddBatchView = new AddBatchView();
            objAddBatchView.Show();
        }
    }
}
