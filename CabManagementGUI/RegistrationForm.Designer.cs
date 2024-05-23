namespace CabManagementGUI
{
    partial class RegistrationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCustUsername = new System.Windows.Forms.TextBox();
            this.textBoxCustPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxCustEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustNIC = new System.Windows.Forms.TextBox();
            this.textBoxCustPassword = new System.Windows.Forms.TextBox();
            this.buttonCustRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register To Cab Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone No. : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIC No. : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password : ";
            // 
            // textBoxCustUsername
            // 
            this.textBoxCustUsername.Location = new System.Drawing.Point(205, 117);
            this.textBoxCustUsername.Name = "textBoxCustUsername";
            this.textBoxCustUsername.Size = new System.Drawing.Size(226, 22);
            this.textBoxCustUsername.TabIndex = 6;
            // 
            // textBoxCustPhoneNo
            // 
            this.textBoxCustPhoneNo.Location = new System.Drawing.Point(205, 148);
            this.textBoxCustPhoneNo.Name = "textBoxCustPhoneNo";
            this.textBoxCustPhoneNo.Size = new System.Drawing.Size(226, 22);
            this.textBoxCustPhoneNo.TabIndex = 7;
            // 
            // textBoxCustEmail
            // 
            this.textBoxCustEmail.Location = new System.Drawing.Point(205, 182);
            this.textBoxCustEmail.Name = "textBoxCustEmail";
            this.textBoxCustEmail.Size = new System.Drawing.Size(226, 22);
            this.textBoxCustEmail.TabIndex = 8;
            // 
            // textBoxCustNIC
            // 
            this.textBoxCustNIC.Location = new System.Drawing.Point(205, 212);
            this.textBoxCustNIC.Name = "textBoxCustNIC";
            this.textBoxCustNIC.Size = new System.Drawing.Size(226, 22);
            this.textBoxCustNIC.TabIndex = 9;
            // 
            // textBoxCustPassword
            // 
            this.textBoxCustPassword.Location = new System.Drawing.Point(205, 244);
            this.textBoxCustPassword.Name = "textBoxCustPassword";
            this.textBoxCustPassword.PasswordChar = '*';
            this.textBoxCustPassword.Size = new System.Drawing.Size(226, 22);
            this.textBoxCustPassword.TabIndex = 10;
            // 
            // buttonCustRegister
            // 
            this.buttonCustRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustRegister.Location = new System.Drawing.Point(267, 284);
            this.buttonCustRegister.Name = "buttonCustRegister";
            this.buttonCustRegister.Size = new System.Drawing.Size(164, 47);
            this.buttonCustRegister.TabIndex = 11;
            this.buttonCustRegister.Text = "Register";
            this.buttonCustRegister.UseVisualStyleBackColor = true;
            this.buttonCustRegister.Click += new System.EventHandler(this.buttonCustRegister_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.buttonCustRegister);
            this.Controls.Add(this.textBoxCustPassword);
            this.Controls.Add(this.textBoxCustNIC);
            this.Controls.Add(this.textBoxCustEmail);
            this.Controls.Add(this.textBoxCustPhoneNo);
            this.Controls.Add(this.textBoxCustUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCustUsername;
        private System.Windows.Forms.TextBox textBoxCustPhoneNo;
        private System.Windows.Forms.TextBox textBoxCustEmail;
        private System.Windows.Forms.TextBox textBoxCustNIC;
        private System.Windows.Forms.TextBox textBoxCustPassword;
        private System.Windows.Forms.Button buttonCustRegister;
    }
}