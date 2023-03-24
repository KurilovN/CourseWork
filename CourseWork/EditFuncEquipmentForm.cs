using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditFuncEquipmentForm : Form
    {
        private string nameTable;
        private int idFuncEquipment;
        private string nameFuncEquipment;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        public EditFuncEquipmentForm(int idFuncEquipment, string nameFuncEquipment, string nameTable)
        {
            this.nameTable = nameTable;
            this.nameFuncEquipment = nameFuncEquipment;
            this.idFuncEquipment = idFuncEquipment;
            InitializeComponent();
            InputTBs();
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
        private bool CheckEquality()
        {
            bool Eql = nameFuncEquipment == tBNameFunc.Text;
            return Eql;
        }
        private void InputTBs()
        {
            tBNameFunc.Text = nameFuncEquipment;
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
            sqlExpression = $"UPDATE [{nameTable}] SET [Назначение оборудования]=N'{tBNameFunc.Text}' " +
                $"WHERE [Код назначения оборудования]={idFuncEquipment}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void ClearData()
        {
            tBNameFunc.Clear();
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
