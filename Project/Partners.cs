using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Partners : Form
    {
        public Partners()
        {
            InitializeComponent();
        }

        private void partnersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partnersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ромашенко_УПDataSet);

        }

        private void Partners_Load(object sender, EventArgs e)
        {
            LoadServices();

        }
        private void LoadServices()
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            using (var db = new DataBase(connectionString))
            {
                string query = "SELECT * FROM Partners";
                using (var reader = db.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    partnersDataGridView.DataSource = dt;
                }
            }
        }

        private void buttonAddPartners_Click(object sender, EventArgs e)
        {
            using (AddPartner form = new AddPartner())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadServices();
                }
            }
        }

        private void buttonChangePartners_Click(object sender, EventArgs e)
        {
            if (partnersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите партнера для изменения!");
                return;
            }

            int id = Convert.ToInt32(partnersDataGridView.CurrentRow.Cells[0].Value);

            using (AddPartner form = new AddPartner(id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadServices(); 
                }
            }
        }

        private void buttonRemovePartners_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=Ромашенко_УП;Integrated Security=True;Encrypt=False";

            if (partnersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите партнера для удаления!");
                return;
            }

            int id = Convert.ToInt32(partnersDataGridView.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Удалить выбранного партнера?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataBase(connectionString))
                {
                    string query = "DELETE FROM Partners WHERE ID_Партнёра=@id";
                    db.ExecuteNonQuery(query, new SqlParameter("@id", id));
                }

                MessageBox.Show("Партнер удален!");
                LoadServices();
            }
        }

        private void partnersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(partnersDataGridView.Rows[e.RowIndex].Cells[0].Value);
                using (AddPartner form = new AddPartner(id))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadServices();
                    }
                }
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
