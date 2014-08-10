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
    public partial class AddBatchView : Form
    {
        public AddBatchView()
        {
            InitializeComponent();
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            Batch ObjBatch = new Batch();
            ObjBatch.getBatch(txtAddBatch.Text, txtAddBatchTerm.Text, txtAddBatchRoll1.Text);
        }
    }
}
