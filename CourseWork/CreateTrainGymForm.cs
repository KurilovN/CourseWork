using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CourseWork
{
    public partial class CreateTrainGymForm : Form
    {
        public CreateTrainGymForm()
        {
            InitializeComponent();
            ReadIDCoach();
            ReadIDTrain();
        }
        private bool CheckEmpty()
        {
            if (tBBegin.Text == "" || cBCoachID.SelectedItem == null || tBEnd.Text == "" ||
                cBTrainID.SelectedItem == null || cBWeekDay.SelectedItem == null)
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
        private void ReadIDCoach()
        {
            Dictionary<int, string> idCoach = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренера], [ФИО] from [Тренер]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idCoach.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }

            cBCoachID.DataSource = new BindingSource(idCoach, null);
            cBCoachID.DisplayMember = "Value";
            cBCoachID.ValueMember = "Key";
            cBCoachID.SelectedIndex = -1;
        }
        private void ReadIDTrain()
        {
            Dictionary<int, string> idTrain = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренировки], [Наименование тренировки] from [Тренировка]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idTrain.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }

            cBTrainID.DataSource = new BindingSource(idTrain, null);
            cBTrainID.DisplayMember = "Value";
            cBTrainID.ValueMember = "Key";
            cBTrainID.SelectedIndex = -1;
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                try
                {
                    CreateTrainGymQ();
                    MessageBox.Show(
                        $"Данные о тренировки тренажерного зала успешно добавились",
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
        private void CreateTrainGymQ()
        {
            int idCoach = ((KeyValuePair<int, string>)cBCoachID.SelectedItem).Key;
            int idTrain = ((KeyValuePair<int, string>)cBTrainID.SelectedItem).Key;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Тренировка в тренажерном зале] ([Код тренера], [Код тренировки], [День недели], [Время с], [Время по]) " +
                $"VALUES({idCoach}, {idTrain}, N'{cBWeekDay.SelectedItem}', N'{tBBegin.Text}', N'{tBEnd.Text}')";
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
