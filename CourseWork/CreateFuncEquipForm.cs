using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateFuncEquipForm : Form
    {
        public CreateFuncEquipForm()
        {
            InitializeComponent();
        }
        private bool CheckEmpty()
        {
            if (tBNameFunc.Text == "")
            {
                MessageBox.Show(
                    "Одно/несколько полей обязательных значений пустое, пожалуйста заполните его/их",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                try
                {
                    CreateFuncEquipQ();
                    MessageBox.Show(
                        $"Назначение оборудования {tBNameFunc.Text} успешно добавилось",
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
                        MessageBoxIcon.Exclamation);
                }
            }
        }
        private void CreateFuncEquipQ()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Назначение оборудования] ([Назначение оборудования]) " +
                $"VALUES(N'{tBNameFunc.Text}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
