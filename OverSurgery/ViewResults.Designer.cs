namespace OverSurgery
{
    partial class ViewResults
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
            this.dataBaseOSDataSet1 = new OverSurgery.DataBaseOSDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new OverSurgery.DataBaseOSDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new OverSurgery.DataBaseOSDataSet1TableAdapters.TableAdapterManager();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Label();
            this.pSName = new System.Windows.Forms.Label();
            this.testType = new System.Windows.Forms.Label();
            this.testDate = new System.Windows.Forms.Label();
            this.testResults = new System.Windows.Forms.Label();
            this.pNameTB = new System.Windows.Forms.TextBox();
            this.pSNameTB = new System.Windows.Forms.TextBox();
            this.testTypeTB = new System.Windows.Forms.TextBox();
            this.testDateTB = new System.Windows.Forms.TextBox();
            this.testResultsTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseOSDataSet1
            // 
            this.dataBaseOSDataSet1.DataSetName = "DataBaseOSDataSet1";
            this.dataBaseOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataBaseOSDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = OverSurgery.DataBaseOSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(12, 9);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(51, 16);
            this.patientNameLabel.TabIndex = 1;
            this.patientNameLabel.Text = "label1";
            // 
            // pName
            // 
            this.pName.AutoSize = true;
            this.pName.Location = new System.Drawing.Point(29, 50);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(74, 13);
            this.pName.TabIndex = 3;
            this.pName.Text = "Patient Name:";
            // 
            // pSName
            // 
            this.pSName.AutoSize = true;
            this.pSName.Location = new System.Drawing.Point(15, 82);
            this.pSName.Name = "pSName";
            this.pSName.Size = new System.Drawing.Size(88, 13);
            this.pSName.TabIndex = 3;
            this.pSName.Text = "Patient Surname:";
            // 
            // testType
            // 
            this.testType.AutoSize = true;
            this.testType.Location = new System.Drawing.Point(45, 111);
            this.testType.Name = "testType";
            this.testType.Size = new System.Drawing.Size(58, 13);
            this.testType.TabIndex = 3;
            this.testType.Text = "Test Type:";
            // 
            // testDate
            // 
            this.testDate.AutoSize = true;
            this.testDate.Location = new System.Drawing.Point(45, 140);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(57, 13);
            this.testDate.TabIndex = 4;
            this.testDate.Text = "Test Date:";
            // 
            // testResults
            // 
            this.testResults.AutoSize = true;
            this.testResults.Location = new System.Drawing.Point(33, 171);
            this.testResults.Name = "testResults";
            this.testResults.Size = new System.Drawing.Size(69, 13);
            this.testResults.TabIndex = 4;
            this.testResults.Text = "Test Results:";
            // 
            // pNameTB
            // 
            this.pNameTB.Location = new System.Drawing.Point(131, 50);
            this.pNameTB.Name = "pNameTB";
            this.pNameTB.ReadOnly = true;
            this.pNameTB.Size = new System.Drawing.Size(100, 20);
            this.pNameTB.TabIndex = 5;
            // 
            // pSNameTB
            // 
            this.pSNameTB.Location = new System.Drawing.Point(131, 79);
            this.pSNameTB.Name = "pSNameTB";
            this.pSNameTB.ReadOnly = true;
            this.pSNameTB.Size = new System.Drawing.Size(100, 20);
            this.pSNameTB.TabIndex = 5;
            // 
            // testTypeTB
            // 
            this.testTypeTB.Location = new System.Drawing.Point(131, 108);
            this.testTypeTB.Name = "testTypeTB";
            this.testTypeTB.ReadOnly = true;
            this.testTypeTB.Size = new System.Drawing.Size(100, 20);
            this.testTypeTB.TabIndex = 5;
            // 
            // testDateTB
            // 
            this.testDateTB.Location = new System.Drawing.Point(131, 137);
            this.testDateTB.Name = "testDateTB";
            this.testDateTB.ReadOnly = true;
            this.testDateTB.Size = new System.Drawing.Size(100, 20);
            this.testDateTB.TabIndex = 5;
            // 
            // testResultsTB
            // 
            this.testResultsTB.Location = new System.Drawing.Point(131, 168);
            this.testResultsTB.Multiline = true;
            this.testResultsTB.Name = "testResultsTB";
            this.testResultsTB.ReadOnly = true;
            this.testResultsTB.Size = new System.Drawing.Size(100, 111);
            this.testResultsTB.TabIndex = 5;
            // 
            // ViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 314);
            this.Controls.Add(this.testResultsTB);
            this.Controls.Add(this.testDateTB);
            this.Controls.Add(this.testTypeTB);
            this.Controls.Add(this.pSNameTB);
            this.Controls.Add(this.pNameTB);
            this.Controls.Add(this.testResults);
            this.Controls.Add(this.testDate);
            this.Controls.Add(this.testType);
            this.Controls.Add(this.pSName);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.patientNameLabel);
            this.Name = "ViewResults";
            this.Text = "ViewResults";
            this.Load += new System.EventHandler(this.ViewResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataBaseOSDataSet1 dataBaseOSDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataBaseOSDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private DataBaseOSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label pName;
        private System.Windows.Forms.Label pSName;
        private System.Windows.Forms.Label testType;
        private System.Windows.Forms.Label testDate;
        private System.Windows.Forms.Label testResults;
        private System.Windows.Forms.TextBox pNameTB;
        private System.Windows.Forms.TextBox pSNameTB;
        private System.Windows.Forms.TextBox testTypeTB;
        private System.Windows.Forms.TextBox testDateTB;
        private System.Windows.Forms.TextBox testResultsTB;
    }
}