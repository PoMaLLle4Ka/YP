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
    public partial class Login : Form
    {
        public static int? CurrentPartnerId = null;
        public static string CurrentUserRole = "";
        public static string CurrentUserName = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            try
            {
                using (DataBase db = new DataBase(connectionString))
                {
                    string sql = @"
                SELECT 
                    u.ID_User, 
                    u.Роль, 
                    u.ID_Сотрудника,
                    u.ID_Партнёра,
                    u.ID_Поставщика,
                    e.ФИО AS EmployeeName, 
                    p.Наименование AS PartnerName, 
                    s.Наименование AS SupplierName
                FROM Users u
                LEFT JOIN Employees e ON u.ID_Сотрудника = e.ID_Сотрудника
                LEFT JOIN Partners p ON u.ID_Партнёра = p.ID_Партнёра
                LEFT JOIN Suppliers s ON u.ID_Поставщика = s.ID_Поставщика
                WHERE u.Логин = @login AND u.Пароль = @password";

                    using (SqlDataReader reader = db.ExecuteReader(sql,
                        new SqlParameter("@login", login),
                        new SqlParameter("@password", password)))
                    {
                        if (reader.Read())
                        {
                            string role = reader["Роль"].ToString();
                            string name = "";

                            if (role == "Сотрудник" || role == "Администратор")
                                name = reader["EmployeeName"].ToString();
                            else if (role == "Партнёр")
                                name = reader["PartnerName"].ToString();
                            else if (role == "Поставщик")
                                name = reader["SupplierName"].ToString();

                            CurrentUserRole = role;
                            CurrentUserName = name;
                            CurrentPartnerId = reader["ID_Партнёра"] != DBNull.Value
                                ? Convert.ToInt32(reader["ID_Партнёра"])
                                : (int?)null;

                            MessageBox.Show($"Добро пожаловать, {name} ({role})!");

                            if (role == "Партнёр" && CurrentPartnerId.HasValue)
                            {
                                ShowPartnerNotifications(CurrentPartnerId.Value);
                            }

                            Main mainForm = new Main(role, login);
                            mainForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        private void ShowPartnerNotifications(int partnerId)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT НомерЗаказа, Статус, ИтоговаяСумма, Дата FROM Orders WHERE ID_Партнёра = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", partnerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("У вас пока нет заказов.", "Информация");
                            return;
                        }

                        StringBuilder sb = new StringBuilder("Ваши заказы:\n\n");

                        while (reader.Read())
                        {
                            string number = reader["НомерЗаказа"].ToString();
                            string status = reader["Статус"].ToString();
                            string sum = Convert.ToDecimal(reader["ИтоговаяСумма"]).ToString("C");
                            DateTime date = Convert.ToDateTime(reader["Дата"]);

                            sb.AppendLine($"Заказ №{number} ({date:dd.MM.yyyy}) — {status}, сумма: {sum}");
                        }

                        MessageBox.Show(sb.ToString(), "Статусы ваших заказов");
                    }
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
