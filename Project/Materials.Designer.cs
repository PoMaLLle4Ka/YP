namespace Project
{
    partial class Materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.MaterialsTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemoveMaterial = new System.Windows.Forms.Button();
            this.buttonChangeMaterial = new System.Windows.Forms.Button();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountMaterial = new System.Windows.Forms.TextBox();
            this.textBoxNameMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCostMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.ServiceMaterialsTableAdapter = null;
            this.tableAdapterManager.SupplierMaterialsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AllowUserToAddRows = false;
            this.materialsDataGridView.AutoGenerateColumns = false;
            this.materialsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.materialsDataGridView.DataSource = this.materialsBindingSource;
            this.materialsDataGridView.Location = new System.Drawing.Point(12, 38);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersVisible = false;
            this.materialsDataGridView.Size = new System.Drawing.Size(488, 334);
            this.materialsDataGridView.TabIndex = 1;
            this.materialsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Материала";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Материала";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // buttonRemoveMaterial
            // 
            this.buttonRemoveMaterial.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonRemoveMaterial.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveMaterial.Location = new System.Drawing.Point(308, 421);
            this.buttonRemoveMaterial.Name = "buttonRemoveMaterial";
            this.buttonRemoveMaterial.Size = new System.Drawing.Size(142, 40);
            this.buttonRemoveMaterial.TabIndex = 14;
            this.buttonRemoveMaterial.Text = "Удалить";
            this.buttonRemoveMaterial.UseVisualStyleBackColor = false;
            this.buttonRemoveMaterial.Click += new System.EventHandler(this.buttonRemoveMaterial_Click);
            // 
            // buttonChangeMaterial
            // 
            this.buttonChangeMaterial.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChangeMaterial.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeMaterial.Location = new System.Drawing.Point(160, 421);
            this.buttonChangeMaterial.Name = "buttonChangeMaterial";
            this.buttonChangeMaterial.Size = new System.Drawing.Size(142, 40);
            this.buttonChangeMaterial.TabIndex = 13;
            this.buttonChangeMaterial.Text = "Изменить";
            this.buttonChangeMaterial.UseVisualStyleBackColor = false;
            this.buttonChangeMaterial.Click += new System.EventHandler(this.buttonChangeMaterial_Click);
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddMaterial.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddMaterial.Location = new System.Drawing.Point(12, 421);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(142, 40);
            this.buttonAddMaterial.TabIndex = 12;
            this.buttonAddMaterial.Text = "Добавить";
            this.buttonAddMaterial.UseVisualStyleBackColor = false;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(524, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Кол-во материала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(524, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Наименование материалы";
            // 
            // textBoxCountMaterial
            // 
            this.textBoxCountMaterial.Location = new System.Drawing.Point(528, 155);
            this.textBoxCountMaterial.Name = "textBoxCountMaterial";
            this.textBoxCountMaterial.Size = new System.Drawing.Size(239, 20);
            this.textBoxCountMaterial.TabIndex = 19;
            // 
            // textBoxNameMaterial
            // 
            this.textBoxNameMaterial.Location = new System.Drawing.Point(528, 70);
            this.textBoxNameMaterial.Name = "textBoxNameMaterial";
            this.textBoxNameMaterial.Size = new System.Drawing.Size(239, 20);
            this.textBoxNameMaterial.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(524, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Стоимость материала";
            // 
            // textBoxCostMaterial
            // 
            this.textBoxCostMaterial.Location = new System.Drawing.Point(528, 236);
            this.textBoxCostMaterial.Name = "textBoxCostMaterial";
            this.textBoxCostMaterial.Size = new System.Drawing.Size(239, 20);
            this.textBoxCostMaterial.TabIndex = 22;
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCostMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCountMaterial);
            this.Controls.Add(this.textBoxNameMaterial);
            this.Controls.Add(this.buttonRemoveMaterial);
            this.Controls.Add(this.buttonChangeMaterial);
            this.Controls.Add(this.buttonAddMaterial);
            this.Controls.Add(this.materialsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materials";
            this.Text = "Materials";
            this.Load += new System.EventHandler(this.Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private Ромашенко_УПDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView materialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonRemoveMaterial;
        private System.Windows.Forms.Button buttonChangeMaterial;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountMaterial;
        private System.Windows.Forms.TextBox textBoxNameMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCostMaterial;
    }
}