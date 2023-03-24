using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace CourseWork
{
    public partial class EditCoachForm : Form
    {
        private string nameTable;
        private string nameCoach;
        private string gender;
        private int workExperience;
        private string education;
        private int idCategory;
        private int idGym;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idCoach;
        public EditCoachForm(int idCoach, string nameCoach, string gender, int workExperience, string education, int idCategory, int idGym, string nameTable)
        {
            this.idCoach = idCoach;
            this.nameCoach = nameCoach;
            this.gender = gender;
            this.workExperience = workExperience;
            this.education = education;
            this.idCategory = idCategory;
            this.idGym = idGym;
            this.nameTable = nameTable;
            InitializeComponent();
            ReadIDGym();
            ReadIDCategory();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBEducation.Text == "" && tBGender.Text == "" && tBName.Text == "" && tBWorkExperience.Text == "" &&
                cBCategoryID.SelectedItem == null && cBGymID.SelectedItem == null) 
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
            bool Eql = tBName.Text == nameCoach && tBGender.Text == gender && tBEducation.Text == education &&
                tBWorkExperience.Text == workExperience.ToString() && ((KeyValuePair<int, string>)cBCategoryID.SelectedItem).Key == idCategory &&
                ((KeyValuePair<int, string>)cBGymID.SelectedItem).Key == idGym;

            return Eql;
        }
        private void InputTBs()
        {
            tBEducation.Text = education;
            tBGender.Text = gender;
            tBName.Text = nameCoach;
            tBWorkExperience.Text = workExperience.ToString();

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
            sqlExpression = $"select [Наименование квалификации] from [Квалификация] " +
                $"where [Код квалификации]={idCategory}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cBCategoryID.Text = dr.GetString(0);
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
            int idCategory = ((KeyValuePair<int, string>)cBCategoryID.SelectedItem).Key;

            sqlExpression = $"UPDATE [{nameTable}] SET [ФИО]=N'{tBName.Text}', [Пол]=N'{tBGender.Text}', [Стаж]={tBWorkExperience.Text}, " +
                $"[Образование]=N'{tBEducation.Text}', [Код квалификации]={idCategory}, [Код тренажерного зала]={idGym} " +
                $"WHERE [Код тренера]={idCoach}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }                                  
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
