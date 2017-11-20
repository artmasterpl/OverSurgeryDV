namespace OverSurgery
{
    partial class Prescription
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseOSDataSet11 = new OverSurgery.DataBaseOSDataSet1();
            this.prescriptionTableAdapter1 = new OverSurgery.DataBaseOSDataSet1TableAdapters.PrescriptionTableAdapter();
            this.ADD = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prescriptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(127, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.dataBaseOSDataSet11;
            // 
            // dataBaseOSDataSet11
            // 
            this.dataBaseOSDataSet11.DataSetName = "DataBaseOSDataSet1";
            this.dataBaseOSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionTableAdapter1
            // 
            this.prescriptionTableAdapter1.ClearBeforeFill = true;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(584, 201);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(113, 60);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(584, 277);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 60);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 394);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBaseOSDataSet1 dataBaseOSDataSet11;
        private DataBaseOSDataSet1TableAdapters.PrescriptionTableAdapter prescriptionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button btnBack;
    }
}