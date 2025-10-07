namespace Project
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.attendanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.attendanceTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.AttendanceTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.buttonChangeService = new System.Windows.Forms.Button();
            this.buttonRemoveService = new System.Windows.Forms.Button();
            this.textBoxNameService = new System.Windows.Forms.TextBox();
            this.textBoxPriceService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceDataGridView
            // 
            this.attendanceDataGridView.AllowUserToAddRows = false;
            this.attendanceDataGridView.AutoGenerateColumns = false;
            this.attendanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.attendanceDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.attendanceDataGridView.DataSource = this.attendanceBindingSource;
            this.attendanceDataGridView.Location = new System.Drawing.Point(12, 39);
            this.attendanceDataGridView.Name = "attendanceDataGridView";
            this.attendanceDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attendanceDataGridView.RowHeadersVisible = false;
            this.attendanceDataGridView.Size = new System.Drawing.Size(505, 336);
            this.attendanceDataGridView.TabIndex = 1;
            this.attendanceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Услуги";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Услуги";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = this.attendanceTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Услуги";
            // 
            // buttonAddService
            // 
            this.buttonAddService.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddService.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddService.Location = new System.Drawing.Point(12, 398);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(142, 40);
            this.buttonAddService.TabIndex = 3;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.UseVisualStyleBackColor = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // buttonChangeService
            // 
            this.buttonChangeService.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChangeService.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeService.Location = new System.Drawing.Point(160, 398);
            this.buttonChangeService.Name = "buttonChangeService";
            this.buttonChangeService.Size = new System.Drawing.Size(142, 40);
            this.buttonChangeService.TabIndex = 4;
            this.buttonChangeService.Text = "Изменить";
            this.buttonChangeService.UseVisualStyleBackColor = false;
            this.buttonChangeService.Click += new System.EventHandler(this.buttonChangeService_Click);
            // 
            // buttonRemoveService
            // 
            this.buttonRemoveService.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRemoveService.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveService.Location = new System.Drawing.Point(308, 398);
            this.buttonRemoveService.Name = "buttonRemoveService";
            this.buttonRemoveService.Size = new System.Drawing.Size(142, 40);
            this.buttonRemoveService.TabIndex = 5;
            this.buttonRemoveService.Text = "Удалить";
            this.buttonRemoveService.UseVisualStyleBackColor = false;
            this.buttonRemoveService.Click += new System.EventHandler(this.buttonRemoveService_Click);
            // 
            // textBoxNameService
            // 
            this.textBoxNameService.Location = new System.Drawing.Point(549, 71);
            this.textBoxNameService.Name = "textBoxNameService";
            this.textBoxNameService.Size = new System.Drawing.Size(239, 20);
            this.textBoxNameService.TabIndex = 6;
            // 
            // textBoxPriceService
            // 
            this.textBoxPriceService.Location = new System.Drawing.Point(549, 156);
            this.textBoxPriceService.Name = "textBoxPriceService";
            this.textBoxPriceService.Size = new System.Drawing.Size(239, 20);
            this.textBoxPriceService.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(544, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(545, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена услуги";
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPriceService);
            this.Controls.Add(this.textBoxNameService);
            this.Controls.Add(this.buttonRemoveService);
            this.Controls.Add(this.buttonChangeService);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attendanceDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Ромашенко_УПDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView attendanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button buttonChangeService;
        private System.Windows.Forms.Button buttonRemoveService;
        private System.Windows.Forms.TextBox textBoxNameService;
        private System.Windows.Forms.TextBox textBoxPriceService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}