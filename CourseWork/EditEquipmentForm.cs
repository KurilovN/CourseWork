using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace CourseWork
{
    public partial class EditEquipmentForm : Form
    {
        private string nameTable;
        private int idFuncEquipment;
        private string nameEquipment;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string sqlExpression;
        private int idEquipment;
        public EditEquipmentForm(int idFuncEquipment, string nameEquipment, int idEquipment, string nameTable)
        {
            this.nameTable = nameTable;
            this.idFuncEquipment = idFuncEquipment;
            this.idEquipment = idEquipment;
            this.nameEquipment = nameEquipment;
            InitializeComponent();
            ReadIDFuncEquip();
            InputTBs();
        }
        private bool CheckEmpty()
        {
            if (tBNameEquip.Text == "" && cBIDFuncEquip.SelectedItem == null)
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
            bool Eql = idFuncEquipment == ((KeyValuePair<int, string>)cBIDFuncEquip.SelectedItem).Key && nameEquipment == tBNameEquip.Text;
            return Eql;
        }
        private void InputTBs()
        {
            tBNameEquip.Text = nameEquipment;
            cBIDFuncEquip.Text = idFuncEquipment.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sqlExpression = $"select [Назначение оборудования] from [Назначение оборудования]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cBIDFuncEquip.Text = dr.GetString(0);
                    }
                }
            }
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
            int idFuncEqip = ((KeyValuePair<int, string>)cBIDFuncEquip.SelectedItem).Key;

            sqlExpression = $"UPDATE [{nameTable}] SET [Код назначения оборудования]={idFuncEqip}, [Наименование оборудования]=N'{tBNameEquip.Text}' " +
                $"WHERE [Код оборудования]={idEquipment}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void ClearData()
        {
            tBNameEquip.Clear();
            cBIDFuncEquip.SelectedItem = -1;
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearData();
        }
    }
}
