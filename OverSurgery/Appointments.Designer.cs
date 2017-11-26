namespace OverSurgery
{
    partial class x
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(x));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseOSDataSet1 = new OverSurgery.DataBaseOSDataSet1();
            this.appointmentTableAdapter = new OverSurgery.DataBaseOSDataSet1TableAdapters.AppointmentTableAdapter();
            this.dataBaseOSDataSet2 = new OverSurgery.DataBaseOSDataSet2();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter1 = new OverSurgery.DataBaseOSDataSet2TableAdapters.AppointmentTableAdapter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxSelectedDate = new System.Windows.Forms.TextBox();
            this.labelSelectedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.appointmentStartDataGridViewTextBoxColumn,
            this.appointmentEndDataGridViewTextBoxColumn,
            this.appointmentStatusDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentStartDataGridViewTextBoxColumn
            // 
            this.appointmentStartDataGridViewTextBoxColumn.DataPropertyName = "AppointmentStart";
            resources.ApplyResources(this.appointmentStartDataGridViewTextBoxColumn, "appointmentStartDataGridViewTextBoxColumn");
            this.appointmentStartDataGridViewTextBoxColumn.Name = "appointmentStartDataGridViewTextBoxColumn";
            // 
            // appointmentEndDataGridViewTextBoxColumn
            // 
            this.appointmentEndDataGridViewTextBoxColumn.DataPropertyName = "AppointmentEnd";
            resources.ApplyResources(this.appointmentEndDataGridViewTextBoxColumn, "appointmentEndDataGridViewTextBoxColumn");
            this.appointmentEndDataGridViewTextBoxColumn.Name = "appointmentEndDataGridViewTextBoxColumn";
            // 
            // appointmentStatusDataGridViewTextBoxColumn
            // 
            this.appointmentStatusDataGridViewTextBoxColumn.DataPropertyName = "AppointmentStatus";
            resources.ApplyResources(this.appointmentStatusDataGridViewTextBoxColumn, "appointmentStatusDataGridViewTextBoxColumn");
            this.appointmentStatusDataGridViewTextBoxColumn.Name = "appointmentStatusDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            resources.ApplyResources(this.staffIDDataGridViewTextBoxColumn, "staffIDDataGridViewTextBoxColumn");
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            resources.ApplyResources(this.patientIDDataGridViewTextBoxColumn, "patientIDDataGridViewTextBoxColumn");
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.dataBaseOSDataSet1;
            // 
            // dataBaseOSDataSet1
            // 
            this.dataBaseOSDataSet1.DataSetName = "DataBaseOSDataSet1";
            this.dataBaseOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataBaseOSDataSet2
            // 
            this.dataBaseOSDataSet2.DataSetName = "DataBaseOSDataSet2";
            this.dataBaseOSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "Appointment";
            this.appointmentBindingSource1.DataSource = this.dataBaseOSDataSet2;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.GridLines = true;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // textBoxSelectedDate
            // 
            resources.ApplyResources(this.textBoxSelectedDate, "textBoxSelectedDate");
            this.textBoxSelectedDate.Name = "textBoxSelectedDate";
            this.textBoxSelectedDate.TextChanged += new System.EventHandler(this.textBoxSelectedDate_TextChanged);
            // 
            // labelSelectedDate
            // 
            resources.ApplyResources(this.labelSelectedDate, "labelSelectedDate");
            this.labelSelectedDate.Name = "labelSelectedDate";
            // 
            // x
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSelectedDate);
            this.Controls.Add(this.textBoxSelectedDate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "x";
            this.Load += new System.EventHandler(this.x_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBaseOSDataSet1 dataBaseOSDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private DataBaseOSDataSet1TableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private DataBaseOSDataSet2 dataBaseOSDataSet2;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private DataBaseOSDataSet2TableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxSelectedDate;
        private System.Windows.Forms.Label labelSelectedDate;
    }
}