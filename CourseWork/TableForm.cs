using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class TableForm : Form
    {
        private string nameTable;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataSet ds;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;
        public string NameTable
        {
            get
            {
                return nameTable;
            }
            set
            {
                Text = value;
                nameTable = value;
                ReadDB();
            }
        }
        public TableForm()
        { 
            InitializeComponent();
        }
        private void ReadDB()
        {
            string sqlExpression = $"SELECT * FROM [{NameTable}]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sqlExpression, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void toolSBDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                // удаляем выделенные строки из dataGridView1
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show(
                    "Выделенные строки отсутствуют, пожалуйста, выделите строки для удаления",
                    "Уведомление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            UpdateDB();
        }

        private void UpdateDB()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = $"SELECT * FROM [{NameTable}]";
                    connection.Open();
                    adapter = new SqlDataAdapter(sqlExpression, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            ReadDB();
        }

        private void toolSBEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                switch (NameTable)
                {
                    case "Тренажерный зал":
                        {
                            int idGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameGym = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            string addressGym = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                            string webGym = Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value);
                            string phoneGym = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
                            string cityGym = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
                            EditGymForm edtF = new EditGymForm(idGym, addressGym, nameGym, webGym, phoneGym, cityGym, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Тренировка":
                        {
                            int idTrain = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameTrain = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            string typeTrain = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                            EditTrainForm edtF = new EditTrainForm(nameTable, idTrain, nameTrain, typeTrain);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Расписание дня работы":
                        {
                            int idSchedule = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            int idGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                            string weekDay = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                            string timeBegin = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
                            string timeEnd = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
                            EditScheduleForm edtF = new EditScheduleForm(idGym, weekDay, timeBegin, timeEnd, idSchedule, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Абонемент":
                        {
                            int idSeasonTicket = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameSeasonTicket = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            int countCredit = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                            string typeCredit = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
                            EditSeasonTicketForm edtF = new EditSeasonTicketForm(nameSeasonTicket, countCredit, typeCredit, idSeasonTicket, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Оборудование":
                        {
                            int idEquipment = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameEquipment = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            int idFuncEquip = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                            EditEquipmentForm edtF = new EditEquipmentForm(idFuncEquip, nameEquipment, idEquipment, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Назначение оборудования":
                        {
                            int idFuncEquipment = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameFucnEquip = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            EditFuncEquipmentForm edtF = new EditFuncEquipmentForm(idFuncEquipment, nameFucnEquip, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Оборудование в тренажерном зале":
                        {
                            int idGymEquipment = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            int idGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                            int idEquipment = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                            int countEquip = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                            EditGymEquipForm edtF = new EditGymEquipForm(idEquipment, idGym, countEquip, idGymEquipment, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Тренер":
                        {
                            int idCoach = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameCoach = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            string gender = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                            int workExperience = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                            string education = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
                            int idCategory = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                            int idGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                            EditCoachForm edtF = new EditCoachForm(idCoach, nameCoach, gender, workExperience, education, idCategory, idGym, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Квалификация":
                        {
                            int idCategory = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            string nameCategory = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                            EditCategoryForm edtF = new EditCategoryForm(idCategory, nameCategory, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Тренировка в тренажерном зале":
                        {
                            int idTrainGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            int idCoach = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                            int idTrain = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                            string weekDay = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
                            DateTime timeBegin = DateTime.Parse(Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value));
                            DateTime timeEnd = DateTime.Parse(Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value));
                            EditTrainGymForm edtF = new EditTrainGymForm(idCoach, idTrain, weekDay, timeBegin, timeEnd, idTrainGym, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                    case "Абонемент тренажерного зала":
                        {
                            int idSeasonTicketGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                            int idSeasonTicket = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                            int idGym = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                            int cost = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                            string timeBegin = DateTime.Parse(Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value)).ToShortDateString();
                            string timeEnd = DateTime.Parse(Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value)).ToShortDateString();
                            EditSeasonTicketGymForm edtF = new EditSeasonTicketGymForm(idSeasonTicket, idGym, cost, timeBegin, timeEnd,
                                idSeasonTicketGym, nameTable);
                            edtF.ShowDialog();
                            if (edtF.DialogResult == DialogResult.OK)
                            {
                                ReadDB();
                            }
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show(
                    "Выделенные строки отсутствуют, пожалуйста, выделите строки для редактирования",
                    "Уведомление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void toolSBCreate_Click(object sender, EventArgs e)
        {
            switch(NameTable)
            {
                case "Тренажерный зал":
                    {
                        CreateGymForm crtGymFrm = new CreateGymForm();
                        DialogResult dgr = crtGymFrm.ShowDialog();
                        if(dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Тренировка":
                    {
                        CreateTrainForm crtTrainFrm = new CreateTrainForm();
                        DialogResult dgr = crtTrainFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Расписание дня работы":
                    {
                        CreateScheduleForm crtScheduleFrm = new CreateScheduleForm();
                        DialogResult dgr = crtScheduleFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Абонемент":
                    {
                        CreateSeasonTicketForm crtSeasonTicketFrm = new CreateSeasonTicketForm();
                        DialogResult dgr = crtSeasonTicketFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Оборудование":
                    {
                        CreateEquipmentForm crtEquipmentFrm = new CreateEquipmentForm();
                        DialogResult dgr = crtEquipmentFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Назначение оборудования":
                    {
                        CreateFuncEquipForm crtFuncEquipmentFrm = new CreateFuncEquipForm();
                        DialogResult dgr = crtFuncEquipmentFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Оборудование в тренажерном зале":
                    {
                        CreateGymEquipmentForm crtGymEquipFrm = new CreateGymEquipmentForm();
                        DialogResult dgr = crtGymEquipFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Тренер":
                    {
                        CreateCoachForm crtCoachFrm = new CreateCoachForm();
                        DialogResult dgr = crtCoachFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Квалификация":
                    {
                        CreateCategoryForm crtCategoryFrm = new CreateCategoryForm();
                        DialogResult dgr = crtCategoryFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Тренировка в тренажерном зале":
                    {
                        CreateTrainGymForm crtTrainGymFrm = new CreateTrainGymForm();
                        DialogResult dgr = crtTrainGymFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
                case "Абонемент тренажерного зала":
                    {
                        CreateSeasonTicketGymForm crtSeasonTicketGymFrm = new CreateSeasonTicketGymForm();
                        DialogResult dgr = crtSeasonTicketGymFrm.ShowDialog();
                        if (dgr == DialogResult.OK)
                        {
                            UpdateDB();
                        }
                    }
                    break;
            }
        }
    }
}
