using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        private string userRole;
        private string currentUserLogin;
        public Main(string role, string login)
        {
            InitializeComponent();
            userRole = role;
            currentUserLogin = login;
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {

            foreach (Button btn in new Button[] { btnServices, btnPartners, btnEmployees, btnMaterials, btnSuppliers, btnOrders, btnWarehouse, btnHistory, btnUsers })
            {
                if (btn != null) btn.Visible = false;
            }
            switch (userRole)
            {
                case "Админ":
                    SetButtonsVisible(true, btnServices, btnPartners, btnEmployees, btnMaterials, btnSuppliers, btnOrders, btnWarehouse, btnHistory, btnUsers);
                    break;

                case "Сотрудник":
                    SetButtonsVisible(true, btnServices, btnMaterials, btnOrders, btnWarehouse, btnHistory);
                    break;

                case "Поставщик":
                    SetButtonsVisible(true, btnHistory);
                    break;

                case "Партнёр":
                    SetButtonsVisible(true, btnHistory);
                    break;

                default:
                    break;
            }
        }

        private void SetButtonsVisible(bool visible, params Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                if (btn != null) btn.Visible = visible;
            }
        }

        private int GetPartnerIdForUser()
        {
            int partnerId = 0;
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";
            string query = $"SELECT ID_Партнёра FROM Users WHERE Логин = '{currentUserLogin}'";

            try
            {
                using (var db = new DataBase(connectionString))
                {
                    object result = db.ExecuteScalar(query);
                    if (result != null && int.TryParse(result.ToString(), out int id))
                        partnerId = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении ID партнёра: {ex.Message}");
            }

            return partnerId;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            Partners partners = new Partners();
            partners.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            materials.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                Record recordForm;

                switch (userRole)
                {
                    case "Партнёр":
                        if (!Login.CurrentPartnerId.HasValue)
                        {
                            MessageBox.Show("Ошибка: ID партнёра не найден. Проверьте данные пользователя.");
                            return;
                        }
                        recordForm = new Record(userRole, Login.CurrentPartnerId.Value);
                        break;

                    default:
                        recordForm = new Record(userRole);
                        break;
                }

                recordForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии отчёта: {ex.Message}");
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AllUsers users = new AllUsers();
            users.Show();
        }
    }
}
