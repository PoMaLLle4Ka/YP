namespace Project
{
    partial class Partners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partners));
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.PartnersTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.partnersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemovePartners = new System.Windows.Forms.Button();
            this.buttonChangePartners = new System.Windows.Forms.Button();
            this.buttonAddPartners = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PartnersTableAdapter = this.partnersTableAdapter;
            this.tableAdapterManager.ServiceMaterialsTableAdapter = null;
            this.tableAdapterManager.SupplierMaterialsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // partnersDataGridView
            // 
            this.partnersDataGridView.AllowUserToAddRows = false;
            this.partnersDataGridView.AutoGenerateColumns = false;
            this.partnersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partnersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.partnersDataGridView.DataSource = this.partnersBindingSource;
            this.partnersDataGridView.Location = new System.Drawing.Point(12, 49);
            this.partnersDataGridView.Name = "partnersDataGridView";
            this.partnersDataGridView.RowHeadersVisible = false;
            this.partnersDataGridView.Size = new System.Drawing.Size(500, 358);
            this.partnersDataGridView.TabIndex = 1;
            this.partnersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partnersDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Партнёра";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Партнёра";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Контакты";
            this.dataGridViewTextBoxColumn3.HeaderText = "Контакты";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Рейтинг";
            this.dataGridViewTextBoxColumn4.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Партнеры";
            // 
            // buttonRemovePartners
            // 
            this.buttonRemovePartners.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRemovePartners.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemovePartners.Location = new System.Drawing.Point(308, 424);
            this.buttonRemovePartners.Name = "buttonRemovePartners";
            this.buttonRemovePartners.Size = new System.Drawing.Size(142, 40);
            this.buttonRemovePartners.TabIndex = 8;
            this.buttonRemovePartners.Text = "Удалить";
            this.buttonRemovePartners.UseVisualStyleBackColor = false;
            this.buttonRemovePartners.Click += new System.EventHandler(this.buttonRemovePartners_Click);
            // 
            // buttonChangePartners
            // 
            this.buttonChangePartners.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChangePartners.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePartners.Location = new System.Drawing.Point(160, 424);
            this.buttonChangePartners.Name = "buttonChangePartners";
            this.buttonChangePartners.Size = new System.Drawing.Size(142, 40);
            this.buttonChangePartners.TabIndex = 7;
            this.buttonChangePartners.Text = "Изменить";
            this.buttonChangePartners.UseVisualStyleBackColor = false;
            this.buttonChangePartners.Click += new System.EventHandler(this.buttonChangePartners_Click);
            // 
            // buttonAddPartners
            // 
            this.buttonAddPartners.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddPartners.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPartners.Location = new System.Drawing.Point(12, 424);
            this.buttonAddPartners.Name = "buttonAddPartners";
            this.buttonAddPartners.Size = new System.Drawing.Size(142, 40);
            this.buttonAddPartners.TabIndex = 6;
            this.buttonAddPartners.Text = "Добавить";
            this.buttonAddPartners.UseVisualStyleBackColor = false;
            this.buttonAddPartners.Click += new System.EventHandler(this.buttonAddPartners_Click);
            // 
            // Partners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 476);
            this.Controls.Add(this.buttonRemovePartners);
            this.Controls.Add(this.buttonChangePartners);
            this.Controls.Add(this.buttonAddPartners);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partnersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Partners";
            this.Text = "Patrners";
            this.Load += new System.EventHandler(this.Partners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private Ромашенко_УПDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView partnersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemovePartners;
        private System.Windows.Forms.Button buttonChangePartners;
        private System.Windows.Forms.Button buttonAddPartners;
    }
}