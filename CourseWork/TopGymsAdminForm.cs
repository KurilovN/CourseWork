using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using System.IO;
using OfficeOpenXml;

namespace CourseWork
{
    public partial class TopGymsAdminForm : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public TopGymsAdminForm()
        {
            InitializeComponent();
            ReadDB();
        }
        private void ReadDB()
        {
            string sqlExpression = $"select [Наименование тренажерного зала], [Город], " +
                $"avg([Отзыв о тренажерном зале].[Оценка тренажерного зала]) as [Средняя оценка тренажерного зала] " +
                $"from [Тренажерный зал] " +
                $"join [Отзыв о тренажерном зале] ON [Отзыв о тренажерном зале].[Код тренажерного зала] = [Тренажерный зал].[Код тренажерного зала] " +
                $"group by [Тренажерный зал].[Наименование тренажерного зала], [Тренажерный зал].[Город], [Тренажерный зал].[Код тренажерного зала] " +
                $"order by [Тренажерный зал].[Город], [Тренажерный зал].[Наименование тренажерного зала],  [Средняя оценка тренажерного зала]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void GnrReportBtn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets
.Add("Топ тренажерных залов");

            string data = "";
            int collInd = 0;
            int rowInd = 0;

            //называем колонки
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                data = dataGridView1.Columns[i].HeaderText;
                sheet.Cells[1, i + 1].Value = data;
                sheet.Cells[1, i + 1].Style.Font.Bold = true;
            }

            for (rowInd = 0; rowInd < dataGridView1.Rows.Count; rowInd++)
            {
                for (collInd = 0; collInd < dataGridView1.Columns.Count; collInd++)
                {
                    data = dataGridView1.Rows[rowInd].Cells[collInd].FormattedValue.ToString();
                    sheet.Cells[rowInd + 2, collInd + 1].Value = data;
                    sheet.Cells[rowInd + 2, collInd + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                }
            }

            sheet.Cells[1, 1, dataGridView1.Rows.Count, dataGridView1.Columns.Count].AutoFitColumns();

            sheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


            var reportExcel = package.GetAsByteArray();
            File.WriteAllBytes("Report.xlsx", reportExcel);
            MessageBox.Show(
                "Отчет сформирован успешно",
                "Уведомление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
