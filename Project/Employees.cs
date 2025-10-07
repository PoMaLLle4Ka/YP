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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ромашенко_УПDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.ромашенко_УПDataSet.Employees);

        }

        private void LoadServices()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT * FROM Employees";
                using (var reader = db.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    employeesDataGridView.DataSource = dt;
                }
            }
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (string.IsNullOrWhiteSpace(textBoxFIOEmployees.Text) || string.IsNullOrWhiteSpace(textBoxRoleEmployees.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (var db = new DataBase(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE ФИО=@FIO";
                int count = (int)db.ExecuteScalar(checkQuery, new SqlParameter("@FIO", textBoxFIOEmployees.Text));

                if (count > 0)
                {
                    MessageBox.Show("Сотрудник с таким ФИО уже существует!");
                    return;
                }

                string query = "INSERT INTO Employees (ФИО, Должность) VALUES (@FIO, @role); SELECT SCOPE_IDENTITY();";
                int newId = Convert.ToInt32(db.ExecuteScalar(query,
                    new SqlParameter("@FIO", textBoxFIOEmployees.Text),
                    new SqlParameter("@role", textBoxRoleEmployees.Text)));

                string login = GenerateLogin(textBoxFIOEmployees.Text);
                string password = "12345";
                string role = "Сотрудник";

                string insertUser = "INSERT INTO Users (Логин, Пароль, Роль, ID_Сотрудника) VALUES (@login, @password, @role, @id)";
                db.ExecuteNonQuery(insertUser,
                    new SqlParameter("@login", login),
                    new SqlParameter("@password", password),
                    new SqlParameter("@role", role),
                    new SqlParameter("@id", newId));
                MessageBox.Show($"Партнёр добавлен и создан пользователь!\nЛогин: {login}\nПароль: {password}");
            }

            LoadServices();
        }

        private void buttonChangeEmployees_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите сотрудника для изменения!");
                return;
            }

            int id = Convert.ToInt32(employeesDataGridView.CurrentRow.Cells[0].Value);

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "UPDATE Employees SET ФИО=@FIO, Должность=@role WHERE ID_Сотрудника=@id";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@FIO", textBoxFIOEmployees.Text),
                    new SqlParameter("@role", textBoxRoleEmployees.Text),
                    new SqlParameter("@id", id));
            }

            MessageBox.Show("Данные сотрудника изменены!");
            LoadServices();
        }

        private void buttonRemoveEmployees_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (employeesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите сотрудника для удаления!");
                return;
            }

            int id = Convert.ToInt32(employeesDataGridView.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Удалить выбранного сотрудника?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataBase(connectionString))
                {
                    string query = "DELETE FROM Employees WHERE ID_Сотрудника=@id";
                    db.ExecuteNonQuery(query, new SqlParameter("@id", id));
                }

                MessageBox.Show("Сотрудник удален!");
                LoadServices();
            }
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employeesDataGridView.Rows[e.RowIndex];

                textBoxFIOEmployees.Text = row.Cells[1].Value?.ToString();
                textBoxRoleEmployees.Text = row.Cells[2].Value?.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
