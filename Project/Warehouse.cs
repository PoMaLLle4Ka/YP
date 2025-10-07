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
    public partial class Warehouse : Form
    {
        private string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";
        public Warehouse()
        {
            InitializeComponent();
        }

        private void serviceMaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceMaterialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            try
            {
                if (materialsTableAdapter == null || serviceMaterialsTableAdapter == null)
                {
                    MessageBox.Show("Один или несколько TableAdapter не инициализированы!");
                    return;
                }

                this.materialsTableAdapter.Fill(this.ромашенко_УПDataSet.Materials);
                this.serviceMaterialsTableAdapter.Fill(this.ромашенко_УПDataSet.ServiceMaterials);
                LoadMaterials();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }

        }

        private void LoadMaterials()
        {
            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT ID_Материала, Наименование, Количество, Стоимость FROM Materials";
                using (var reader = db.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                }
            }
        }

        private void buttonPostuplenie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameMaterial.Text) || numericUpDownQuantity.Value <= 0 ||
                string.IsNullOrWhiteSpace(textBoxCost.Text) || !decimal.TryParse(textBoxCost.Text, out decimal cost))
            {
                MessageBox.Show("Заполните наименование материала, количество и стоимость (допустимы только числовые значения для стоимости)!");
                return;
            }

            using (var db = new DataBase(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Materials WHERE Наименование = @Name";
                int count = (int)db.ExecuteScalar(checkQuery, new SqlParameter("@Name", textBoxNameMaterial.Text));

                if (count == 0)
                {
                    string insertQuery = "INSERT INTO Materials (Наименование, Количество, Стоимость) " +
                                        "VALUES (@Name, @Quantity, @Cost)";
                    db.ExecuteNonQuery(insertQuery,
                        new SqlParameter("@Name", textBoxNameMaterial.Text),
                        new SqlParameter("@Quantity", numericUpDownQuantity.Value),
                        new SqlParameter("@Cost", cost));
                }
                else
                {
                    string updateQuery = "UPDATE Materials SET Количество = Количество + @Quantity, Стоимость = @Cost WHERE Наименование = @Name";
                    db.ExecuteNonQuery(updateQuery,
                        new SqlParameter("@Quantity", numericUpDownQuantity.Value),
                        new SqlParameter("@Cost", cost),
                        new SqlParameter("@Name", textBoxNameMaterial.Text));
                }
            }

            MessageBox.Show("Материал успешно добавлен на склад!");
            LoadMaterials();
            ClearFields();
        }

        private void buttonSpisanie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameMaterial.Text) || numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Укажите наименование материала и количество для списания!");
                return;
            }

            using (var db = new DataBase(connectionString))
            {
                string checkQuery = "SELECT Количество FROM Materials WHERE Наименование = @Name";
                using (var reader = db.ExecuteReader(checkQuery, new SqlParameter("@Name", textBoxNameMaterial.Text)))
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Материал не найден!");
                        return;
                    }

                    decimal currentQuantity = reader.GetDecimal(0);
                    decimal quantityToWriteOff = numericUpDownQuantity.Value;

                    if (quantityToWriteOff > currentQuantity)
                    {
                        MessageBox.Show("Недостаточно материалов для списания!");
                        return;
                    }

                    string updateQuery = "UPDATE Materials SET Количество = Количество - @Quantity WHERE Наименование = @Name";
                    db.ExecuteNonQuery(updateQuery,
                        new SqlParameter("@Quantity", quantityToWriteOff),
                        new SqlParameter("@Name", textBoxNameMaterial.Text));
                }
            }

            MessageBox.Show("Материал успешно списан!");
            LoadMaterials();
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxNameMaterial.Clear();
            numericUpDownQuantity.Value = 1;
            textBoxCost.Clear();
        }
    }
}
