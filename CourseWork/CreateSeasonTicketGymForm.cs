using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateSeasonTicketGymForm : Form
    {
        public CreateSeasonTicketGymForm()
        {
            InitializeComponent();
            ReadIDSeasonTicket();
            ReadIDGym();
        }
        private bool CheckEmpty()
        {
            if (tBBegin.Text == "" || tBCost.Text == "" || tBEnd.Text == "" ||
                cBGymID.SelectedItem == null || cBSeasonTicketD.SelectedItem == null) 
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
        private void ReadIDSeasonTicket()
        {
            Dictionary<int, string> idSeasonTicket= new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код абонемента], [Наименование] from [Абонемент]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idSeasonTicket.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }

            cBSeasonTicketD.DataSource = new BindingSource(idSeasonTicket, null);
            cBSeasonTicketD.DisplayMember = "Value";
            cBSeasonTicketD.ValueMember = "Key";
            cBSeasonTicketD.SelectedIndex = -1;
        }
        private void ReadIDGym()
        {
            Dictionary<int, string> idGym = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренажерного зала], [Наименование тренажерного зала], [Город] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idGym.Add(dr.GetInt32(0), dr.GetString(1) + " - " + dr.GetString(2));
                    }
                }
            }

            cBGymID.DataSource = new BindingSource(idGym, null);
            cBGymID.DisplayMember = "Value";
            cBGymID.ValueMember = "Key";
            cBGymID.SelectedIndex = -1;
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                try
                {
                    CreateSeasonTicketGymQ();
                    MessageBox.Show(
                        $"Данные о тренировке тренажерного зала успешно добавились",
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
        private void CreateSeasonTicketGymQ()
        {
            int idGym = ((KeyValuePair<int, string>) cBGymID.SelectedItem).Key;
            int idSeasonTicket = ((KeyValuePair<int, string>)cBSeasonTicketD.SelectedItem).Key;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Абонемент тренажерного зала] ([Код абонемента], [Код тренажерного зала], [Стоимость], [Дата с], [Дата по]) " +
                $"VALUES({idSeasonTicket}, {idGym}, {tBCost.Text}, @beg, @end)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DateTime beg = DateTime.Parse(tBBegin.Text);
                DateTime end = DateTime.Parse(tBEnd.Text);

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlParameter parameterBeg = command.Parameters.Add("@beg", System.Data.SqlDbType.DateTime);
                parameterBeg.Value = beg;

                SqlParameter parameterEnd = command.Parameters.Add("@end", System.Data.SqlDbType.DateTime);
                parameterEnd.Value = end;
                command.ExecuteNonQuery();
            }
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
