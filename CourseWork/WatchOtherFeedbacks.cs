using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class WatchOtherFeedbacks : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataSet ds;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;
        public WatchOtherFeedbacks()
        {
            InitializeComponent();
            ReadData();
            ReadCity();

        }
        private void ReadData()
        {
            string sqlExpression = $"SELECT [Клиент].[ФИО], [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], [Отзыв о тренажерном зале].[Оценка тренажерного зала], [Отзыв о тренажерном зале].[Комментарий] " +
                $"FROM [Отзыв о тренажерном зале] " +
                $"JOIN [Тренажерный зал] ON [Тренажерный зал].[Код тренажерного зала] = [Отзыв о тренажерном зале].[Код тренажерного зала] " +
                $"JOIN [Клиент] ON [Клиент].[Код клиента] = [Отзыв о тренажерном зале].[Код клиента]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sqlExpression, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void ReadCity()
        {
            string sqlExpression = $"select distinct [Город] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        cBCity.Items.Add(dr[0]);
                    }
                }
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            cBCity.SelectedIndex = -1;
            ReadData();
        }

        private void InsertFilterBtn_Click(object sender, EventArgs e)
        {
            if(cBCity.SelectedItem != null)
            {
                string sqlExpression = $"SELECT [Клиент].[ФИО], [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], [Отзыв о тренажерном зале].[Оценка тренажерного зала], [Отзыв о тренажерном зале].[Комментарий] " +
    $"FROM [Отзыв о тренажерном зале] " +
    $"JOIN [Тренажерный зал] ON [Тренажерный зал].[Код тренажерного зала] = [Отзыв о тренажерном зале].[Код тренажерного зала] " +
    $"JOIN [Клиент] ON [Клиент].[Код клиента] = [Отзыв о тренажерном зале].[Код клиента] " +
    $"where [Тренажерный зал].[Город]= N'{cBCity.Text}'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sqlExpression, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            else
            {
                MessageBox.Show(
                    "Вы не выбрали город, для фильтрации, пожалуйста, выберите и повторите операцию заново",
                    "сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
