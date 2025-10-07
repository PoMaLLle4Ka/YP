using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class AddPartner : Form
    {
        private int? partnerId;
        public AddPartner(int? id = null)
        {
            InitializeComponent();
            partnerId = id; 
        }

        private void buttonAddPartners_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamePartners.Text) || string.IsNullOrWhiteSpace(textBoxPhonePartners.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                if (partnerId.HasValue)
                {
                    // редактирование
                    string query = "UPDATE Partners SET Наименование=@name, Контакты=@contacts, Рейтинг=@rating WHERE ID_Партнёра=@id";
                    db.ExecuteNonQuery(query,
                        new SqlParameter("@name", textBoxNamePartners.Text),
                        new SqlParameter("@contacts", textBoxPhonePartners.Text),
                        new SqlParameter("@rating", numericUpDownPartners.Value),
                        new SqlParameter("@id", partnerId.Value));

                    MessageBox.Show("Партнер изменен!");
                }
                else
                {
                    // добавление
                    string query = "INSERT INTO Partners (Наименование, Контакты, Рейтинг) VALUES (@name, @contacts, @rating); SELECT SCOPE_IDENTITY();";
                    int newId = Convert.ToInt32(db.ExecuteScalar(query,
                        new SqlParameter("@name", textBoxNamePartners.Text),
                        new SqlParameter("@contacts", textBoxPhonePartners.Text),
                        new SqlParameter("@rating", numericUpDownPartners.Value)));

                    // создаём пользователя
                    string login = GenerateLogin(textBoxNamePartners.Text);
                    string password = "12345";
                    string role = "Партнёр";

                    string insertUser = "INSERT INTO Users (Логин, Пароль, Роль, ID_Партнёра) VALUES (@login, @password, @role, @id)";
                    db.ExecuteNonQuery(insertUser,
                        new SqlParameter("@login", login),
                        new SqlParameter("@password", password),
                        new SqlParameter("@role", role),
                        new SqlParameter("@id", newId));

                    MessageBox.Show($"Партнер добавлен!\nЛогин: {login}\nПароль: {password}");
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private string GenerateLogin(string name)
        {
            var translit = new System.Collections.Generic.Dictionary<char, string>()
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
                if (translit.ContainsKey(c)) result += translit[c];
                else if (c == ' ') result += '.';
                else result += c;
            }
            return result;
        }

        private void AddPartner_Load(object sender, EventArgs e)
        {
            if (partnerId.HasValue)
            {
                LoadPartner(partnerId.Value);
            }
        }
        private void LoadPartner(int id)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT * FROM Partners WHERE ID_Партнёра=@id";
                using (var reader = db.ExecuteReader(query, new SqlParameter("@id", id)))
                {
                    if (reader.Read())
                    {
                        textBoxNamePartners.Text = reader["Наименование"].ToString();
                        textBoxPhonePartners.Text = reader["Контакты"].ToString();
                        numericUpDownPartners.Value = Convert.ToDecimal(reader["Рейтинг"]);
                    }
                }
            }
        }
    }
}
