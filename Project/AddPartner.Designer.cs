namespace Project
{
    partial class AddPartner
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
            this.numericUpDownPartners = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhonePartners = new System.Windows.Forms.TextBox();
            this.textBoxNamePartners = new System.Windows.Forms.TextBox();
            this.buttonAddPartners = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPartners)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPartners
            // 
            this.numericUpDownPartners.Location = new System.Drawing.Point(35, 240);
            this.numericUpDownPartners.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPartners.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPartners.Name = "numericUpDownPartners";
            this.numericUpDownPartners.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPartners.TabIndex = 22;
            this.numericUpDownPartners.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Рейтинг партнера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Контакты партнера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Наименование партнера";
            // 
            // textBoxPhonePartners
            // 
            this.textBoxPhonePartners.Location = new System.Drawing.Point(35, 158);
            this.textBoxPhonePartners.Name = "textBoxPhonePartners";
            this.textBoxPhonePartners.Size = new System.Drawing.Size(239, 20);
            this.textBoxPhonePartners.TabIndex = 18;
            // 
            // textBoxNamePartners
            // 
            this.textBoxNamePartners.Location = new System.Drawing.Point(35, 73);
            this.textBoxNamePartners.Name = "textBoxNamePartners";
            this.textBoxNamePartners.Size = new System.Drawing.Size(239, 20);
            this.textBoxNamePartners.TabIndex = 17;
            // 
            // buttonAddPartners
            // 
            this.buttonAddPartners.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAddPartners.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPartners.Location = new System.Drawing.Point(90, 297);
            this.buttonAddPartners.Name = "buttonAddPartners";
            this.buttonAddPartners.Size = new System.Drawing.Size(142, 69);
            this.buttonAddPartners.TabIndex = 23;
            this.buttonAddPartners.Text = "Сохранить";
            this.buttonAddPartners.UseVisualStyleBackColor = false;
            this.buttonAddPartners.Click += new System.EventHandler(this.buttonAddPartners_Click);
            // 
            // AddPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.buttonAddPartners);
            this.Controls.Add(this.numericUpDownPartners);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhonePartners);
            this.Controls.Add(this.textBoxNamePartners);
            this.Name = "AddPartner";
            this.Text = "AddPartner";
            this.Load += new System.EventHandler(this.AddPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPartners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPartners;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhonePartners;
        private System.Windows.Forms.TextBox textBoxNamePartners;
        private System.Windows.Forms.Button buttonAddPartners;
    }
}