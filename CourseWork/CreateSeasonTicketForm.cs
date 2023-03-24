using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateSeasonTicketForm : Form
    {
        public CreateSeasonTicketForm()
        {
            InitializeComponent();
        }
        private bool CheckEmpty()
        {
            if (tBCountCredit.Text == "" || tBNameSeasonTicket.Text == "" || cBTypeCredit.SelectedItem == null)
            {
                MessageBox.Show(
                    "Одно/несколько из полей обязательных значений пустое, пожалуйста заполните его/их",
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
                    CreateSeasonTicket();
                    MessageBox.Show(
                        $"Абонемент {tBNameSeasonTicket.Text} успешно добавился",
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
        private void CreateSeasonTicket()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Абонемент] ([Наименование], [Длительность в у е], [Тип условной единицы]) " +
                $"VALUES(N'{tBNameSeasonTicket.Text}', {tBCountCredit.Text}, N'{cBTypeCredit.SelectedItem}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        private void ClearData()
        {
            tBNameSeasonTicket.Clear();
            tBCountCredit.Clear();
            cBTypeCredit.SelectedIndex = -1;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
