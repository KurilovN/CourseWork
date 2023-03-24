using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class WriteFeedbackForm : Form
    {
        private int idClient;
        private int idGym;
        public WriteFeedbackForm(int idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
            ReadNameGym();
        }
        private void ReadNameGym()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Наименование тренажерного зала], [Город] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBNameGym.Items.Add(dr[0] + " - "+dr[1]);
                    }
                }
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(IsItOk())
            {

                string feedbackField = "";
                string feedbackValue = "";
                if (richTBFeedback.Text != "")
                {
                    feedbackField = ", [Комментарий]";
                    feedbackValue = $", N'{richTBFeedback.Text}'";
                }

                SearchGymID(cBNameGym.Text);

                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string sqlExpression = $"INSERT INTO [Отзыв о тренажерном зале] ([Код клиента], [Код тренажерного зала], [Оценка тренажерного зала] {feedbackField}) " +
                    $"VALUES({idClient}, {idGym}, {cBGradeGym.Text} {feedbackValue})";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                DialogResult = DialogResult.OK;
                MessageBox.Show(
                    "Отзыв о тренажерном зале был успешно отправлен!",
                    "Уведомление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Не все поля заполнены корректно, пожалуйста, заполните их",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool IsItOk()
        {
            return cBGradeGym.Items.Contains(cBGradeGym.Text) && cBNameGym.Items.Contains(cBNameGym.Text);
        }
        private void SearchGymID(string name)
        {
            string[] arr = name.Split('-');
            name = arr[0];
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренажерного зала] from [Тренажерный зал] " +
                $"where [Наименование тренажерного зала]=N'{name}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idGym = Convert.ToInt32(dr[0]);
                    }
                }
            }
        }
    }
}
