using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditSeasonTicketForm : Form
    {
        private string nameTable;
        private string nameSeasonTicket;
        private int countCredit;
        private string typeCredit;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idSeasonTicket;
        public EditSeasonTicketForm(string nameSeasonTicket, int countCredit, string typeCredit, int idSeasonTicket, string nameTable)
        {
            this.nameSeasonTicket = nameSeasonTicket;
            this.countCredit = countCredit;
            this.typeCredit = typeCredit;
            this.idSeasonTicket = idSeasonTicket;
            this.nameTable = nameTable;
            InitializeComponent();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBCountCredit.Text == "" && tBNameSeasonTicket.Text == "" && cBTypeCredit.SelectedItem == null)
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
            bool Eql = nameSeasonTicket == tBNameSeasonTicket.Text && countCredit == Convert.ToInt32(tBCountCredit.Text)
                && typeCredit == cBTypeCredit.SelectedItem.ToString();
            return Eql;
        }
        private void InputTBs()
        {
            tBCountCredit.Text = countCredit.ToString();
            tBNameSeasonTicket.Text = nameSeasonTicket;
            cBTypeCredit.Text = typeCredit;
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
            sqlExpression = $"UPDATE [{nameTable}] SET [Наименование]=N'{tBNameSeasonTicket.Text}', [Длительность в у е]={tBCountCredit.Text}, " +
                $"[Тип условной единицы]=N'{cBTypeCredit.SelectedItem}' WHERE [Код абонемента]={idSeasonTicket}";
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
