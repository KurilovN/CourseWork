using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditScheduleForm : Form
    {
        private string nameTable;
        private int idGym;
        private string weekDay;
        private string timeBegin;
        private string timeEnd;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idSchedule;
        public EditScheduleForm(int idGym, string weekDay, string timeBegin, string timeEnd, int idSchedule, string nameTable)
        {
            this.idGym = idGym;
            this.weekDay = weekDay;
            this.timeBegin = timeBegin;
            this.timeEnd = timeEnd;
            this.idSchedule = idSchedule;
            this.nameTable = nameTable;
            InitializeComponent();
            ReadIDGym();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBBegin.Text == "" && tBEnd.Text == "" && cBIDGym.SelectedItem == null && cBWeekDay.SelectedItem == null)
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
            bool Eql = idGym == ((KeyValuePair<int, string>)cBIDGym.SelectedItem).Key && weekDay == cBWeekDay.SelectedItem.ToString()
                && timeBegin == tBBegin.Text && timeEnd == tBEnd.Text;
            return Eql;
        }
        private void InputTBs()
        {
            tBBegin.Text = timeBegin;
            tBEnd.Text = timeEnd;
            cBWeekDay.Text = weekDay;


            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Наименование тренажерного зала], [Город] from [Тренажерный зал] " +
                $"where [Код тренажерного зала]={idGym}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cBIDGym.Text = $"{dr.GetString(0)} - {dr.GetString(1)}";
                    }
                }
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
                    while (dr.Read())
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
            int idGym = ((KeyValuePair<int, string>)cBIDGym.SelectedItem).Key;

            sqlExpression = $"UPDATE [{nameTable}] SET [Код тренажерного зала]={idGym}, [День недели]=N'{cBWeekDay.SelectedItem}', " +
                $"[Время с]='{tBBegin.Text}', [Время по]='{tBEnd.Text}' WHERE [Код расписания дня работы]={idSchedule}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void ClearData()
        {
            tBBegin.Clear();
            tBEnd.Clear();
            cBIDGym.SelectedIndex = -1;
            cBWeekDay.SelectedIndex = -1;
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }

        private void tBBegin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
