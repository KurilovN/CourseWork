using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void bAdmin_Click(object sender, EventArgs e)
        {
            AdminForm aFrm = new AdminForm();
            DialogResult dgr = aFrm.ShowDialog();
            if (dgr == DialogResult.OK)
            {
                AdminDBForm aDBFrm = new AdminDBForm();
                aDBFrm.ShowDialog();
            }
        }

        private void bUser_Click(object sender, EventArgs e)
        {
            UserForm uFrm = new UserForm();
            DialogResult dgr = uFrm.ShowDialog();
            if(dgr == DialogResult.OK)
            {
                UserDBForm userDBForm = new UserDBForm(uFrm.loginClient);
                userDBForm.ShowDialog();
            }
            else if(dgr == DialogResult.Ignore)
            {
                UnUserDBForm unUserDBForm = new UnUserDBForm();
                unUserDBForm.ShowDialog();
            }
        }
    }
}
