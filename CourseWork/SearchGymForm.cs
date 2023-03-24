using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class SearchGymForm : Form
    {
        public SearchGymForm()
        {
            InitializeComponent();
            ReadNameGym();
            ReadCityGym();
            ReadEquipFuncGym();
            ReadTrain();
        }
        private void ReadNameGym()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select distinct [Наименование тренажерного зала] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBNameGym.Items.Add(dr[0]);
                    }
                }
            }
        }
        private void ReadCityGym()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select distinct [Город] from [Тренажерный зал]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBCity.Items.Add(dr[0]);
                    }
                }
            }
        }
        private void ReadEquipFuncGym()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select distinct [Назначение оборудования] from [Назначение оборудования]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBEquip.Items.Add(dr[0]);
                    }
                }
            }
        }
        private void ReadTrain()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select distinct [Наименование тренировки] from [Тренировка]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cBTrain.Items.Add(dr[0]);
                    }
                }
            }
        }
        private void CheckResultsBtn_Click(object sender, EventArgs e)
        {
            List<List<int>> listIdGyms = new List<List<int>> { NameGymQ(), CityGymQ(), EquipFuncGymQ(), TrainGymQ() };
            SearchResultsForm searchResultsForm = new SearchResultsForm(listIdGyms);
            searchResultsForm.ShowDialog();
        }
        private List<int> EquipFuncGymQ()
        {
            if (cBEquip.SelectedItem == null)
            {
                return null;
            }

            List<int> listIdFuncEquip = new List<int>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код назначения оборудования] from [Назначение оборудования] " +
                $"where [Назначение оборудования]=@func";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@func", cBEquip.SelectedItem);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listIdFuncEquip.Add(dr.GetInt32(0));
                    }
                }
            }

            List<int> listIdEquips = new List<int>();

            foreach (var idFunc in listIdFuncEquip)
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                sqlExpression = $"select [Код оборудования] from [Оборудование] " +
                    $"where [Код назначения оборудования]={idFunc}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listIdEquips.Add(dr.GetInt32(0));
                        }

                    }
                }
            }

            List<int> listIdGyms = new List<int>();

            foreach (var idEquip in listIdEquips)
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                sqlExpression = $"select distinct [Код тренажерного зала] from [Оборудование в тренажерном зале] " +
                    $"where [Код оборудования]={idEquip}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (!listIdGyms.Contains(dr.GetInt32(0)))
                            {
                                listIdGyms.Add(dr.GetInt32(0));
                            }
                        }

                    }
                }
            }

            return listIdGyms;
        }
        private List<int> NameGymQ()
        {
            if (cBNameGym.SelectedItem==null)
            {
                return null;
            }

            List<int> tmp = new List<int>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренажерного зала] from [Тренажерный зал] " +
                $"where [Наименование тренажерного зала]=@name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", cBNameGym.SelectedItem);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tmp.Add(dr.GetInt32(0));
                    }
                }
            }

            return tmp;
        }
        private List<int> CityGymQ()
        {
            if (cBCity.SelectedItem==null)
            {
                return null;
            }

            List<int> tmp = new List<int>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренажерного зала] from [Тренажерный зал] " +
                $"where [Город]=@city";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@city", cBCity.SelectedItem);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tmp.Add(dr.GetInt32(0));
                    }
                }
            }

            return tmp;
        }
        private List<int> TrainGymQ()
        {
            if (cBTrain.SelectedItem == null)
            {
                return null;
            }

            List<int> listIdTrain = new List<int>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код тренировки] from [Тренировка] " +
                $"where [Наименование тренировки]=@name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@name", cBTrain.SelectedItem);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listIdTrain.Add(dr.GetInt32(0));
                    }
                }
            }

            List<int> listIdCoaches = new List<int>();

            foreach (var idTrain in listIdTrain)
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                sqlExpression = $"select [Код тренера] from [Тренировка в тренажерном зале] " +
                    $"where [Код тренировки]={idTrain}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listIdCoaches.Add(dr.GetInt32(0));
                        }

                    }
                }
            }

            List<int> listIdGyms = new List<int>();

            foreach (var idCoach in listIdCoaches)
            {
                connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                sqlExpression = $"select [Код тренажерного зала] from [Тренер] " +
                    $"where [Код тренера]={idCoach}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (!listIdGyms.Contains(dr.GetInt32(0)))
                            {
                                listIdGyms.Add(dr.GetInt32(0));
                            }
                        }

                    }
                }
            }
            return listIdGyms;
        }
        private void ClearNameGymBtn_Click(object sender, EventArgs e)
        {
            cBNameGym.SelectedIndex = -1;
        }

        private void ClearCityGymBtn_Click(object sender, EventArgs e)
        {
            cBCity.SelectedIndex = -1;
        }

        private void ClearEquipGymBtn_Click(object sender, EventArgs e)
        {
            cBEquip.SelectedIndex = -1;
        }

        private void ClearTrainBtn_Click(object sender, EventArgs e)
        {
            cBTrain.SelectedIndex = -1;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
