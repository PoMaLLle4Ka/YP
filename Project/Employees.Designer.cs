namespace Project
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemoveEmployees = new System.Windows.Forms.Button();
            this.buttonChangeEmployees = new System.Windows.Forms.Button();
            this.buttonAddEmployees = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoleEmployees = new System.Windows.Forms.TextBox();
            this.textBoxFIOEmployees = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.ServiceMaterialsTableAdapter = null;
            this.tableAdapterManager.SupplierMaterialsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.RowHeadersVisible = false;
            this.employeesDataGridView.Size = new System.Drawing.Size(451, 332);
            this.employeesDataGridView.TabIndex = 1;
            this.employeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // buttonRemoveEmployees
            // 
            this.buttonRemoveEmployees.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRemoveEmployees.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveEmployees.Location = new System.Drawing.Point(308, 398);
            this.buttonRemoveEmployees.Name = "buttonRemoveEmployees";
            this.buttonRemoveEmployees.Size = new System.Drawing.Size(142, 40);
            this.buttonRemoveEmployees.TabIndex = 11;
            this.buttonRemoveEmployees.Text = "Удалить";
            this.buttonRemoveEmployees.UseVisualStyleBackColor = false;
            this.buttonRemoveEmployees.Click += new System.EventHandler(this.buttonRemoveEmployees_Click);
            // 
            // buttonChangeEmployees
            // 
            this.buttonChangeEmployees.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChangeEmployees.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeEmployees.Location = new System.Drawing.Point(160, 398);
            this.buttonChangeEmployees.Name = "buttonChangeEmployees";
            this.buttonChangeEmployees.Size = new System.Drawing.Size(142, 40);
            this.buttonChangeEmployees.TabIndex = 10;
            this.buttonChangeEmployees.Text = "Изменить";
            this.buttonChangeEmployees.UseVisualStyleBackColor = false;
            this.buttonChangeEmployees.Click += new System.EventHandler(this.buttonChangeEmployees_Click);
            // 
            // buttonAddEmployees
            // 
            this.buttonAddEmployees.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddEmployees.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEmployees.Location = new System.Drawing.Point(12, 398);
            this.buttonAddEmployees.Name = "buttonAddEmployees";
            this.buttonAddEmployees.Size = new System.Drawing.Size(142, 40);
            this.buttonAddEmployees.TabIndex = 9;
            this.buttonAddEmployees.Text = "Добавить";
            this.buttonAddEmployees.UseVisualStyleBackColor = false;
            this.buttonAddEmployees.Click += new System.EventHandler(this.buttonAddEmployees_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(493, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Должность сотрудника";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(497, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "ФИО сотрудника";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxRoleEmployees
            // 
            this.textBoxRoleEmployees.Location = new System.Drawing.Point(497, 145);
            this.textBoxRoleEmployees.Name = "textBoxRoleEmployees";
            this.textBoxRoleEmployees.Size = new System.Drawing.Size(239, 20);
            this.textBoxRoleEmployees.TabIndex = 15;
            // 
            // textBoxFIOEmployees
            // 
            this.textBoxFIOEmployees.Location = new System.Drawing.Point(497, 60);
            this.textBoxFIOEmployees.Name = "textBoxFIOEmployees";
            this.textBoxFIOEmployees.Size = new System.Drawing.Size(239, 20);
            this.textBoxFIOEmployees.TabIndex = 14;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRoleEmployees);
            this.Controls.Add(this.textBoxFIOEmployees);
            this.Controls.Add(this.buttonRemoveEmployees);
            this.Controls.Add(this.buttonChangeEmployees);
            this.Controls.Add(this.buttonAddEmployees);
            this.Controls.Add(this.employeesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private Ромашенко_УПDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonRemoveEmployees;
        private System.Windows.Forms.Button buttonChangeEmployees;
        private System.Windows.Forms.Button buttonAddEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoleEmployees;
        private System.Windows.Forms.TextBox textBoxFIOEmployees;
    }
}