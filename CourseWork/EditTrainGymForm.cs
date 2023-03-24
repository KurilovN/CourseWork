using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditTrainGymForm : Form
    {
        private string nameTable;
        private int idCoach;
        private int idTrain;
        private string weekDay;
        private DateTime timeBegin;
        private DateTime timeEnd;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idTrainGym;
        public EditTrainGymForm(int idCoach, int idTrain, string weekDay, DateTime timeBegin, DateTime timeEnd, int idTrainGym, string nameTable)
        {
            this.idCoach = idCoach;
            this.idTrain = idTrain;
            this.weekDay = weekDay;
            this.timeBegin = timeBegin;
            this.timeEnd = timeEnd;
            this.idTrainGym = idTrainGym;
            this.nameTable = nameTable;
            InitializeComponent();
            InputTBs();
            ReadIDCoach();
            ReadIDTrain();
        }
        private bool CheckEmpty()
        {
            if (tBBegin.Text == "" && tBEnd.Text == "" && cBCoachID.SelectedItem == null &&
                cBTrainID.SelectedItem == null && cBWeekDay.SelectedItem == null)
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
            bool Eql = idCoach == ((KeyValuePair<int, string>)cBCoachID.SelectedItem).Key &&
                idTrain == ((KeyValuePair<int, string>)cBTrainID.SelectedItem).Key &&
                 weekDay == cBWeekDay.Text && timeBegin.ToString() == tBBegin.Text && timeEnd.ToString() == tBEnd.Text;
            return Eql;
        }
        private void InputTBs()
        {
            tBBegin.Text = timeBegin.ToString();
            tBEnd.Text = timeEnd.ToString();
            cBWeekDay.Text = weekDay;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [ФИО] from [Тренер] " +
                $"where [Код тренера]={idCoach}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBCoachID.Text = dr.GetString(0);
                    }
                }
            }

            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlExpression = $"select [Наименование тренировки] from [Тренировка] " +
                $"where [Код тренировки]={idTrain}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBTrainID.Text = dr.GetString(0);
                    }
                }
            }
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
            int idCoach = ((KeyValuePair<int, string>)cBCoachID.SelectedItem).Key;
            int idTrain = ((KeyValuePair<int, string>)cBTrainID.SelectedItem).Key;

            sqlExpression = $"UPDATE [{nameTable}] SET [Код тренера]={idCoach }, [Код тренировки]={idTrain}, " +
                $"[День недели]=N'{cBWeekDay.Text}', [Время с]='{tBBegin.Text}', [Время по]='{tBEnd.Text}' WHERE [Код тренировки в тренажерном зале]={idTrainGym}";
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
