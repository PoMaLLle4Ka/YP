namespace Project
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.supplierMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierMaterialsTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.SupplierMaterialsTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemsTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.OrderItemsTableAdapter();
            this.btnHistory = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.dataGridViewRecord = new System.Windows.Forms.DataGridView();
            this.comboBoxPartner = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLoadPartnerHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierMaterialsBindingSource
            // 
            this.supplierMaterialsBindingSource.DataMember = "SupplierMaterials";
            this.supplierMaterialsBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // supplierMaterialsTableAdapter
            // 
            this.supplierMaterialsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SupplierMaterialsTableAdapter = this.supplierMaterialsTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // orderItemsTableAdapter
            // 
            this.orderItemsTableAdapter.ClearBeforeFill = true;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.Location = new System.Drawing.Point(12, 366);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(137, 66);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "История заказов";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonWarehouse.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWarehouse.Location = new System.Drawing.Point(12, 446);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(137, 66);
            this.buttonWarehouse.TabIndex = 5;
            this.buttonWarehouse.Text = "Отчёт по складу";
            this.buttonWarehouse.UseVisualStyleBackColor = false;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // buttonRating
            // 
            this.buttonRating.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRating.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRating.Location = new System.Drawing.Point(163, 366);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(137, 66);
            this.buttonRating.TabIndex = 6;
            this.buttonRating.Text = "Рейтинг партнёров";
            this.buttonRating.UseVisualStyleBackColor = false;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // buttonService
            // 
            this.buttonService.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonService.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonService.Location = new System.Drawing.Point(163, 446);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(137, 66);
            this.buttonService.TabIndex = 7;
            this.buttonService.Text = "Статистика услуг";
            this.buttonService.UseVisualStyleBackColor = false;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonExport.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(318, 446);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(137, 66);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Экспорт в CSV";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // dataGridViewRecord
            // 
            this.dataGridViewRecord.AllowUserToAddRows = false;
            this.dataGridViewRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecord.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRecord.Name = "dataGridViewRecord";
            this.dataGridViewRecord.RowHeadersVisible = false;
            this.dataGridViewRecord.Size = new System.Drawing.Size(707, 348);
            this.dataGridViewRecord.TabIndex = 9;
            // 
            // comboBoxPartner
            // 
            this.comboBoxPartner.FormattingEnabled = true;
            this.comboBoxPartner.Location = new System.Drawing.Point(742, 62);
            this.comboBoxPartner.Name = "comboBoxPartner";
            this.comboBoxPartner.Size = new System.Drawing.Size(290, 21);
            this.comboBoxPartner.TabIndex = 27;
            this.comboBoxPartner.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartner_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(738, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Партнер";
            // 
            // buttonLoadPartnerHistory
            // 
            this.buttonLoadPartnerHistory.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonLoadPartnerHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadPartnerHistory.Location = new System.Drawing.Point(318, 366);
            this.buttonLoadPartnerHistory.Name = "buttonLoadPartnerHistory";
            this.buttonLoadPartnerHistory.Size = new System.Drawing.Size(137, 66);
            this.buttonLoadPartnerHistory.TabIndex = 28;
            this.buttonLoadPartnerHistory.Text = "История партнеров";
            this.buttonLoadPartnerHistory.UseVisualStyleBackColor = false;
            this.buttonLoadPartnerHistory.Click += new System.EventHandler(this.buttonLoadPartnerHistory_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 536);
            this.Controls.Add(this.buttonLoadPartnerHistory);
            this.Controls.Add(this.comboBoxPartner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewRecord);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonWarehouse);
            this.Controls.Add(this.btnHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource supplierMaterialsBindingSource;
        private Ромашенко_УПDataSetTableAdapters.SupplierMaterialsTableAdapter supplierMaterialsTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private Ромашенко_УПDataSetTableAdapters.OrderItemsTableAdapter orderItemsTableAdapter;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView dataGridViewRecord;
        private System.Windows.Forms.ComboBox comboBoxPartner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLoadPartnerHistory;
    }
}