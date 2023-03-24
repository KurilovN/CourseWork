using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class UserForm : Form
    {
        public string loginClient;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public UserForm()
        {
            InitializeComponent();
        }

        private void bLogIn_Click(object sender, EventArgs e)
        {
            if (!EmptyCheck())
            {
                if (CorrectLoginPassword())
                {
                    loginClient = tBLogin.Text;
                    tBLogin.Clear();
                    tBPassword.Clear();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            tBLogin.Clear();
            tBPassword.Clear();
            DialogResult = DialogResult.Ignore;
        }
        private bool EmptyCheck()
        {
            if (tBLogin.Text == "" && tBPassword.Text == "")
            {
                MessageBox.Show(
                    "Логин и пароль не заполнены, пожалуйста, заполните их",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }
            else if (tBLogin.Text == "")
            {
                MessageBox.Show(
                    "Логин не заполнен, пожалуйста, заполните его",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }
            else if (tBPassword.Text == "")
            {
                MessageBox.Show(
                    "Пароль не заполнен, пожалуйста, заполните его",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void bBack_Click(object sender, EventArgs e)
        {
            tBLogin.Clear();
            tBPassword.Clear();
            DialogResult = DialogResult.Cancel;
        }
        private bool CorrectLoginPassword()
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlExpression = "select * from [Клиент] where Логин=@login and Пароль=@password";
                SqlCommand cmd = new SqlCommand(sqlExpression, sqlConnection);
                cmd.Parameters.AddWithValue("@login", tBLogin.Text);
                cmd.Parameters.AddWithValue("@password", tBPassword.Text);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(
    "Введенные логин и пароль неверны",
    "Сообщение об ошибке",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                        tBPassword.Clear();
                        return false;
                    }
                }

            }
        }

        private void bReg_Click(object sender, EventArgs e)
        {
            if (!EmptyCheck())
            {
                if (EqualLogin() == false)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string sqlExpression = "insert into [Клиент] ([Логин], [Пароль]) values(@login, @password)";
                        SqlCommand cmd = new SqlCommand(sqlExpression, sqlConnection);
                        cmd.Parameters.AddWithValue("@login", tBLogin.Text);
                        cmd.Parameters.AddWithValue("@password", tBPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                            $"Пользователь с логином {tBLogin.Text} успешно зарегистрировался",
                            "Уведомление",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        tBLogin.Clear();
                        tBPassword.Clear();
                    }
                }
                else
                {
                    tBLogin.Clear();
                    tBPassword.Clear();
                    MessageBox.Show(
                        "Пользователь с таким логином уже существует, пожалуйста, введите другой",
                        "Сообщение об ошибке",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            DialogResult = DialogResult.None;
        }
        private bool EqualLogin()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlExpression = "select * from [Клиент] where [Логин]=@login";
                SqlCommand cmd = new SqlCommand(sqlExpression, sqlConnection);
                cmd.Parameters.AddWithValue("@login", tBLogin.Text);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
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
