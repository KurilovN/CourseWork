using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class CreateEquipmentForm : Form
    {
        public CreateEquipmentForm()
        {
            InitializeComponent();
            ReadIDFuncEquip();
        }
        private bool CheckEmpty()
        {
            if (tBNameEquip.Text == "" || cBIDFuncEquip.SelectedItem == null)
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
                    CreateEquipQ();
                    MessageBox.Show(
                        $"Оборудование {tBNameEquip.Text} успешно добавилось",
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
        private void CreateEquipQ()
        {
            int idFuncEqip = ((KeyValuePair<int, string>)cBIDFuncEquip.SelectedItem).Key;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"INSERT INTO [Оборудование] ([Наименование оборудования], [Код назначения оборудования]) " +
                $"VALUES(N'{tBNameEquip.Text}', {idFuncEqip})";
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
        private void ReadIDFuncEquip()
        {
            Dictionary<int, string> idFuncEquip = new Dictionary<int, string>();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Код назначения оборудования], [Назначение оборудования] from [Назначение оборудования]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idFuncEquip.Add(dr.GetInt32(0), dr.GetString(1));
                    }
                }
            }

            cBIDFuncEquip.DataSource = new BindingSource(idFuncEquip, null);
            cBIDFuncEquip.DisplayMember = "Value";
            cBIDFuncEquip.ValueMember = "Key";
            cBIDFuncEquip.SelectedIndex = -1;
        }

    }
}
