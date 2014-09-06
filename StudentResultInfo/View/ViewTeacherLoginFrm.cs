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
    public partial class ViewTeacherLoginFrm : Form
    {
        public ViewTeacherLoginFrm()
        {
            InitializeComponent();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            Validity objValidity = new Validity();
            objValidity.UserName = txtUserName.Text;
            objValidity.PassWard = txtPassward.Text;
            if(objValidity.isValid()){
            ViewManuform obj = new ViewManuform();
            obj.Show();
            this.Hide();
            }
            else{
                MessageBox.Show("Invalid User Name or Passward ");
            }
        }

        
    }
}
