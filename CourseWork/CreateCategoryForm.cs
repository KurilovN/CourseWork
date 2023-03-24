using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateCategoryForm : Form
    {
        public CreateCategoryForm()
        {
            InitializeComponent();
        }
        private bool CheckEmpty()
        {
            if (tBNameCategory.Text=="")
            {
                MessageBox.Show(
                    "Поле 'Наименование категории' пустое, пожалуйста заполните его",
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
                    CreateCategory();
                    MessageBox.Show(
                        $"Квалификация {tBNameCategory.Text} успешно добавилась",
                        "Уведомление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
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
        private void CreateCategory()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Квалификация] ([Наименование квалификации]) " +
                $"VALUES(N'{tBNameCategory.Text}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        private void ClearData()
        {
            tBNameCategory.Clear();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
