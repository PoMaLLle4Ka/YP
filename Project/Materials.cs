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

namespace Project
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Materials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ромашенко_УПDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.ромашенко_УПDataSet.Materials);

        }

        private void LoadServices()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT * FROM Materials";
                using (var reader = db.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    materialsDataGridView.DataSource = dt;
                }
            }
        }

        private void materialsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = materialsDataGridView.Rows[e.RowIndex];

                textBoxNameMaterial.Text = row.Cells[1].Value?.ToString();
                textBoxCountMaterial.Text = row.Cells[2].Value?.ToString();
                textBoxCostMaterial.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (string.IsNullOrWhiteSpace(textBoxNameMaterial.Text) ||
                string.IsNullOrWhiteSpace(textBoxCountMaterial.Text) ||
                string.IsNullOrWhiteSpace(textBoxCostMaterial.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (!int.TryParse(textBoxCountMaterial.Text, out int count))
            {
                MessageBox.Show("Количество должно быть числом!");
                return;
            }

            if (!decimal.TryParse(textBoxCostMaterial.Text, out decimal cost))
            {
                MessageBox.Show("Стоимость должна быть числом!");
                return;
            }

            using (var db = new DataBase(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Materials WHERE Наименование=@Name AND Стоимость=@Cost";
                int existingCount = Convert.ToInt32(db.ExecuteScalar(checkQuery,
                    new SqlParameter("@Name", textBoxNameMaterial.Text),
                    new SqlParameter("@Cost", cost)));

                if (existingCount > 0)
                {
                    MessageBox.Show("Материал с таким наименованием и ценой уже существует!");
                    return;
                }

                string query = "INSERT INTO Materials (Наименование, Количество, Стоимость) VALUES (@Name, @Count, @Cost)";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@Name", textBoxNameMaterial.Text),
                    new SqlParameter("@Count", count),
                    new SqlParameter("@Cost", cost));
            }

            MessageBox.Show("Материал добавлен!");
            LoadServices();
        }

        private void buttonChangeMaterial_Click(object sender, EventArgs e)
        {
            if (materialsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите материал для изменения!");
                return;
            }

            if (!int.TryParse(textBoxCountMaterial.Text, out int count))
            {
                MessageBox.Show("Количество должно быть числом!");
                return;
            }

            if (!decimal.TryParse(textBoxCostMaterial.Text, out decimal cost))
            {
                MessageBox.Show("Стоимость должна быть числом!");
                return;
            }

            int id = Convert.ToInt32(materialsDataGridView.CurrentRow.Cells[0].Value);

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "UPDATE Materials SET Наименование=@Name, Количество=@count, Стоимость=@Cost WHERE ID_Материала=@id";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@Name", textBoxNameMaterial.Text),
                    new SqlParameter("@count", count),
                    new SqlParameter("@Cost", cost),
                    new SqlParameter("@id", id));
            }

            MessageBox.Show("Данные материала изменены!");
            LoadServices();
        }

        private void buttonRemoveMaterial_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (materialsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите материал для удаления!");
                return;
            }

            int id = Convert.ToInt32(materialsDataGridView.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Удалить выбранный материал?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataBase(connectionString))
                {
                    string checkSupplies = "SELECT COUNT(*) FROM SupplierMaterials WHERE ID_Материала = @id";
                    int countSupplies = Convert.ToInt32(db.ExecuteScalar(checkSupplies, new SqlParameter("@id", id)));

                    string checkServices = "SELECT COUNT(*) FROM ServiceMaterials WHERE ID_Материала = @id";
                    int countServices = Convert.ToInt32(db.ExecuteScalar(checkServices, new SqlParameter("@id", id)));

                    if (countSupplies + countServices > 0)
                    {
                        MessageBox.Show("Невозможно удалить: материал используется в поставках или услугах!");
                        return;
                    }

                    string deleteQuery = "DELETE FROM Materials WHERE ID_Материала = @id";
                    db.ExecuteNonQuery(deleteQuery, new SqlParameter("@id", id));
                }

                MessageBox.Show("Материал удален!");
                LoadServices();
            }
        }
    }
}
