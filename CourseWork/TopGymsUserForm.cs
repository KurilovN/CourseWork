using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CourseWork
{
    public partial class TopGymsUserForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public TopGymsUserForm()
        {
            InitializeComponent();
            ReadDB();
            ReadCities();
        }
        private void ReadDB()
        {
            string sqlExpression = $"select [Наименование тренажерного зала], [Город], " +
                $"avg([Отзыв о тренажерном зале].[Оценка тренажерного зала]) as [Средняя оценка тренажерного зала] " +
                $"from [Тренажерный зал] " +
                $"join [Отзыв о тренажерном зале] ON [Отзыв о тренажерном зале].[Код тренажерного зала] = [Тренажерный зал].[Код тренажерного зала] " +
                $"group by [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], [Тренажерный зал].[Код тренажерного зала] " +
                $"order by [Средняя оценка тренажерного зала] DESC, [Тренажерный зал].[Наименование тренажерного зала] ASC, [Тренажерный зал].[Город] ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void ReadCities()
        {
            string sqlExpression = $"select distinct [Город] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBChoiceOfCity.Items.Add(dr[0]);
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ClearFilterBtn_Click(object sender, EventArgs e)
        {
            cBChoiceOfCity.SelectedIndex = -1;
            string sqlExpression = $"select [Наименование тренажерного зала], [Город], " +
                $"avg([Отзыв о тренажерном зале].[Оценка тренажерного зала]) as [Средняя оценка тренажерного зала] " +
                $"from [Тренажерный зал] " +
                $"join [Отзыв о тренажерном зале] ON [Отзыв о тренажерном зале].[Код тренажерного зала] = [Тренажерный зал].[Код тренажерного зала] " +
                $"group by [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], [Тренажерный зал].[Код тренажерного зала] " +
                $"order by [Средняя оценка тренажерного зала] DESC, [Тренажерный зал].[Наименование тренажерного зала] ASC, [Тренажерный зал].[Город] ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void InsertFilterBtn_Click(object sender, EventArgs e)
        {
            if(cBChoiceOfCity.SelectedItem != null)
            {
                string sqlExpression = $"select [Наименование тренажерного зала], [Город], " +
    $"avg([Отзыв о тренажерном зале].[Оценка тренажерного зала]) as [Средняя оценка тренажерного зала] " +
    $"from [Тренажерный зал] " +
    $"join [Отзыв о тренажерном зале] ON [Отзыв о тренажерном зале].[Код тренажерного зала] = [Тренажерный зал].[Код тренажерного зала] " +
    $"where [Тренажерный зал].[Город] = N'{cBChoiceOfCity.SelectedItem}' " +
    $"group by [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], [Тренажерный зал].[Код тренажерного зала] " +
    $"order by [Средняя оценка тренажерного зала] DESC, [Тренажерный зал].[Наименование тренажерного зала] ASC, [Тренажерный зал].[Город] ASC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            else
            {
                MessageBox.Show(
                    "Вы не выбрали город, пожалуйста, выберите",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
