using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class WatchFeedbacks : Form
    {
        private int idClient;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataSet ds;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;
        public WatchFeedbacks(int idClient)
        {
            this.idClient = idClient;
            InitializeComponent();
            ReadData();
        }
        private void ReadData()
        {
            string sqlExpression = $"SELECT [Клиент].[ФИО], [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], " +
                $"[Отзыв о тренажерном зале].[Оценка тренажерного зала], [Отзыв о тренажерном зале].[Комментарий] " +
                $"FROM [Отзыв о тренажерном зале] " +
                $"JOIN [Тренажерный зал] ON [Тренажерный зал].[Код тренажерного зала] = [Отзыв о тренажерном зале].[Код тренажерного зала] " +
                $"JOIN [Клиент] ON [Клиент].[Код клиента] = [Отзыв о тренажерном зале].[Код клиента] " +
                $"where [Отзыв о тренажерном зале].[Код клиента]={idClient}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sqlExpression, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void toolSBCreate_Click(object sender, EventArgs e)
        {
            WriteFeedbackForm writeFeedbackForm = new WriteFeedbackForm(idClient);
            DialogResult dg = writeFeedbackForm.ShowDialog();
            if (dg == DialogResult.OK)
            {
                ReadData();
            }
        }

        private void toolSBDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                try
                {
                    int gradeGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                    string nameGym = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string textFeedback = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    string sqlExpression = $"delete [Отзыв о тренажерном зале] " +
                        $"where [Код клиента]={idClient} and [Оценка тренажерного зала]={gradeGym} and " +
                        $"[Код тренажерного зала]=(select [Код тренажерного зала] from [Тренажерный зал] " +
                        $"where [Наименование тренажерного зала]= N'{nameGym}')";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                        cmd.ExecuteNonQuery();
                    }
                    // удаляем выделенные строки из dataGridView1
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(
    ex.Message,
    "Уведомление",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(
                    "Выделенные строки отсутствуют, пожалуйста, выделите строки для удаления",
                    "Уведомление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WatchOtherFeedbacks watchOtherFeedbacks = new WatchOtherFeedbacks();
            watchOtherFeedbacks.ShowDialog();
        }
    }
}
