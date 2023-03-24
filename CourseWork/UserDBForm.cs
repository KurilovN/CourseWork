using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class UserDBForm : Form
    {
        private int idClient;
        private string loginClient;
        public UserDBForm(string loginClient)
        {
            this.loginClient = loginClient;
            InitializeComponent();
            ShowInformation();
            ReadIdClient();
        }
        private void ReadIdClient()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код клиента] from [Клиент] " +
                $"where [Логин]=N'{loginClient}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        idClient = Convert.ToInt32(dr[0]);
                    }
                }
            }
        }
        private void поискТренажерногоЗалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchGymForm srchGymFrm = new SearchGymForm();
            DialogResult dgr = srchGymFrm.ShowDialog();
            if(dgr == DialogResult.OK)
            {

            }
        }

        private void написатьОтзывОТренажерномЗалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteFeedbackForm writeFeedbackForm = new WriteFeedbackForm(idClient);
            writeFeedbackForm.ShowDialog();
        }

        private void просмотрТопТренажерныхЗаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopGymsUserForm topGymsForm = new TopGymsUserForm();
            topGymsForm.ShowDialog();
        }
        private void ShowInformation()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [ФИО] from [Клиент] " +
                $"where [Логин]=N'{loginClient}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        tBNameClient.Text = Convert.ToString(dr[0]);
                    }
                }
            }

            tBLoginClient.Text = loginClient;
        }

        private void удалитьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить аккаунт без возможности восстановления?",
                "Удаление аккаунта",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string sqlExpression = $"delete from [Клиент] " +
                    $"where [Код клиента]={idClient}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            idClient = Convert.ToInt32(sdr[0]);
                        }
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void изменитьИнформациюОбАккаунтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeInformationUserForm changeFrm = new ChangeInformationUserForm(idClient);
            DialogResult dg = changeFrm.ShowDialog();
            if(dg == DialogResult.OK)
            {
                ShowInformation();
            }
        }

        private void посмотретьНаписанныеОтзывыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchFeedbacks watchFeedbacks = new WatchFeedbacks(idClient);
            DialogResult dg = watchFeedbacks.ShowDialog();
        }
    }
}
