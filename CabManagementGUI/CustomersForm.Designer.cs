namespace CabManagementGUI
{
    partial class CustomersForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioBtnCustName = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioBtnCustPhone = new System.Windows.Forms.RadioButton();
            this.radioBtnCustEmail = new System.Windows.Forms.RadioButton();
            this.radioBtnCustID = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewFiltered = new System.Windows.Forms.DataGridView();
            this.dataGridViewAllCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customers";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioBtnCustName);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.radioBtnCustPhone);
            this.groupBox5.Controls.Add(this.radioBtnCustEmail);
            this.groupBox5.Controls.Add(this.radioBtnCustID);
            this.groupBox5.Location = new System.Drawing.Point(6, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(572, 51);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter by";
            // 
            // radioBtnCustName
            // 
            this.radioBtnCustName.AutoSize = true;
            this.radioBtnCustName.Location = new System.Drawing.Point(12, 21);
            this.radioBtnCustName.Name = "radioBtnCustName";
            this.radioBtnCustName.Size = new System.Drawing.Size(65, 20);
            this.radioBtnCustName.TabIndex = 3;
            this.radioBtnCustName.TabStop = true;
            this.radioBtnCustName.Text = "Name";
            this.radioBtnCustName.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBtnCustPhone
            // 
            this.radioBtnCustPhone.AutoSize = true;
            this.radioBtnCustPhone.Location = new System.Drawing.Point(263, 21);
            this.radioBtnCustPhone.Name = "radioBtnCustPhone";
            this.radioBtnCustPhone.Size = new System.Drawing.Size(91, 20);
            this.radioBtnCustPhone.TabIndex = 2;
            this.radioBtnCustPhone.TabStop = true;
            this.radioBtnCustPhone.Text = "Phone No.";
            this.radioBtnCustPhone.UseVisualStyleBackColor = true;
            // 
            // radioBtnCustEmail
            // 
            this.radioBtnCustEmail.AutoSize = true;
            this.radioBtnCustEmail.Location = new System.Drawing.Point(170, 21);
            this.radioBtnCustEmail.Name = "radioBtnCustEmail";
            this.radioBtnCustEmail.Size = new System.Drawing.Size(62, 20);
            this.radioBtnCustEmail.TabIndex = 1;
            this.radioBtnCustEmail.TabStop = true;
            this.radioBtnCustEmail.Text = "Email";
            this.radioBtnCustEmail.UseVisualStyleBackColor = true;
            // 
            // radioBtnCustID
            // 
            this.radioBtnCustID.AutoSize = true;
            this.radioBtnCustID.Location = new System.Drawing.Point(101, 21);
            this.radioBtnCustID.Name = "radioBtnCustID";
            this.radioBtnCustID.Size = new System.Drawing.Size(41, 20);
            this.radioBtnCustID.TabIndex = 0;
            this.radioBtnCustID.TabStop = true;
            this.radioBtnCustID.Text = "ID";
            this.radioBtnCustID.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Customers By Name, ID, E-mail or Phone number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(572, 28);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewFiltered
            // 
            this.dataGridViewFiltered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltered.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewFiltered.Name = "dataGridViewFiltered";
            this.dataGridViewFiltered.RowHeadersWidth = 51;
            this.dataGridViewFiltered.RowTemplate.Height = 24;
            this.dataGridViewFiltered.Size = new System.Drawing.Size(593, 279);
            this.dataGridViewFiltered.TabIndex = 1;
            this.dataGridViewFiltered.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewAllCustomers
            // 
            this.dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCustomers.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            this.dataGridViewAllCustomers.RowHeadersWidth = 51;
            this.dataGridViewAllCustomers.RowTemplate.Height = 24;
            this.dataGridViewAllCustomers.Size = new System.Drawing.Size(773, 414);
            this.dataGridViewAllCustomers.TabIndex = 2;
            this.dataGridViewAllCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllCustomers_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAllCustomers);
            this.groupBox2.Location = new System.Drawing.Point(617, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 444);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Customers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewFiltered);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 306);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtered Customers";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 459);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomersForm";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewFiltered;
        private System.Windows.Forms.DataGridView dataGridViewAllCustomers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioBtnCustName;
        private System.Windows.Forms.RadioButton radioBtnCustPhone;
        private System.Windows.Forms.RadioButton radioBtnCustEmail;
        private System.Windows.Forms.RadioButton radioBtnCustID;
    }
}