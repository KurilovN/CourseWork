using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CourseWork
{
    public partial class CreateScheduleForm : Form
    {
        public CreateScheduleForm()
        {
            InitializeComponent();
            ReadIDGym();
        }
        private bool CheckEmpty()
        {
            if (tBBegin.Text == "" || tBEnd.Text == "" || cBIDGym.SelectedItem == null || cBWeekDay.SelectedItem == null) 
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
                    CreateScheduleQ();
                    MessageBox.Show(
                        $"Расписание тренажерного зала {((KeyValuePair<int, string>)cBIDGym.SelectedItem).Value} успешно добавилось",
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
        private void CreateScheduleQ()
        {
            int idGym = ((KeyValuePair<int, string>)cBIDGym.SelectedItem).Key;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Расписание дня работы] ([Код тренажерного зала], [День недели], [Время с], [Время по]) " +
                $"VALUES({idGym}, N'{cBWeekDay.SelectedItem}', '{tBBegin.Text}', '{tBEnd.Text}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
        private void ReadIDGym()
        {
            Dictionary<int, string> idGymDict = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренажерного зала], [Наименование тренажерного зала], [Город] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        idGymDict.Add(dr.GetInt32(0), dr.GetString(1) + " - " + dr.GetString(2));
                    }
                }
            }

            cBIDGym.DataSource = new BindingSource(idGymDict, null);
            cBIDGym.DisplayMember = "Value";
            cBIDGym.ValueMember = "Key";
            cBIDGym.SelectedIndex = -1;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
