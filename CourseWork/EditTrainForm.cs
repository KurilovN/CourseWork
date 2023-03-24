using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{

    public partial class EditTrainForm : Form
    {
        string nameTable;
        int idTrain;
        string nameTrain;
        string typeTrain;
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public EditTrainForm(string nameTable, int idTrain, string nameTrain, string typeTrain)
        {
            this.nameTable = nameTable;
            this.nameTrain = nameTrain;
            this.typeTrain = typeTrain;
            this.idTrain = idTrain;
            InitializeComponent();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBNameTrain.Text == "" && cBTypeTrain.SelectedItem == null)
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
            bool Eql = nameTrain == tBNameTrain.Text && typeTrain == cBTypeTrain.SelectedItem.ToString();
            return Eql;
        }
        private void UpdateDB()
        {
            string sqlExpression = $"UPDATE [{nameTable}] SET [Наименование тренировки]=N'{tBNameTrain.Text}', [Вид тренировки]=N'{cBTypeTrain.SelectedItem}'" +
                $" WHERE [Код тренировки]={idTrain}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        private void InputTBs()
        {
            tBNameTrain.Text = nameTrain;
            cBTypeTrain.Text = typeTrain;
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
    }
}
