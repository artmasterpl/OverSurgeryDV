namespace OverSurgery
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkThePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvaliabilityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvaliabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._OverSurgery_2003mdbDataSet1 = new OverSurgery._OverSurgery_2003mdbDataSet1();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new OverSurgery._OverSurgery_2003mdbDataSet1TableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new OverSurgery._OverSurgery_2003mdbDataSet1TableAdapters.TableAdapterManager();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._OverSurgery_2003mdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.extendToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.registerToolStripMenuItem.Text = "Patient";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // extendToolStripMenuItem
            // 
            this.extendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extendPrescriptionToolStripMenuItem,
            this.checkThePrescriptionToolStripMenuItem});
            this.extendToolStripMenuItem.Name = "extendToolStripMenuItem";
            this.extendToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.extendToolStripMenuItem.Text = "Prescription";
            // 
            // extendPrescriptionToolStripMenuItem
            // 
            this.extendPrescriptionToolStripMenuItem.Name = "extendPrescriptionToolStripMenuItem";
            this.extendPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.extendPrescriptionToolStripMenuItem.Text = "Extend  the Prescription";
            // 
            // checkThePrescriptionToolStripMenuItem
            // 
            this.checkThePrescriptionToolStripMenuItem.Name = "checkThePrescriptionToolStripMenuItem";
            this.checkThePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.checkThePrescriptionToolStripMenuItem.Text = "Check the Prescription";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAvaliabilityToolStripMenuItem1});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // checkAvaliabilityToolStripMenuItem1
            // 
            this.checkAvaliabilityToolStripMenuItem1.Name = "checkAvaliabilityToolStripMenuItem1";
            this.checkAvaliabilityToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.checkAvaliabilityToolStripMenuItem1.Text = "Check Avaliability";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAppointmentToolStripMenuItem,
            this.removeAppointmentToolStripMenuItem,
            this.checkAvaliabilityToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // makeAppointmentToolStripMenuItem
            // 
            this.makeAppointmentToolStripMenuItem.Name = "makeAppointmentToolStripMenuItem";
            this.makeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.makeAppointmentToolStripMenuItem.Text = "Make Appointment";
            // 
            // removeAppointmentToolStripMenuItem
            // 
            this.removeAppointmentToolStripMenuItem.Name = "removeAppointmentToolStripMenuItem";
            this.removeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.removeAppointmentToolStripMenuItem.Text = "Remove Appointment";
            // 
            // checkAvaliabilityToolStripMenuItem
            // 
            this.checkAvaliabilityToolStripMenuItem.Name = "checkAvaliabilityToolStripMenuItem";
            this.checkAvaliabilityToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.checkAvaliabilityToolStripMenuItem.Text = "Check Avaliability";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // _OverSurgery_2003mdbDataSet1
            // 
            this._OverSurgery_2003mdbDataSet1.DataSetName = "_OverSurgery_2003mdbDataSet1";
            this._OverSurgery_2003mdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this._OverSurgery_2003mdbDataSet1;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.Tape2TableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OverSurgery._OverSurgery_2003mdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(12, 296);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(645, 257);
            this.patientDataGridView.TabIndex = 2;
            this.patientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 618);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._OverSurgery_2003mdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvaliabilityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvaliabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkThePrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private _OverSurgery_2003mdbDataSet1 _OverSurgery_2003mdbDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private _OverSurgery_2003mdbDataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private _OverSurgery_2003mdbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}