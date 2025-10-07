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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ромашенко_УПDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.ромашенко_УПDataSet.Suppliers);
        }
        private void LoadSuppliers()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT * FROM Suppliers";
                using (var reader = db.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    suppliersDataGridView.DataSource = dt;
                }
            }
        }

        private void buttonAddSuppliers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (string.IsNullOrWhiteSpace(textBoxNameSuppliers.Text) || string.IsNullOrWhiteSpace(textBoxPhoneSuppliers.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (var db = new DataBase(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Suppliers WHERE Наименование=@Name";
                int count = (int)db.ExecuteScalar(checkQuery, new SqlParameter("@Name", textBoxNameSuppliers.Text));

                if (count > 0)
                {
                    MessageBox.Show("Поставщик с таким наименованием уже существует!");
                    return;
                }

                string query = "INSERT INTO Suppliers (Наименование, Телефон, Рейтинг) VALUES (@Name, @phone, @rating); SELECT SCOPE_IDENTITY();";
                int newId = Convert.ToInt32(db.ExecuteScalar(query,
                    new SqlParameter("@Name", textBoxNameSuppliers.Text),
                    new SqlParameter("@phone", textBoxPhoneSuppliers.Text),
                    new SqlParameter("@rating", numericUpDownRaitingSuppliers.Value)));

                string login = GenerateLogin(textBoxNameSuppliers.Text);
                string password = "12345";
                string role = "Поставщик";

                string insertUser = "INSERT INTO Users (Логин, Пароль, Роль, ID_Поставщика) VALUES (@login, @password, @role, @id)";
                db.ExecuteNonQuery(insertUser,
                    new SqlParameter("@login", login),
                    new SqlParameter("@password", password),
                    new SqlParameter("@role", role),
                    new SqlParameter("@id", newId));
                MessageBox.Show($"Партнёр добавлен и создан пользователь!\nЛогин: {login}\nПароль: {password}");
            }
            LoadSuppliers();
        }

        private void buttonChangeSuppliers_Click(object sender, EventArgs e)
        {
            if (suppliersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите поставщика для изменения!");
                return;
            }

            int id = Convert.ToInt32(suppliersDataGridView.CurrentRow.Cells[0].Value);

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "UPDATE Suppliers SET Наименование=@name, Телефон=@phone, Рейтинг=@rating WHERE ID_Поставщика=@id";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@name", textBoxNameSuppliers.Text),
                    new SqlParameter("@phone", textBoxPhoneSuppliers.Text),
                    new SqlParameter("@rating", numericUpDownRaitingSuppliers.Value),
                    new SqlParameter("@id", id));
            }

            MessageBox.Show("Поставщик изменен!");
            LoadSuppliers();
        }

        private void buttonRemoveSuppliers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (suppliersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите поставщика для удаления!");
                return;
            }

            int id = Convert.ToInt32(suppliersDataGridView.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Удалить выбранного поставщика?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataBase(connectionString))
                {
                    string checkSupplies = "SELECT COUNT(*) FROM SupplierMaterials WHERE ID_Материала = @id";
                    int countSupplies = Convert.ToInt32(db.ExecuteScalar(checkSupplies, new SqlParameter("@id", id)));


                    if (countSupplies > 0)
                    {
                        MessageBox.Show("Невозможно удалить: Поставщик используется в поставках!");
                        return;
                    }

                    string deleteQuery = "DELETE FROM Suppliers WHERE ID_Поставщика = @id";
                    db.ExecuteNonQuery(deleteQuery, new SqlParameter("@id", id));
                }

                MessageBox.Show("Поставщик удален!");
                LoadSuppliers();
            }
        }

        private void suppliersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = suppliersDataGridView.Rows[e.RowIndex];

                textBoxNameSuppliers.Text = row.Cells[1].Value?.ToString();
                textBoxPhoneSuppliers.Text = row.Cells[2].Value?.ToString();
                numericUpDownRaitingSuppliers.Text = row.Cells[3].Value?.ToString();
            }
        }

        private string GenerateLogin(string name)
        {
            Dictionary<char, string> translit = new Dictionary<char, string>()
    {
        {'а',"a"},{'б',"b"},{'в',"v"},{'г',"g"},{'д',"d"},{'е',"e"},{'ё',"e"},
        {'ж',"zh"},{'з',"z"},{'и',"i"},{'й',"y"},{'к',"k"},{'л',"l"},{'м',"m"},
        {'н',"n"},{'о',"o"},{'п',"p"},{'р',"r"},{'с',"s"},{'т',"t"},{'у',"u"},
        {'ф',"f"},{'х',"h"},{'ц',"c"},{'ч',"ch"},{'ш',"sh"},{'щ',"sch"},{'ъ',""},
        {'ы',"y"},{'ь',""},{'э',"e"},{'ю',"yu"},{'я',"ya"}
    };

            name = name.ToLower();
            string result = "";

            foreach (char c in name)
            {
                if (translit.ContainsKey(c))
                    result += translit[c];
                else if (c == ' ')
                    result += '.';
                else
                    result += c;
            }

            return result;
        }
    }
}
