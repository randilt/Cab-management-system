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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewFiltered = new System.Windows.Forms.DataGridView();
            this.dataGridViewAllCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCustEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustNIC = new System.Windows.Forms.TextBox();
            this.textBoxCustContact = new System.Windows.Forms.TextBox();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioBtnCustID = new System.Windows.Forms.RadioButton();
            this.radioBtnCustEmail = new System.Windows.Forms.RadioButton();
            this.radioBtnCustPhone = new System.Windows.Forms.RadioButton();
            this.radioBtnCustName = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBoxCustEmail);
            this.groupBox4.Controls.Add(this.textBoxCustNIC);
            this.groupBox4.Controls.Add(this.textBoxCustContact);
            this.groupBox4.Controls.Add(this.textBoxCustName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 472);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 182);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Customer";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxCustEmail
            // 
            this.textBoxCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustEmail.Location = new System.Drawing.Point(193, 133);
            this.textBoxCustEmail.Name = "textBoxCustEmail";
            this.textBoxCustEmail.Size = new System.Drawing.Size(370, 28);
            this.textBoxCustEmail.TabIndex = 8;
            // 
            // textBoxCustNIC
            // 
            this.textBoxCustNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustNIC.Location = new System.Drawing.Point(193, 99);
            this.textBoxCustNIC.Name = "textBoxCustNIC";
            this.textBoxCustNIC.Size = new System.Drawing.Size(370, 28);
            this.textBoxCustNIC.TabIndex = 7;
            // 
            // textBoxCustContact
            // 
            this.textBoxCustContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustContact.Location = new System.Drawing.Point(193, 64);
            this.textBoxCustContact.Name = "textBoxCustContact";
            this.textBoxCustContact.Size = new System.Drawing.Size(370, 28);
            this.textBoxCustContact.TabIndex = 6;
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustName.Location = new System.Drawing.Point(193, 27);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(370, 28);
            this.textBoxCustName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIC Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contact No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
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
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomersForm";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCustEmail;
        private System.Windows.Forms.TextBox textBoxCustNIC;
        private System.Windows.Forms.TextBox textBoxCustContact;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioBtnCustName;
        private System.Windows.Forms.RadioButton radioBtnCustPhone;
        private System.Windows.Forms.RadioButton radioBtnCustEmail;
        private System.Windows.Forms.RadioButton radioBtnCustID;
    }
}