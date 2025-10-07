using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Project
{
    public partial class Record : Form
    {
        private string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";
        private string userRole;
        private int partnerId;

        public Record(string role, int partnerId = 0)
        {
            InitializeComponent();
            userRole = role;
            this.partnerId = partnerId;
            ApplyRolePermissions();
        }
        private void ApplyRolePermissions()
        {
            foreach (Button btn in new Button[] { btnHistory, buttonWarehouse, buttonRating, buttonService, buttonExport })
            {
                if (btn != null) btn.Visible = false;
            }

            switch (userRole)
            {
                case "Партнёр":
                    btnHistory.Visible = true;
                    buttonExport.Visible = true;
                    LoadPartnerOrders();
                    break;
                case "Поставщик":
                    buttonWarehouse.Visible = true;
                    LoadWarehouseReport();
                    break;
                case "Сотрудник":
                case "Админ":
                    btnHistory.Visible = true;
                    buttonWarehouse.Visible = true;
                    buttonRating.Visible = true;
                    buttonService.Visible = true;
                    buttonExport.Visible = true;
                    LoadReport("SELECT o.ID_Заказа, o.НомерЗаказа, o.Дата, o.Статус, o.ИтоговаяСумма, " +
                               "COALESCE(p.Наименование, 'Без партнёра') AS Партнер, " +
                               "COALESCE(e.ФИО, 'Без сотрудника') AS Сотрудник " +
                               "FROM Orders o " +
                               "LEFT JOIN Partners p ON o.ID_Партнёра = p.ID_Партнёра " +
                               "LEFT JOIN Employees e ON o.ID_Сотрудника = e.ID_Сотрудника " +
                               "ORDER BY o.Дата DESC");
                    break;
                default:
                    break;
            }
        }

        private void LoadPartnerOrders()
        {
            string query = $"SELECT o.ID_Заказа, o.НомерЗаказа, o.Дата, o.Статус, o.ИтоговаяСумма " +
                           $"FROM Orders o " +
                           $"WHERE o.ID_Партнёра = {partnerId} " +
                           $"ORDER BY o.Дата DESC";
            LoadReport(query);
        }

        private void LoadWarehouseReport()
        {
            string query = "SELECT m.ID_Материала, m.Наименование, m.Количество, m.Стоимость " +
                           "FROM Materials m " +
                           "WHERE m.Количество > 0";
            LoadReport(query);
        }

        private void supplierMaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierMaterialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);
        }

        private void Record_Load(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void LoadReport(string query)
        {
            try
            {
                using (var db = new DataBase(connectionString))
                {
                    using (var reader = db.ExecuteReader(query))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Нет данных для отображения.");
                            dataGridViewRecord.DataSource = null;
                        }
                        else
                        {
                            dataGridViewRecord.DataSource = dt;
                            dataGridViewRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке отчёта: {ex.Message}");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (userRole == "Партнёр")
            {
                LoadPartnerOrders();
            }
            else
            {
                LoadReport("SELECT o.ID_Заказа, o.НомерЗаказа, o.Дата, o.Статус, o.ИтоговаяСумма, " +
                           "COALESCE(p.Наименование, 'Без партнёра') AS Партнер " +
                           "FROM Orders o " +
                           "LEFT JOIN Partners p ON o.ID_Партнёра = p.ID_Партнёра " +
                           "ORDER BY o.Дата DESC");
            }
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            LoadReport("SELECT m.ID_Материала, m.Наименование, m.Количество, m.Стоимость " +
                                   "FROM Materials m " +
                                   "WHERE m.Количество > 0");
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            LoadReport("SELECT p.Наименование, COALESCE(p.Рейтинг, 0) AS Рейтинг, COUNT(o.ID_Заказа) AS Количество_Заказов, " +
                                   "COALESCE(SUM(o.ИтоговаяСумма), 0) AS Общая_Сумма " +
                                   "FROM Partners p " +
                                   "LEFT JOIN Orders o ON p.ID_Партнёра = o.ID_Партнёра " +
                                   "GROUP BY p.Наименование, p.Рейтинг " +
                                   "ORDER BY p.Рейтинг DESC, Общая_Сумма DESC");
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            LoadReport("SELECT a.Наименование AS Услуга, COUNT(oi.ID_Позиции) AS Количество_Оказаний, " +
                                   "COALESCE(SUM(oi.Количество * oi.Цена), 0) AS Общая_Выручка " +
                                   "FROM Attendance a " +
                                   "LEFT JOIN OrderItems oi ON a.ID_Услуги = oi.ID_Услуги " +
                                   "GROUP BY a.Наименование " +
                                   "ORDER BY Общая_Выручка DESC");
        }

        private void LoadPartnerServiceHistory(int partnerId)
        {
            try
            {
                using (var db = new DataBase(connectionString))
                {
                    string query = @"
                SELECT 
                    a.Наименование AS Услуга,
                    oi.Количество AS Количество,
                    o.Дата AS Дата_выполнения
                FROM Orders o
                INNER JOIN OrderItems oi ON o.ID_Заказа = oi.ID_Заказа
                INNER JOIN Attendance a ON oi.ID_Услуги = a.ID_Услуги
                WHERE o.ID_Партнёра = @PartnerId
                ORDER BY o.Дата DESC";

                    SqlParameter param = new SqlParameter("@PartnerId", partnerId);
                    DataTable dt = db.GetDataTable(query, param);

                    dataGridViewRecord.DataSource = dt;
                    dataGridViewRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки истории услуг: {ex.Message}");
            }
        }

        private void LoadDataToGrid(string query)
        {
            try
            {
                using (var db = new DataBase(connectionString))
                {
                    using (var reader = db.ExecuteReader(query))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Нет данных для отображения.");
                            dataGridViewRecord.DataSource = null;
                        }
                        else
                        {
                            dataGridViewRecord.DataSource = dt;
                            dataGridViewRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridViewRecord.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                            dataGridViewRecord.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                            dataGridViewRecord.EnableHeadersVisualStyles = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecord.DataSource is DataTable dt)
            {
                string csv = string.Empty;
                foreach (DataColumn column in dt.Columns)
                {
                    csv += $"\"{column.ColumnName}\",";
                }
                csv = csv.TrimEnd(',') + "\n";

                foreach (DataRow row in dt.Rows)
                {
                    foreach (var cell in row.ItemArray)
                    {
                        csv += $"\"{cell.ToString().Replace("\"", "\"\"")}\",";
                    }
                    csv = csv.TrimEnd(',') + "\n";
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV|*.csv",
                    FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, csv, new UTF8Encoding(true));
                    MessageBox.Show("Отчёт экспортирован в CSV!");
                }
            }
            else
            {
                MessageBox.Show("Нет данных для экспорта.");
            }
        }

        private void LoadPartners()
        {
            try
            {
                using (var db = new DataBase(connectionString))
                {
                    var dt = db.GetDataTable("SELECT ID_Партнёра, Наименование FROM Partners ORDER BY Наименование");
                    comboBoxPartner.DataSource = dt;
                    comboBoxPartner.DisplayMember = "Наименование";
                    comboBoxPartner.ValueMember = "ID_Партнёра";
                    comboBoxPartner.SelectedIndex = -1; // чтобы по умолчанию ничего не было выбрано
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки партнеров: {ex.Message}");
            }
        }

        private void buttonLoadPartnerHistory_Click(object sender, EventArgs e)
        {
            if (comboBoxPartner.SelectedValue != null)
            {
                int partnerId = Convert.ToInt32(comboBoxPartner.SelectedValue);
                LoadPartnerServiceHistory(partnerId);
            }
            else
            {
                MessageBox.Show("Выберите партнёра для просмотра истории услуг.");
            }
        }

        private void LoadPartnerHistory(int partnerId)
        {
            try
            {
                using (var db = new DataBase(connectionString))
                {
                    string query = @"
                SELECT 
                    a.Наименование AS Услуга,
                    oi.Количество AS Количество,
                    o.Дата AS Дата_выполнения
                FROM Orders o
                INNER JOIN OrderItems oi ON o.ID_Заказа = oi.ID_Заказа
                INNER JOIN Attendance a ON oi.ID_Услуги = a.ID_Услуги
                WHERE o.ID_Партнёра = @PartnerId
                ORDER BY o.Дата DESC";

                    SqlParameter param = new SqlParameter("@PartnerId", partnerId);
                    DataTable dtHistory = db.GetDataTable(query, param);

                    dataGridViewRecord.DataSource = dtHistory;
                    dataGridViewRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки истории услуг: {ex.Message}");
            }
        }

        private void comboBoxPartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPartner.SelectedIndex == -1) return;

            // Получаем ID партнёра безопасно
            int selectedPartnerId = 0;
            if (comboBoxPartner.SelectedValue is int)
                selectedPartnerId = (int)comboBoxPartner.SelectedValue;
            else if (comboBoxPartner.SelectedValue is DataRowView drv)
                selectedPartnerId = Convert.ToInt32(drv["ID_Партнёра"]);

            if (selectedPartnerId > 0)
            {
                LoadPartnerHistory(selectedPartnerId);
            }
        }
    }
}
