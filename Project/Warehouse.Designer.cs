namespace Project
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.ромашенко_УПDataSet = new Project.Ромашенко_УПDataSet();
            this.serviceMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceMaterialsTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.ServiceMaterialsTableAdapter();
            this.tableAdapterManager = new Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Project.Ромашенко_УПDataSetTableAdapters.MaterialsTableAdapter();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSpisanie = new System.Windows.Forms.Button();
            this.buttonPostuplenie = new System.Windows.Forms.Button();
            this.textBoxNameMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ромашенко_УПDataSet
            // 
            this.ромашенко_УПDataSet.DataSetName = "Ромашенко_УПDataSet";
            this.ромашенко_УПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceMaterialsBindingSource
            // 
            this.serviceMaterialsBindingSource.DataMember = "ServiceMaterials";
            this.serviceMaterialsBindingSource.DataSource = this.ромашенко_УПDataSet;
            // 
            // serviceMaterialsTableAdapter
            // 
            this.serviceMaterialsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ServiceMaterialsTableAdapter = this.serviceMaterialsTableAdapter;
            this.tableAdapterManager.SupplierMaterialsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Ромашенко_УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
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
            this.materialsDataGridView.Location = new System.Drawing.Point(12, 34);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersVisible = false;
            this.materialsDataGridView.Size = new System.Drawing.Size(514, 347);
            this.materialsDataGridView.TabIndex = 1;
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
            // buttonSpisanie
            // 
            this.buttonSpisanie.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSpisanie.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpisanie.Location = new System.Drawing.Point(180, 424);
            this.buttonSpisanie.Name = "buttonSpisanie";
            this.buttonSpisanie.Size = new System.Drawing.Size(157, 40);
            this.buttonSpisanie.TabIndex = 16;
            this.buttonSpisanie.Text = "Списание";
            this.buttonSpisanie.UseVisualStyleBackColor = false;
            this.buttonSpisanie.Click += new System.EventHandler(this.buttonSpisanie_Click);
            // 
            // buttonPostuplenie
            // 
            this.buttonPostuplenie.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPostuplenie.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPostuplenie.Location = new System.Drawing.Point(17, 424);
            this.buttonPostuplenie.Name = "buttonPostuplenie";
            this.buttonPostuplenie.Size = new System.Drawing.Size(157, 40);
            this.buttonPostuplenie.TabIndex = 15;
            this.buttonPostuplenie.Text = "Поступление";
            this.buttonPostuplenie.UseVisualStyleBackColor = false;
            this.buttonPostuplenie.Click += new System.EventHandler(this.buttonPostuplenie_Click);
            // 
            // textBoxNameMaterial
            // 
            this.textBoxNameMaterial.Location = new System.Drawing.Point(536, 68);
            this.textBoxNameMaterial.Name = "textBoxNameMaterial";
            this.textBoxNameMaterial.Size = new System.Drawing.Size(290, 20);
            this.textBoxNameMaterial.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(532, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(532, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Кол-во ";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(536, 155);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(290, 20);
            this.numericUpDownQuantity.TabIndex = 25;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(536, 232);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(290, 20);
            this.textBoxCost.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(532, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Стоимость";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 476);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSpisanie);
            this.Controls.Add(this.buttonPostuplenie);
            this.Controls.Add(this.materialsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ромашенко_УПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ромашенко_УПDataSet ромашенко_УПDataSet;
        private System.Windows.Forms.BindingSource serviceMaterialsBindingSource;
        private Ромашенко_УПDataSetTableAdapters.ServiceMaterialsTableAdapter serviceMaterialsTableAdapter;
        private Ромашенко_УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private Ромашенко_УПDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridView materialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonSpisanie;
        private System.Windows.Forms.Button buttonPostuplenie;
        private System.Windows.Forms.TextBox textBoxNameMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label3;
    }
}