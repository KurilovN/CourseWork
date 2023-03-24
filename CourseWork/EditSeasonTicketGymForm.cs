using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditSeasonTicketGymForm : Form
    {
        private string nameTable;
        private int idSeasonTicket;
        private int idGym;
        private int cost;
        private string timeBegin;
        private string timeEnd;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idSeasonTicketGym;
        public EditSeasonTicketGymForm(int idSeasonTicket, int idGym, int cost, string timeBegin, string timeEnd, int idSeasonTicketGym, string nameTable)
        {
            this.idSeasonTicket = idSeasonTicket;
            this.idGym = idGym;
            this.cost = cost;
            this.timeBegin = timeBegin;
            this.timeEnd = timeEnd;
            this.idSeasonTicketGym = idSeasonTicketGym;
            this.nameTable = nameTable;
            InitializeComponent();
            ReadIDSeasonTicket();
            ReadIDGym();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBBegin.Text == "" && tBCost.Text == "" && tBEnd.Text == "" && cBGymID.SelectedItem == null && cBGymID.SelectedItem == null)
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
            bool Eql = idSeasonTicket == ((KeyValuePair<int, string>)cBSeasonTicketD.SelectedItem).Key &&
                 idGym == ((KeyValuePair<int, string>)cBGymID.SelectedItem).Key &&
                 cost.ToString() == tBCost.Text && timeBegin.ToString() == tBBegin.Text && timeEnd.ToString() == tBEnd.Text;
            return Eql;
        }
        private void InputTBs()
        {
            tBBegin.Text = timeBegin.ToString();
            tBEnd.Text = timeEnd.ToString();
            tBCost.Text = cost.ToString();

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
                        cBGymID.Text = $"{dr.GetString(0)} - {dr.GetString(1)}";
                    }
                }
            }

            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlExpression = $"select [Наименование] from [Абонемент] " +
                $"where [Код абонемента]={idSeasonTicket}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBSeasonTicketD.Text = $"{dr.GetString(0)}";
                    }
                }
            }
        }
        private void ReadIDSeasonTicket()
        {
            Dictionary<int, string> idSeasonTicket = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код абонемента], [Наименование] from [Абонемент]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idSeasonTicket.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }

            cBSeasonTicketD.DataSource = new BindingSource(idSeasonTicket, null);
            cBSeasonTicketD.DisplayMember = "Value";
            cBSeasonTicketD.ValueMember = "Key";
            cBSeasonTicketD.SelectedIndex = -1;
        }
        private void ReadIDGym()
        {
            Dictionary<int, string> idGym = new Dictionary<int, string>();

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
                        idGym.Add(dr.GetInt32(0), dr.GetString(1) + " - " + dr.GetString(2));
                    }
                }
            }

            cBGymID.DataSource = new BindingSource(idGym, null);
            cBGymID.DisplayMember = "Value";
            cBGymID.ValueMember = "Key";
            cBGymID.SelectedIndex = -1;
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
            int idGym = ((KeyValuePair<int, string>)cBGymID.SelectedItem).Key;
            int idSeasonTicket = ((KeyValuePair<int, string>)cBSeasonTicketD.SelectedItem).Key;

            sqlExpression = $"UPDATE [{nameTable}] SET [Код абонемента]={idSeasonTicket}, [Код тренажерного зала]={idGym}, " +
                $"[Стоимость]={tBCost.Text}, [Дата с]=@beg, [Дата по]=@end WHERE [Код абонемента тренажерного зала]={idSeasonTicketGym}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DateTime beg = DateTime.Parse(tBBegin.Text);
                DateTime end = DateTime.Parse(tBEnd.Text);

                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlParameter parameterBeg = command.Parameters.Add("@beg", System.Data.SqlDbType.DateTime);
                parameterBeg.Value = beg;

                SqlParameter parameterEnd = command.Parameters.Add("@end", System.Data.SqlDbType.DateTime);
                parameterEnd.Value = end;

                command.ExecuteNonQuery();
            }
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
