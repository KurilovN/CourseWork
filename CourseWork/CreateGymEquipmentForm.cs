using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateGymEquipmentForm : Form
    {
        public CreateGymEquipmentForm()
        {
            InitializeComponent();
            ReadIDEquip();
            ReadIDGym();
        }
        private bool CheckEmpty()
        {
            if (tBCount.Text == "" || cBIDEquipment.SelectedItem == null || cBIDGym.SelectedItem == null)
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
            if (CheckEmpty())
            {
                try
                {
                    CreateGymEquipQ();
                    MessageBox.Show(
                        $"Данные в бд успешно добавились",
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
        private void CreateGymEquipQ()
        {
            int idGym = ((KeyValuePair<int, string>)cBIDGym.SelectedItem).Key;
            int idEquip = ((KeyValuePair<int, string>)cBIDEquipment.SelectedItem).Key;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Оборудование в тренажерном зале] ([Код тренажерного зала], [Код оборудования], [Количество]) " +
                $"VALUES({idGym}, {idEquip}, {tBCount.Text})";
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
    }
}
