using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateCoachForm : Form
    {
        public CreateCoachForm()
        {
            InitializeComponent();
            ReadIDCategory();
            ReadIDGym();
        }
        private bool CheckEmpty()
        {
            if (tBEducation.Text == "" || tBName.Text == "" || tBWorkExperience.Text == "" || cBGender.SelectedItem == null
                || cBCategoryID.SelectedItem == null || cBGymID.SelectedItem == null)
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
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
            {
                try
                {
                    CreateCoach();
                    MessageBox.Show(
                        $"Тренер {tBName.Text} успешно добавился",
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
                        MessageBoxIcon.Exclamation);
                }
            }    
        }
        private void CreateCoach()
        {
            int idGym = ((KeyValuePair<int, string>)cBGymID.SelectedItem).Key;
            int idCategory = ((KeyValuePair<int, string>)cBCategoryID.SelectedItem).Key;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Тренер] ([ФИО], [Пол], [Стаж], [Образование], [Код квалификации], [Код тренажерного зала]) " +
                $"VALUES(N'{tBName.Text}', N'{cBGender.Text}', N'{tBWorkExperience.Text}', N'{tBEducation.Text}', {idCategory}, {idGym})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
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

            cBGymID.DataSource = new BindingSource(idGymDict, null);
            cBGymID.DisplayMember = "Value";
            cBGymID.ValueMember = "Key";
            cBGymID.SelectedIndex = -1;
        }
        private void ReadIDCategory()
        {
            Dictionary<int, string> idCategoryDict = new Dictionary<int, string>();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код квалификации], [Наименование квалификации] from [Квалификация]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idCategoryDict.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }
            cBCategoryID.DataSource = new BindingSource(idCategoryDict, null);
            cBCategoryID.DisplayMember = "Value";
            cBCategoryID.ValueMember = "Key";
            cBCategoryID.SelectedIndex = -1;
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
