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
using System.Xml.Linq;

namespace Project
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void attendanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Services_Load(object sender, EventArgs e)
        {
            LoadServices();

        }

        private void LoadServices()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT * FROM Attendance";
                using (var reader = db.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    attendanceDataGridView.DataSource = dt;
                }
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (string.IsNullOrWhiteSpace(textBoxNameService.Text) || string.IsNullOrWhiteSpace(textBoxPriceService.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (var db = new DataBase(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE Наименование=@name";
                int count = (int)db.ExecuteScalar(checkQuery, new SqlParameter("@name", textBoxNameService.Text));

                if (count > 0)
                {
                    MessageBox.Show("Услуга с таким наименованием уже существует!");
                    return;
                }

                string query = "INSERT INTO Attendance (Наименование, Стоимость) VALUES (@name, @price)";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@name", textBoxNameService.Text),
                    new SqlParameter("@price", decimal.Parse(textBoxPriceService.Text)));
            }

            MessageBox.Show("Услуга добавлена!");
            LoadServices();
        }

        private void buttonChangeService_Click(object sender, EventArgs e)
        {
            if (attendanceDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите услугу для изменения!");
                return;
            }

            int id = Convert.ToInt32(attendanceDataGridView.CurrentRow.Cells[0].Value);

            if (!decimal.TryParse(textBoxPriceService.Text,
                                  System.Globalization.NumberStyles.Any,
                                  System.Globalization.CultureInfo.CurrentCulture,
                                  out decimal price))
            {
                MessageBox.Show("Введите корректную стоимость услуги!");
                return;
            }

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "UPDATE Attendance SET Наименование=@name, Стоимость=@price WHERE ID_Услуги=@id";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@name", textBoxNameService.Text),
                    new SqlParameter("@price", price),
                    new SqlParameter("@id", id));
            }

            MessageBox.Show("Услуга изменена!");
            LoadServices();
        }

        private void buttonRemoveService_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (attendanceDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите услугу для удаления!");
                return;
            }

            int id = Convert.ToInt32(attendanceDataGridView.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Удалить выбранную услугу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataBase(connectionString))
                {
                    string query = "DELETE FROM Attendance WHERE ID_Услуги=@id";
                    db.ExecuteNonQuery(query, new SqlParameter("@id", id));
                }

                MessageBox.Show("Услуга удалена!");
                LoadServices();
            }
        }

        private void attendanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = attendanceDataGridView.Rows[e.RowIndex];

                textBoxNameService.Text = row.Cells[1].Value?.ToString();
                textBoxPriceService.Text = row.Cells[2].Value?.ToString();
            }
        }
    }
}
