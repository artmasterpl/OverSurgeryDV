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
            this.btnNewPat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.checkAvaliabilityToolStripMenuItem1.Click += new System.EventHandler(this.checkAvaliabilityToolStripMenuItem1_Click);
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
            this.makeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.makeAppointmentToolStripMenuItem_Click);
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
            // btnNewPat
            // 
            this.btnNewPat.Location = new System.Drawing.Point(43, 87);
            this.btnNewPat.Name = "btnNewPat";
            this.btnNewPat.Size = new System.Drawing.Size(107, 62);
            this.btnNewPat.TabIndex = 3;
            this.btnNewPat.Text = "Add New Patient";
            this.btnNewPat.UseVisualStyleBackColor = true;
            this.btnNewPat.Click += new System.EventHandler(this.btnNewPat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(43, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(229, 217);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(107, 62);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out ";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 618);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewPat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnNewPat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
    }
}