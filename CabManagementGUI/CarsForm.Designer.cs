namespace CabManagementGUI
{
    partial class CarsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearchCars = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnCarPlateNo = new System.Windows.Forms.RadioButton();
            this.radioBtnCarID = new System.Windows.Forms.RadioButton();
            this.radioBtnCarModel = new System.Windows.Forms.RadioButton();
            this.textBoxCarSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAllCars = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFilteredCars = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonNewCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCarID = new System.Windows.Forms.TextBox();
            this.checkBoxAvailability = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarPlateNo = new System.Windows.Forms.TextBox();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredCars)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearchCars);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxCarSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Cars";
            // 
            // buttonSearchCars
            // 
            this.buttonSearchCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchCars.Location = new System.Drawing.Point(740, 26);
            this.buttonSearchCars.Name = "buttonSearchCars";
            this.buttonSearchCars.Size = new System.Drawing.Size(155, 40);
            this.buttonSearchCars.TabIndex = 2;
            this.buttonSearchCars.Text = "Search Cars";
            this.buttonSearchCars.UseVisualStyleBackColor = true;
            this.buttonSearchCars.Click += new System.EventHandler(this.buttonSearchCars_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnCarPlateNo);
            this.groupBox2.Controls.Add(this.radioBtnCarID);
            this.groupBox2.Controls.Add(this.radioBtnCarModel);
            this.groupBox2.Location = new System.Drawing.Point(349, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By";
            // 
            // radioBtnCarPlateNo
            // 
            this.radioBtnCarPlateNo.AutoSize = true;
            this.radioBtnCarPlateNo.Location = new System.Drawing.Point(207, 18);
            this.radioBtnCarPlateNo.Name = "radioBtnCarPlateNo";
            this.radioBtnCarPlateNo.Size = new System.Drawing.Size(83, 20);
            this.radioBtnCarPlateNo.TabIndex = 2;
            this.radioBtnCarPlateNo.TabStop = true;
            this.radioBtnCarPlateNo.Text = "Plate No.";
            this.radioBtnCarPlateNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnCarID
            // 
            this.radioBtnCarID.AutoSize = true;
            this.radioBtnCarID.Location = new System.Drawing.Point(98, 18);
            this.radioBtnCarID.Name = "radioBtnCarID";
            this.radioBtnCarID.Size = new System.Drawing.Size(65, 20);
            this.radioBtnCarID.TabIndex = 1;
            this.radioBtnCarID.TabStop = true;
            this.radioBtnCarID.Text = "Car ID";
            this.radioBtnCarID.UseVisualStyleBackColor = true;
            this.radioBtnCarID.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnCarModel
            // 
            this.radioBtnCarModel.AutoSize = true;
            this.radioBtnCarModel.Location = new System.Drawing.Point(8, 18);
            this.radioBtnCarModel.Name = "radioBtnCarModel";
            this.radioBtnCarModel.Size = new System.Drawing.Size(66, 20);
            this.radioBtnCarModel.TabIndex = 0;
            this.radioBtnCarModel.TabStop = true;
            this.radioBtnCarModel.Text = "Model";
            this.radioBtnCarModel.UseVisualStyleBackColor = true;
            // 
            // textBoxCarSearch
            // 
            this.textBoxCarSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarSearch.Location = new System.Drawing.Point(23, 32);
            this.textBoxCarSearch.Name = "textBoxCarSearch";
            this.textBoxCarSearch.Size = new System.Drawing.Size(294, 30);
            this.textBoxCarSearch.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewAllCars);
            this.groupBox3.Location = new System.Drawing.Point(12, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 373);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Cars";
            // 
            // dataGridViewAllCars
            // 
            this.dataGridViewAllCars.AllowUserToAddRows = false;
            this.dataGridViewAllCars.AllowUserToDeleteRows = false;
            this.dataGridViewAllCars.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAllCars.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAllCars.Name = "dataGridViewAllCars";
            this.dataGridViewAllCars.RowHeadersWidth = 51;
            this.dataGridViewAllCars.RowTemplate.Height = 24;
            this.dataGridViewAllCars.Size = new System.Drawing.Size(601, 341);
            this.dataGridViewAllCars.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewFilteredCars);
            this.groupBox4.Location = new System.Drawing.Point(629, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 373);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtered Cars";
            // 
            // dataGridViewFilteredCars
            // 
            this.dataGridViewFilteredCars.AllowUserToAddRows = false;
            this.dataGridViewFilteredCars.AllowUserToDeleteRows = false;
            this.dataGridViewFilteredCars.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewFilteredCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilteredCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFilteredCars.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewFilteredCars.Name = "dataGridViewFilteredCars";
            this.dataGridViewFilteredCars.RowHeadersWidth = 51;
            this.dataGridViewFilteredCars.RowTemplate.Height = 24;
            this.dataGridViewFilteredCars.Size = new System.Drawing.Size(554, 341);
            this.dataGridViewFilteredCars.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.buttonNewCar);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBoxCarID);
            this.groupBox5.Controls.Add(this.checkBoxAvailability);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxCarPlateNo);
            this.groupBox5.Controls.Add(this.textBoxCarModel);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 475);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1177, 192);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add/Remove Cars";
            // 
            // buttonNewCar
            // 
            this.buttonNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCar.Location = new System.Drawing.Point(857, 89);
            this.buttonNewCar.Name = "buttonNewCar";
            this.buttonNewCar.Size = new System.Drawing.Size(157, 38);
            this.buttonNewCar.TabIndex = 12;
            this.buttonNewCar.Text = "Remove Car";
            this.buttonNewCar.UseVisualStyleBackColor = true;
            this.buttonNewCar.Click += new System.EventHandler(this.buttonNewCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Car ID";
            // 
            // textBoxCarID
            // 
            this.textBoxCarID.Location = new System.Drawing.Point(754, 48);
            this.textBoxCarID.Name = "textBoxCarID";
            this.textBoxCarID.Size = new System.Drawing.Size(260, 22);
            this.textBoxCarID.TabIndex = 10;
            // 
            // checkBoxAvailability
            // 
            this.checkBoxAvailability.AutoSize = true;
            this.checkBoxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAvailability.Location = new System.Drawing.Point(49, 139);
            this.checkBoxAvailability.Name = "checkBoxAvailability";
            this.checkBoxAvailability.Size = new System.Drawing.Size(98, 24);
            this.checkBoxAvailability.TabIndex = 9;
            this.checkBoxAvailability.Text = "Available";
            this.checkBoxAvailability.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Car Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Plate No.";
            // 
            // textBoxCarPlateNo
            // 
            this.textBoxCarPlateNo.Location = new System.Drawing.Point(123, 89);
            this.textBoxCarPlateNo.Name = "textBoxCarPlateNo";
            this.textBoxCarPlateNo.Size = new System.Drawing.Size(260, 22);
            this.textBoxCarPlateNo.TabIndex = 3;
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Location = new System.Drawing.Point(123, 51);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(260, 22);
            this.textBoxCarModel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remove Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Car";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(824, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Switch Availability";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 679);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarsForm";
            this.Text = "Cars | Cab Management System";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilteredCars)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnCarModel;
        private System.Windows.Forms.TextBox textBoxCarSearch;
        private System.Windows.Forms.RadioButton radioBtnCarID;
        private System.Windows.Forms.RadioButton radioBtnCarPlateNo;
        private System.Windows.Forms.Button buttonSearchCars;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewAllCars;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewFilteredCars;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCarPlateNo;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAvailability;
        private System.Windows.Forms.Button buttonNewCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCarID;
        private System.Windows.Forms.Button button2;
    }
}