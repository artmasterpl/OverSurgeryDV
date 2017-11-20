namespace OverSurgery
{
    partial class AddPatient
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
            this.ADD = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxDoB = new System.Windows.Forms.TextBox();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelDoB = new System.Windows.Forms.Label();
            this.LabelStreetName = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.groupBoxPatientDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientTableAdapter = new OverSurgery.DataBaseOSDataSetTableAdapters.PatientTableAdapter();
            this.dataBaseOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.dataBaseOSDataSet = new OverSurgery.DataBaseOSDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(420, 104);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(420, 193);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(542, 104);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 2;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Name", true));
            this.textBoxName.Location = new System.Drawing.Point(206, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Patient";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Surname", true));
            this.textBoxSurname.Location = new System.Drawing.Point(206, 114);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxDoB
            // 
            this.textBoxDoB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Date Of Birth", true));
            this.textBoxDoB.Location = new System.Drawing.Point(206, 163);
            this.textBoxDoB.Name = "textBoxDoB";
            this.textBoxDoB.Size = new System.Drawing.Size(100, 22);
            this.textBoxDoB.TabIndex = 6;
            this.textBoxDoB.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "Street", true));
            this.textBoxStreetName.Location = new System.Drawing.Point(206, 212);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(100, 22);
            this.textBoxStreetName.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "City", true));
            this.textBoxCity.Location = new System.Drawing.Point(206, 263);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxCity.TabIndex = 9;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(57, 79);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(45, 17);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(57, 117);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(65, 17);
            this.LabelSurname.TabIndex = 11;
            this.LabelSurname.Text = "Surname";
            // 
            // LabelDoB
            // 
            this.LabelDoB.AutoSize = true;
            this.LabelDoB.Location = new System.Drawing.Point(57, 168);
            this.LabelDoB.Name = "LabelDoB";
            this.LabelDoB.Size = new System.Drawing.Size(90, 17);
            this.LabelDoB.TabIndex = 12;
            this.LabelDoB.Text = "Date Of Birth";
            // 
            // LabelStreetName
            // 
            this.LabelStreetName.AutoSize = true;
            this.LabelStreetName.Location = new System.Drawing.Point(57, 217);
            this.LabelStreetName.Name = "LabelStreetName";
            this.LabelStreetName.Size = new System.Drawing.Size(87, 17);
            this.LabelStreetName.TabIndex = 13;
            this.LabelStreetName.Text = "Street Name";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(57, 266);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(31, 17);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // groupBoxPatientDetails
            // 
            this.groupBoxPatientDetails.Location = new System.Drawing.Point(48, 42);
            this.groupBoxPatientDetails.Name = "groupBoxPatientDetails";
            this.groupBoxPatientDetails.Size = new System.Drawing.Size(292, 275);
            this.groupBoxPatientDetails.TabIndex = 15;
            this.groupBoxPatientDetails.TabStop = false;
            this.groupBoxPatientDetails.Text = "Patient Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Location = new System.Drawing.Point(542, 193);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(75, 23);
            this.RemoveBTN.TabIndex = 17;
            this.RemoveBTN.Text = "Remove";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // dataBaseOSDataSet
            // 
            this.dataBaseOSDataSet.DataSetName = "DataBaseOSDataSet";
            this.dataBaseOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddPatient
            // 
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.LabelStreetName);
            this.Controls.Add(this.LabelDoB);
            this.Controls.Add(this.LabelSurname);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreetName);
            this.Controls.Add(this.textBoxDoB);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.groupBoxPatientDetails);
            this.Name = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxDoB;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelDoB;
        private System.Windows.Forms.Label LabelStreetName;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.GroupBox groupBoxPatientDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBaseOSDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource dataBaseOSDataSetBindingSource;
        private System.Windows.Forms.Button RemoveBTN;
        private DataBaseOSDataSet dataBaseOSDataSet;
    }
}