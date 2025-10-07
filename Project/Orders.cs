using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibraryProject;

namespace Project
{
    public partial class Orders : Form
    {
        private int currentOrderId;
        private List<(int ServiceId, decimal Quantity, decimal Price)> orderItems;
        public Orders()
        {
            InitializeComponent();
            orderItems = new List<(int, decimal, decimal)>();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                if (partnersTableAdapter == null || employeesTableAdapter == null || attendanceTableAdapter == null)
                {
                    MessageBox.Show("Один или несколько TableAdapter не инициализированы!");
                    return;
                }

                this.ordersTableAdapter.Fill(this.ромашенко_УПDataSet.Orders);
                this.partnersTableAdapter.Fill(this.ромашенко_УПDataSet.Partners);
                this.employeesTableAdapter.Fill(this.ромашенко_УПDataSet.Employees);
                this.attendanceTableAdapter.Fill(this.ромашенко_УПDataSet.Attendance);

                comboBoxPartner.DataSource = this.ромашенко_УПDataSet.Partners;
                comboBoxPartner.DisplayMember = "Наименование";
                comboBoxPartner.ValueMember = "ID_Партнёра";

                comboBoxEmployee.DataSource = this.ромашенко_УПDataSet.Employees;
                comboBoxEmployee.DisplayMember = "ФИО";
                comboBoxEmployee.ValueMember = "ID_Сотрудника";

                comboBoxService.DataSource = this.ромашенко_УПDataSet.Attendance;
                comboBoxService.DisplayMember = "Наименование";
                comboBoxService.ValueMember = "ID_Услуги";

                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void LoadOrders()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT o.ID_Заказа, o.НомерЗаказа, o.Дата, o.Статус, o.ИтоговаяСумма, " +
                               "o.ID_Партнёра, o.ID_Сотрудника, " +
                               "p.Наименование AS Партнер, e.ФИО AS Сотрудник " +
                               "FROM Orders o " +
                               "LEFT JOIN Partners p ON o.ID_Партнёра = p.ID_Партнёра " +
                               "LEFT JOIN Employees e ON o.ID_Сотрудника = e.ID_Сотрудника";

                List<SqlParameter> parameters = new List<SqlParameter>();

                if (Login.CurrentUserRole == "Партнёр" && Login.CurrentPartnerId.HasValue)
                {
                    query += " WHERE o.ID_Партнёра = @PartnerId";
                    parameters.Add(new SqlParameter("@PartnerId", Login.CurrentPartnerId.Value));
                }

                using (var reader = db.ExecuteReader(query, parameters.ToArray()))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    ordersDataGridView.DataSource = dt;
                    ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }


        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBoxPartner.SelectedValue == null ||
                comboBoxEmployee.SelectedValue == null || orderItems.Count == 0)
            {
                MessageBox.Show("Заполните все поля: номер заказа, партнер, сотрудник и добавьте хотя бы одну услугу!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Проверка уникальности номера заказа
                    string checkQuery = "SELECT COUNT(*) FROM Orders WHERE НомерЗаказа = @Number";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@Number", textBox1.Text);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Заказ с таким номером уже существует!");
                            transaction.Rollback();
                            return;
                        }
                    }

                    // Вставка заказа
                    string orderQuery = "INSERT INTO Orders (НомерЗаказа, Дата, Статус, ИтоговаяСумма, ID_Партнёра, ID_Сотрудника) " +
                                        "VALUES (@Number, @Date, @Status, 0, @PartnerId, @EmployeeId); SELECT SCOPE_IDENTITY()";
                    int orderId;
                    using (SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction))
                    {
                        orderCmd.Parameters.AddWithValue("@Number", textBox1.Text);
                        orderCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                        orderCmd.Parameters.AddWithValue("@Status", comboBox1.SelectedItem?.ToString() ?? "Новый");
                        orderCmd.Parameters.AddWithValue("@PartnerId", comboBoxPartner.SelectedValue);
                        orderCmd.Parameters.AddWithValue("@EmployeeId", comboBoxEmployee.SelectedValue);
                        orderId = Convert.ToInt32(orderCmd.ExecuteScalar());
                    }

                    decimal totalCost = 0;

                    foreach (var item in orderItems)
                    {
                        // Вставка позиции заказа
                        string itemQuery = "INSERT INTO OrderItems (Количество, Цена, ID_Заказа, ID_Услуги) " +
                                           "VALUES (@Quantity, @Price, @OrderId, @ServiceId)";
                        using (SqlCommand itemCmd = new SqlCommand(itemQuery, conn, transaction))
                        {
                            itemCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            itemCmd.Parameters.AddWithValue("@Price", item.Price);
                            itemCmd.Parameters.AddWithValue("@OrderId", orderId);
                            itemCmd.Parameters.AddWithValue("@ServiceId", item.ServiceId);
                            itemCmd.ExecuteNonQuery();
                        }

                        totalCost += item.Quantity * item.Price;

                        // Списание материалов через библиотеку
                        MaterialHelper.DeductMaterials(item.ServiceId, item.Quantity, conn, transaction);
                    }

                    // Обновление итоговой суммы заказа
                    string updateQuery = "UPDATE Orders SET ИтоговаяСумма = @Total WHERE ID_Заказа = @OrderId";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Total", totalCost);
                        updateCmd.Parameters.AddWithValue("@OrderId", orderId);
                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Заказ успешно добавлен!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message);
                }
            }

            // Очистка формы
            orderItems.Clear();
            listBoxServices.Items.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = 1;

            LoadOrders();
        }


        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите заказ для изменения статуса!");
                return;
            }

            int id = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells[0].Value);

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "UPDATE Orders SET Статус = @Status WHERE ID_Заказа = @id";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@Status", comboBox1.SelectedItem?.ToString() ?? "Новый"),
                    new SqlParameter("@id", id));
            }

            MessageBox.Show("Статус заказа изменен!");
            LoadOrders();
        }

        private void buttonRemoveOrder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (ordersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите заказ для удаления!");
                return;
            }

            int id = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Удалить выбранный заказ?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataBase(connectionString))
                {
                    string itemQuery = "DELETE FROM OrderItems WHERE ID_Заказа = @id";
                    db.ExecuteNonQuery(itemQuery, new SqlParameter("@id", id));

                    string orderQuery = "DELETE FROM Orders WHERE ID_Заказа = @id";
                    db.ExecuteNonQuery(orderQuery, new SqlParameter("@id", id));
                }

                MessageBox.Show("Заказ удален!");
                LoadOrders();
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (comboBoxService.SelectedValue == null || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Выберите услугу и укажите количество больше 0!");
                return;
            }

            int serviceId = (int)comboBoxService.SelectedValue;
            decimal quantity = numericUpDown1.Value;
            decimal price = (decimal)(this.ромашенко_УПDataSet.Attendance.FindByID_Услуги(serviceId))["Стоимость"];

            orderItems.Add((serviceId, quantity, price));
            listBoxServices.Items.Add($"{comboBoxService.Text} - {quantity} ед. - {price:C}");

            MessageBox.Show($"Услуга добавлена: {comboBoxService.Text}, Количество: {quantity}");
            numericUpDown1.Value = 1;
        }

        private void DeductMaterialsForService(int serviceId, decimal serviceCount, SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"
        SELECT sm.ID_Материала, sm.НормаРасхода, m.Количество
        FROM ServiceMaterials sm
        INNER JOIN Materials m ON sm.ID_Материала = m.ID_Материала
        WHERE sm.ID_Услуги = @ServiceId";

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@ServiceId", serviceId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    var materialsToDeduct = new List<(int MaterialId, int UsedQuantity)>();

                    while (reader.Read())
                    {
                        int materialId = reader.GetInt32(0);
                        decimal norma = reader.GetDecimal(1);
                        int currentQuantity = reader.GetInt32(2);

                        int usedQuantity = (int)Math.Ceiling(norma * serviceCount);

                        if (usedQuantity > currentQuantity)
                            throw new Exception($"Недостаточно материала (ID={materialId}) для услуги ID={serviceId}");

                        materialsToDeduct.Add((materialId, usedQuantity));
                    }

                    reader.Close();

                    foreach (var m in materialsToDeduct)
                    {
                        string updateQuery = "UPDATE Materials SET Количество = Количество - @Used WHERE ID_Материала = @MaterialId";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@Used", m.UsedQuantity);
                            updateCmd.Parameters.AddWithValue("@MaterialId", m.MaterialId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
