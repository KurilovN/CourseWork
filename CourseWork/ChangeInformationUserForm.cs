using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CourseWork
{
    public partial class ChangeInformationUserForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idClient;
        private string loginClient;
        private string nameClient;
        private string passClient;
        public ChangeInformationUserForm(int idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
            ReadDB();
            InputTB();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CheckCorrectData())
            {
                try
                {
                    UpdateDB();
                    MessageBox.Show(
                        "Данные были успешно отредактированы",
                        "Уведомление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Сообщение об ошибке",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearData();
                }
            }
        }
        private bool CheckEmpty()
        {
            if (tBLoginClient.Text == "" || tBCurrentPassw.Text == "")
            {
                MessageBox.Show(
                    "Не все обязательные поля заполнены, пожалуйста, заполните их",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void UpdateDB()
        {
            if (tBNewPassw.Text != "")
            {
                sqlExpression = $"UPDATE [Клиент] SET [ФИО]=N'{tBNameClient.Text}', [Логин]=N'{tBLoginClient.Text}', [Пароль]=N'{tBNewPassw.Text}' " +
        $"WHERE [Код клиента]={idClient}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                sqlExpression = $"UPDATE [Клиент] SET [ФИО]=N'{tBNameClient.Text}', [Логин]=N'{tBLoginClient.Text}' " +
        $"WHERE [Код клиента]={idClient}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void ReadDB()
        {
            sqlExpression = $"select [ФИО], [Логин], [Пароль] from [Клиент] " +
                $"where [Код клиента]=N'{idClient}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        passClient = Convert.ToString(dr[2]);
                        loginClient = Convert.ToString(dr[1]);
                        nameClient = Convert.ToString(dr[0]);
                    }
                }
            }
        }
        private void InputTB()
        {
            tBLoginClient.Clear();
            tBNameClient.Clear();
            tBLoginClient.Text = loginClient;
            tBNameClient.Text = nameClient;
        }
        private void ClearData()
        {
            tBCurrentPassw.Clear();
            tBNewPassw.Clear();
            tBRetryPassw.Clear();
            InputTB();

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool CheckCorrectData()
        {
            if (CheckEmpty())
            {
                if (passClient == tBCurrentPassw.Text)
                {
                    if (tBNewPassw.Text == "" && tBRetryPassw.Text == "")
                    {
                        return CheckSameLogin();
                    }
                    else
                    {
                        return CheckSameLogin() && CheckCorrectPassword();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Введенный пароль не верен",
                        "Сообщение об ошибке",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearData();
                    return false;
                }
            }
            return false;
        }
        private bool CheckCorrectPassword()
        {
            if(passClient != tBNewPassw.Text)
            {
                if(tBNewPassw.Text == tBRetryPassw.Text)
                {
                    return true;
                }
                tBNewPassw.Clear();
                tBRetryPassw.Clear();
                MessageBox.Show(
                    "Пароли не совпадают, пожалуйста, введите правильно свой новый пароль",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            tBNewPassw.Clear();
            tBRetryPassw.Clear();
            MessageBox.Show(
    "Новый пароль совпадает с текущем",
    "Сообщение об ошибке",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            return false;
        }
        private bool CheckSameLogin()
        {
            if (loginClient != tBLoginClient.Text)
            {
                sqlExpression = $"select [Логин] from [Клиент] " +
    $"where [Логин]=N'{tBLoginClient.Text}'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show(
                                "Введенный логин уже существует в системе",
                                "Сообщение об ошибке",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            ClearData();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void tBLoginClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tBCurrentPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tBNewPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tBRetryPassw_KeyPress(object sender, KeyPressEventArgs e)
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
