using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class AllUsers : Form
    {
        string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

        public AllUsers()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.ромашенко_УПDataSet.Users);
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите пользователя для изменения!");
                return;
            }

            int id = Convert.ToInt32(usersDataGridView.CurrentRow.Cells[0].Value);
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Все поля (Логин, Пароль) должны быть заполнены!");
                return;
            }

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET Логин=@login, Пароль=@password WHERE ID_User=@id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Данные пользователя успешно обновлены!");
                    else
                        MessageBox.Show("Ошибка: пользователь не найден.");
                }
            }
            this.usersTableAdapter.Fill(this.ромашенко_УПDataSet.Users);
        }
    }
}
