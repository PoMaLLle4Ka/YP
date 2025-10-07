namespace Project
{
    partial class Suppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemoveSuppliers = new System.Windows.Forms.Button();
            this.buttonChangeSuppliers = new System.Windows.Forms.Button();
            this.buttonAddSuppliers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhoneSuppliers = new System.Windows.Forms.TextBox();
            this.textBoxNameSuppliers = new System.Windows.Forms.TextBox();
            this.numericUpDownRaitingSuppliers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRaitingSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.ServiceMaterialsTableAdapter = null;
            this.tableAdapterManager.SupplierMaterialsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AllowUserToAddRows = false;
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(12, 33);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.RowHeadersVisible = false;
            this.suppliersDataGridView.Size = new System.Drawing.Size(504, 355);
            this.suppliersDataGridView.TabIndex = 1;
            this.suppliersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Поставщика";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Поставщика";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Рейтинг";
            this.dataGridViewTextBoxColumn4.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // buttonRemoveSuppliers
            // 
            this.buttonRemoveSuppliers.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRemoveSuppliers.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveSuppliers.Location = new System.Drawing.Point(308, 398);
            this.buttonRemoveSuppliers.Name = "buttonRemoveSuppliers";
            this.buttonRemoveSuppliers.Size = new System.Drawing.Size(142, 40);
            this.buttonRemoveSuppliers.TabIndex = 14;
            this.buttonRemoveSuppliers.Text = "Удалить";
            this.buttonRemoveSuppliers.UseVisualStyleBackColor = false;
            this.buttonRemoveSuppliers.Click += new System.EventHandler(this.buttonRemoveSuppliers_Click);
            // 
            // buttonChangeSuppliers
            // 
            this.buttonChangeSuppliers.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChangeSuppliers.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeSuppliers.Location = new System.Drawing.Point(160, 398);
            this.buttonChangeSuppliers.Name = "buttonChangeSuppliers";
            this.buttonChangeSuppliers.Size = new System.Drawing.Size(142, 40);
            this.buttonChangeSuppliers.TabIndex = 13;
            this.buttonChangeSuppliers.Text = "Изменить";
            this.buttonChangeSuppliers.UseVisualStyleBackColor = false;
            this.buttonChangeSuppliers.Click += new System.EventHandler(this.buttonChangeSuppliers_Click);
            // 
            // buttonAddSuppliers
            // 
            this.buttonAddSuppliers.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddSuppliers.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSuppliers.Location = new System.Drawing.Point(12, 398);
            this.buttonAddSuppliers.Name = "buttonAddSuppliers";
            this.buttonAddSuppliers.Size = new System.Drawing.Size(142, 40);
            this.buttonAddSuppliers.TabIndex = 12;
            this.buttonAddSuppliers.Text = "Добавить";
            this.buttonAddSuppliers.UseVisualStyleBackColor = false;
            this.buttonAddSuppliers.Click += new System.EventHandler(this.buttonAddSuppliers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(537, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Рейтинг поставщика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(537, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Телефон поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(537, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Наименование поставщика";
            // 
            // textBoxPhoneSuppliers
            // 
            this.textBoxPhoneSuppliers.Location = new System.Drawing.Point(541, 150);
            this.textBoxPhoneSuppliers.Name = "textBoxPhoneSuppliers";
            this.textBoxPhoneSuppliers.Size = new System.Drawing.Size(239, 20);
            this.textBoxPhoneSuppliers.TabIndex = 25;
            // 
            // textBoxNameSuppliers
            // 
            this.textBoxNameSuppliers.Location = new System.Drawing.Point(541, 65);
            this.textBoxNameSuppliers.Name = "textBoxNameSuppliers";
            this.textBoxNameSuppliers.Size = new System.Drawing.Size(239, 20);
            this.textBoxNameSuppliers.TabIndex = 24;
            // 
            // numericUpDownRaitingSuppliers
            // 
            this.numericUpDownRaitingSuppliers.Location = new System.Drawing.Point(541, 235);
            this.numericUpDownRaitingSuppliers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRaitingSuppliers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRaitingSuppliers.Name = "numericUpDownRaitingSuppliers";
            this.numericUpDownRaitingSuppliers.Size = new System.Drawing.Size(239, 20);
            this.numericUpDownRaitingSuppliers.TabIndex = 30;
            this.numericUpDownRaitingSuppliers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownRaitingSuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhoneSuppliers);
            this.Controls.Add(this.textBoxNameSuppliers);
            this.Controls.Add(this.buttonRemoveSuppliers);
            this.Controls.Add(this.buttonChangeSuppliers);
            this.Controls.Add(this.buttonAddSuppliers);
            this.Controls.Add(this.suppliersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRaitingSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private Ромашенко_УПDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonRemoveSuppliers;
        private System.Windows.Forms.Button buttonChangeSuppliers;
        private System.Windows.Forms.Button buttonAddSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhoneSuppliers;
        private System.Windows.Forms.TextBox textBoxNameSuppliers;
        private System.Windows.Forms.NumericUpDown numericUpDownRaitingSuppliers;
    }
}