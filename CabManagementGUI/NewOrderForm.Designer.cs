namespace CabManagementGUI
{
    partial class NewOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAvailableDrivers = new System.Windows.Forms.ComboBox();
            this.textBoxPickupLocation = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrderTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAvailableCars = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAvailableCars = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAvailableDrivers = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order A Cab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Pickup Location";
            // 
            // cboAvailableDrivers
            // 
            this.cboAvailableDrivers.FormattingEnabled = true;
            this.cboAvailableDrivers.Location = new System.Drawing.Point(157, 207);
            this.cboAvailableDrivers.Name = "cboAvailableDrivers";
            this.cboAvailableDrivers.Size = new System.Drawing.Size(273, 24);
            this.cboAvailableDrivers.TabIndex = 2;
            // 
            // textBoxPickupLocation
            // 
            this.textBoxPickupLocation.Location = new System.Drawing.Point(157, 78);
            this.textBoxPickupLocation.Name = "textBoxPickupLocation";
            this.textBoxPickupLocation.Size = new System.Drawing.Size(273, 22);
            this.textBoxPickupLocation.TabIndex = 3;
            // 
            // dateTimePickerOrderTime
            // 
            this.dateTimePickerOrderTime.Location = new System.Drawing.Point(157, 167);
            this.dateTimePickerOrderTime.Name = "dateTimePickerOrderTime";
            this.dateTimePickerOrderTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOrderTime.TabIndex = 4;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(157, 124);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(273, 22);
            this.textBoxDestination.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select The Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select A Driver";
            // 
            // cboAvailableCars
            // 
            this.cboAvailableCars.FormattingEnabled = true;
            this.cboAvailableCars.Location = new System.Drawing.Point(157, 245);
            this.cboAvailableCars.Name = "cboAvailableCars";
            this.cboAvailableCars.Size = new System.Drawing.Size(273, 24);
            this.cboAvailableCars.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select A Car";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(18, 300);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(105, 36);
            this.orderBtn.TabIndex = 11;
            this.orderBtn.Text = "Place Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAvailableCars);
            this.groupBox1.Location = new System.Drawing.Point(467, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 258);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Cars";
            // 
            // dataGridViewAvailableCars
            // 
            this.dataGridViewAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCars.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAvailableCars.Name = "dataGridViewAvailableCars";
            this.dataGridViewAvailableCars.RowHeadersWidth = 51;
            this.dataGridViewAvailableCars.RowTemplate.Height = 24;
            this.dataGridViewAvailableCars.Size = new System.Drawing.Size(525, 231);
            this.dataGridViewAvailableCars.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAvailableDrivers);
            this.groupBox2.Location = new System.Drawing.Point(467, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 247);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Drivers";
            // 
            // dataGridViewAvailableDrivers
            // 
            this.dataGridViewAvailableDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableDrivers.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAvailableDrivers.Name = "dataGridViewAvailableDrivers";
            this.dataGridViewAvailableDrivers.RowHeadersWidth = 51;
            this.dataGridViewAvailableDrivers.RowTemplate.Height = 24;
            this.dataGridViewAvailableDrivers.Size = new System.Drawing.Size(525, 220);
            this.dataGridViewAvailableDrivers.TabIndex = 0;
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboAvailableCars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.dateTimePickerOrderTime);
            this.Controls.Add(this.textBoxPickupLocation);
            this.Controls.Add(this.cboAvailableDrivers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewOrderForm";
            this.Text = "New Order | Cab Management System";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAvailableDrivers;
        private System.Windows.Forms.TextBox textBoxPickupLocation;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderTime;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAvailableCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAvailableCars;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAvailableDrivers;
    }
}