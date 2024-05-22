namespace CabManagementGUI
{
    partial class DriversForm
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
            this.dataGridViewAllDrivers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.textBoxDriverPhone = new System.Windows.Forms.TextBox();
            this.textBoxDriverEmail = new System.Windows.Forms.TextBox();
            this.textBoxDriverNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxDriverAvailability = new System.Windows.Forms.CheckBox();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDriverID = new System.Windows.Forms.TextBox();
            this.buttonAvailabilitySwitch = new System.Windows.Forms.Button();
            this.buttonRemoveDriver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDrivers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllDrivers
            // 
            this.dataGridViewAllDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllDrivers.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAllDrivers.Name = "dataGridViewAllDrivers";
            this.dataGridViewAllDrivers.RowHeadersWidth = 51;
            this.dataGridViewAllDrivers.RowTemplate.Height = 24;
            this.dataGridViewAllDrivers.Size = new System.Drawing.Size(667, 275);
            this.dataGridViewAllDrivers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAllDrivers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Drivers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonRemoveDriver);
            this.groupBox2.Controls.Add(this.buttonAvailabilitySwitch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxDriverID);
            this.groupBox2.Controls.Add(this.buttonAddDriver);
            this.groupBox2.Controls.Add(this.checkBoxDriverAvailability);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxDriverNIC);
            this.groupBox2.Controls.Add(this.textBoxDriverEmail);
            this.groupBox2.Controls.Add(this.textBoxDriverPhone);
            this.groupBox2.Controls.Add(this.textBoxDriverName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 251);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Drivers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Driver";
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(100, 54);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(199, 22);
            this.textBoxDriverName.TabIndex = 1;
            // 
            // textBoxDriverPhone
            // 
            this.textBoxDriverPhone.Location = new System.Drawing.Point(100, 92);
            this.textBoxDriverPhone.Name = "textBoxDriverPhone";
            this.textBoxDriverPhone.Size = new System.Drawing.Size(199, 22);
            this.textBoxDriverPhone.TabIndex = 2;
            // 
            // textBoxDriverEmail
            // 
            this.textBoxDriverEmail.Location = new System.Drawing.Point(100, 126);
            this.textBoxDriverEmail.Name = "textBoxDriverEmail";
            this.textBoxDriverEmail.Size = new System.Drawing.Size(199, 22);
            this.textBoxDriverEmail.TabIndex = 3;
            // 
            // textBoxDriverNIC
            // 
            this.textBoxDriverNIC.Location = new System.Drawing.Point(100, 165);
            this.textBoxDriverNIC.Name = "textBoxDriverNIC";
            this.textBoxDriverNIC.Size = new System.Drawing.Size(199, 22);
            this.textBoxDriverNIC.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "NIC ";
            // 
            // checkBoxDriverAvailability
            // 
            this.checkBoxDriverAvailability.AutoSize = true;
            this.checkBoxDriverAvailability.Location = new System.Drawing.Point(38, 198);
            this.checkBoxDriverAvailability.Name = "checkBoxDriverAvailability";
            this.checkBoxDriverAvailability.Size = new System.Drawing.Size(86, 20);
            this.checkBoxDriverAvailability.TabIndex = 10;
            this.checkBoxDriverAvailability.Text = "Available";
            this.checkBoxDriverAvailability.UseVisualStyleBackColor = true;
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(202, 198);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(97, 23);
            this.buttonAddDriver.TabIndex = 11;
            this.buttonAddDriver.Text = "Add Driver";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Driver ID";
            // 
            // textBoxDriverID
            // 
            this.textBoxDriverID.Location = new System.Drawing.Point(429, 57);
            this.textBoxDriverID.Name = "textBoxDriverID";
            this.textBoxDriverID.Size = new System.Drawing.Size(199, 22);
            this.textBoxDriverID.TabIndex = 12;
            // 
            // buttonAvailabilitySwitch
            // 
            this.buttonAvailabilitySwitch.Location = new System.Drawing.Point(367, 94);
            this.buttonAvailabilitySwitch.Name = "buttonAvailabilitySwitch";
            this.buttonAvailabilitySwitch.Size = new System.Drawing.Size(127, 23);
            this.buttonAvailabilitySwitch.TabIndex = 14;
            this.buttonAvailabilitySwitch.Text = "Switch Availability";
            this.buttonAvailabilitySwitch.UseVisualStyleBackColor = true;
            this.buttonAvailabilitySwitch.Click += new System.EventHandler(this.buttonAvailabilitySwitch_Click);
            // 
            // buttonRemoveDriver
            // 
            this.buttonRemoveDriver.Location = new System.Drawing.Point(512, 94);
            this.buttonRemoveDriver.Name = "buttonRemoveDriver";
            this.buttonRemoveDriver.Size = new System.Drawing.Size(116, 23);
            this.buttonRemoveDriver.TabIndex = 15;
            this.buttonRemoveDriver.Text = "Remove Driver";
            this.buttonRemoveDriver.UseVisualStyleBackColor = true;
            this.buttonRemoveDriver.Click += new System.EventHandler(this.buttonRemoveDriver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Set Availability/ Remove driver";
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DriversForm";
            this.Text = "Manage Drivers | Cab Management System";
            this.Load += new System.EventHandler(this.DriversForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDrivers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllDrivers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDriverNIC;
        private System.Windows.Forms.TextBox textBoxDriverEmail;
        private System.Windows.Forms.TextBox textBoxDriverPhone;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRemoveDriver;
        private System.Windows.Forms.Button buttonAvailabilitySwitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDriverID;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.CheckBox checkBoxDriverAvailability;
    }
}