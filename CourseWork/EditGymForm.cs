using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditGymForm : Form
    {
        private string nameTable;
        private string addressGym;
        private string nameGym;
        private string webGym;
        private string phoneGym;
        private string cityGym;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idGym;
        public EditGymForm(int idGym, string addressGym, string nameGym, string webGym, string phoneGym, string cityGym, string nameTable)
        {
            this.idGym = idGym;
            this.addressGym = addressGym;
            this.nameGym = nameGym;
            this.webGym = webGym;
            this.phoneGym = phoneGym;
            this.cityGym = cityGym;
            this.nameTable = nameTable;
            InitializeComponent();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBAddressGym.Text == "" && tBCityGym.Text == "" && tBNameGym.Text == "")
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
            bool Eql = addressGym == tBAddressGym.Text && nameGym == tBNameGym.Text && webGym == tBWebGym.Text
                && phoneGym == tBPhoneGym.Text && cityGym == tBCityGym.Text;
            return Eql;
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
                catch(Exception ex)
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

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void UpdateDB()
        {
            sqlExpression = $"UPDATE [{nameTable}] SET [Наименование тренажерного зала]=N'{tBNameGym.Text}', [Адрес]=N'{tBAddressGym.Text}', [Сайт]=N'{tBWebGym.Text}', " +
                $"[Телефон]='{tBPhoneGym.Text}', [Город]=N'{tBCityGym.Text}' WHERE [Код тренажерного зала]={idGym}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        private void InputTBs()
        {
            tBNameGym.Text = nameGym;
            tBPhoneGym.Text = phoneGym;
            tBWebGym.Text = webGym;
            tBCityGym.Text = cityGym;
            tBAddressGym.Text = addressGym;
        }

        private void tBPhoneGym_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
