using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CourseWork
{
    public partial class EditCategoryForm : Form
    {
        private string nameTable;
        private string nameCategory;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idCategory;
        public EditCategoryForm(int idCategory, string nameCategory, string nameTable)
        {
            this.nameTable = nameTable;
            this.nameCategory = nameCategory;
            this.idCategory = idCategory;
            InitializeComponent();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBNameCategory.Text == "") 
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
        private bool CheckEquality()
        {
            bool Eql = tBNameCategory.Text == nameCategory;
            return Eql;
        }
        private void InputTBs()
        {
            tBNameCategory.Text = nameCategory;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEquality() && CheckEmpty())
            {
                try
                {
                    UpdateDB();
                    MessageBox.Show(
                        "Редактирование прошло успешно",
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
                }
            }
            else
            {
                MessageBox.Show(
                                  "Изменения не были внесены ввиду их отсутствия",
                                  "Предупреждение",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }
        }
        private void UpdateDB()
        {
            sqlExpression = $"UPDATE [{nameTable}] SET [Наименование квалификации]= N'{tBNameCategory.Text}' " +
                $"WHERE [Код квалификации]={idCategory}";
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
