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
    public partial class AdminForm : Form
    {
        private const string loginAdmin = "admin";
        private const string passwordAdmin = "admin";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            tBLogin.Clear();
            tBPassword.Clear();
            DialogResult = DialogResult.Cancel;
        }

        private void bLogIn_Click(object sender, EventArgs e)
        {
            if (tBLogin.Text == "" && tBPassword.Text == "") 
            {
                MessageBox.Show(
                    "Логин и пароль не заполнены, пожалуйста, заполните их",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if(tBLogin.Text == "")
            {
                MessageBox.Show(
                    "Логин не заполнен, пожалуйста, заполните его",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if(tBPassword.Text == "")
            {
                MessageBox.Show(
                    "Пароль не заполнен, пожалуйста, заполните его",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (CorrectLoginPassword())
            {
                DialogResult = DialogResult.OK;
            }
        }
        private bool CorrectLoginPassword()
        {
            if(tBLogin.Text!=loginAdmin || tBPassword.Text!=passwordAdmin)
            {
                MessageBox.Show(
                    "Введенные логин и пароль неверны",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void tBLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
