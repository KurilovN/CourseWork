using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class EditGymEquipForm : Form
    {
        private string nameTable;
        private int idEquipment;
        private int idGym;
        private int countEquip;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idGymEquipment;
        public EditGymEquipForm(int idEquipment, int idGym, int countEquip, int idGymEquipment, string nameTable)
        {
            this.nameTable = nameTable;
            this.idEquipment = idEquipment;
            this.idGym = idGym;
            this.countEquip = countEquip;
            this.idGymEquipment = idGymEquipment;
            InitializeComponent();
            ReadIDEquip();
            ReadIDGym();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBCount.Text == "" && cBIDEquipment.SelectedItem == null && cBIDGym.SelectedItem == null)
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
            bool Eql = idEquipment == ((KeyValuePair<int, string>)cBIDEquipment.SelectedItem).Key  && 
                idGym == ((KeyValuePair<int, string>)cBIDGym.SelectedItem).Key
                && countEquip.ToString() == tBCount.Text;
            return Eql;
        }
        private void InputTBs()
        {
            tBCount.Text = countEquip.ToString();

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
                        cBIDGym.Text = $"{dr.GetString(0)} - {dr.GetString(1)}";
                    }
                }
            }

            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlExpression = $"select [Наименование оборудования] from [Оборудование] " +
                $"where [Код оборудования]={idEquipment}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cBIDEquipment.Text = $"{dr.GetString(0)}";
                    }
                }
            }
        }
        private void ReadIDEquip()
        {
            Dictionary<int, string> idEquip = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код оборудования], [Наименование оборудования] from [Оборудование]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idEquip.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }

            cBIDEquipment.DataSource = new BindingSource(idEquip, null);
            cBIDEquipment.DisplayMember = "Value";
            cBIDEquipment.ValueMember = "Key";
            cBIDEquipment.SelectedIndex = -1;
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

            cBIDGym.DataSource = new BindingSource(idGymDict, null);
            cBIDGym.DisplayMember = "Value";
            cBIDGym.ValueMember = "Key";
            cBIDGym.SelectedIndex = -1;
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
            int idGym = ((KeyValuePair<int, string>)cBIDGym.SelectedItem).Key;
            int idEquip = ((KeyValuePair<int, string>)cBIDEquipment.SelectedItem).Key;

            sqlExpression = $"UPDATE [{nameTable}] SET [Код тренажерного зала]={idGym}, [Код оборудования]={idEquip}, " +
                $"[Количество]={tBCount.Text} WHERE [Код оборудования тренажерного зала]={idGymEquipment}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void ClearData()
        {
            cBIDEquipment.SelectedIndex = -1;
            cBIDGym.SelectedIndex = -1;
            tBCount.Clear();
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
