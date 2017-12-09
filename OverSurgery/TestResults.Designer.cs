namespace OverSurgery
{
    partial class TestResults
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
            this.dataBaseOSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseOSDataSet1 = new OverSurgery.DataBaseOSDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.patientTableAdapter1 = new OverSurgery.DataBaseOSDataSetTableAdapters.PatientTableAdapter();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new OverSurgery.DataBaseOSDataSetTableAdapters.TableAdapterManager();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSelected = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseOSDataSet1BindingSource
            // 
            this.dataBaseOSDataSet1BindingSource.DataSource = this.dataBaseOSDataSet1;
            this.dataBaseOSDataSet1BindingSource.Position = 0;
            // 
            // dataBaseOSDataSet1
            // 
            this.dataBaseOSDataSet1.DataSetName = "DataBaseOSDataSet";
            this.dataBaseOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Patient:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Print Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataBaseOSDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter1;
            this.tableAdapterManager.UpdateOrder = OverSurgery.DataBaseOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(156, 31);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.patientDataGridView.Size = new System.Drawing.Size(344, 165);
            this.patientDataGridView.TabIndex = 4;
            this.patientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date Of Birth";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Of Birth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // patientSelected
            // 
            this.patientSelected.Location = new System.Drawing.Point(16, 56);
            this.patientSelected.Name = "patientSelected";
            this.patientSelected.ReadOnly = true;
            this.patientSelected.Size = new System.Drawing.Size(119, 20);
            this.patientSelected.TabIndex = 5;
            // 
            // TestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 216);
            this.Controls.Add(this.patientSelected);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TestResults";
            this.Text = "TestResults";
            this.Load += new System.EventHandler(this.TestResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DataBaseOSDataSet dataBaseOSDataSet1;
        private DataBaseOSDataSetTableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource dataBaseOSDataSet1BindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DataBaseOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox patientSelected;
    }
}