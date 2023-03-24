using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace CourseWork
{
    public partial class SearchResultsForm : Form
    {
        private List<List<int>> listIDGyms;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataSet ds;
        private SqlDataAdapter adapter;
        public SearchResultsForm(List<List<int>> listIDGyms)
        {
            this.listIDGyms = listIDGyms;
            InitializeComponent();
            SearchQ();
        }
        private void SearchQ()
        {
            List<int> result = null;
            int index = 0;
            for (int i = 0; i < listIDGyms.Count; i++)
            {
                if (listIDGyms[i] != null)
                {
                    result = listIDGyms[i];
                    index = i;
                    break;
                }
            }
            if(result == null)
            {
                dataGridView1.Columns.Clear();
                string sqlExpression = $"SELECT * FROM [Тренажерный зал] ";
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
                for (int i = index + 1; i < listIDGyms.Count; i++)
                {
                    if(listIDGyms[i] != null)
                    {
                        result = result.Intersect<int>(listIDGyms[i]).ToList<int>();
                    }
                }
                if (result.Count != 0)
                {

                    for (int i = 0; i < result.Count; i++)
                    {
                        string sqlExpression = $"SELECT * FROM [Тренажерный зал] " +
                            $"where [Код тренажерного зала]={result[i]}";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                            using (SqlDataReader dr = sqlCommand.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Тренажерных залов, соответствующих указанному фильтру не было найдено",
                        "Уведомление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
