using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateGymForm : Form
    {
        public CreateGymForm()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
            {
                try
                {
                    CreateGymQ();
                    MessageBox.Show(
                        $"Тренажерный зал {tBNameGym.Text} успешно добавился",
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
        private void CreateGymQ()
        {
            string nullTables = "";
            string nullValues = "";
            GetNullTable(ref nullTables, ref nullValues);

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Тренажерный зал] ([Наименование тренажерного зала], [Город], [Адрес]{nullTables}) " +
                $"VALUES(N'{tBNameGym.Text}', N'{tBCityGym.Text}', N'{tBAddressGym.Text}'{nullValues})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        private void ClearData()
        {
            tBAddressGym.Clear();
            tBCityGym.Clear();
            tBNameGym.Clear();
            tBPhoneGym.Clear();
            tBWebGym.Clear();
        }
        private bool CheckEmpty()
        {
            if(tBAddressGym.Text=="" || tBCityGym.Text=="" || tBNameGym.Text=="")
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
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }
        private void GetNullTable(ref string nullTables, ref string nullValues)
        {
            if (tBPhoneGym.Text != "")
            {
                nullTables += ", [Телефон]";
                nullValues += $", (tBPhoneGym.Text)";
            }
            if(tBWebGym.Text != "")
            {
                nullTables += ", [Сайт]";
                nullValues += $", N'{tBWebGym.Text}'";
            }
        }

        private void tBPhoneGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
