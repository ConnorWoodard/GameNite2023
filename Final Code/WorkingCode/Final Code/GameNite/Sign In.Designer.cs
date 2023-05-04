namespace GameNite
{
    partial class Sign_In
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
            label1 = new Label();
            txtFirst = new TextBox();
            label2 = new Label();
            txtLast = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnMakeAccount = new Button();
            label7 = new Label();
            lblError = new Label();
            lblError2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(12, 95);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(194, 27);
            txtFirst.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 72);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(264, 95);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(194, 27);
            txtLast.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 144);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 5;
            label4.Text = "Phone #";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 225);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 225);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 7;
            label6.Text = "Confirm Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(264, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(194, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 27);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(264, 248);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(194, 27);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnMakeAccount
            // 
            btnMakeAccount.Location = new Point(135, 380);
            btnMakeAccount.Name = "btnMakeAccount";
            btnMakeAccount.Size = new Size(192, 29);
            btnMakeAccount.TabIndex = 12;
            btnMakeAccount.Text = "Make Account";
            btnMakeAccount.UseVisualStyleBackColor = true;
            btnMakeAccount.Click += btnMakeAccount_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(197, 23);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 13;
            label7.Text = "Sign In";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(53, 317);
            lblError.Name = "lblError";
            lblError.Size = new Size(377, 20);
            lblError.TabIndex = 14;
            lblError.Text = "Please Make Sure You Are Inputting The Same Password";
            // 
            // lblError2
            // 
            lblError2.AutoSize = true;
            lblError2.ForeColor = Color.Red;
            lblError2.Location = new Point(153, 337);
            lblError2.Name = "lblError2";
            lblError2.Size = new Size(154, 20);
            lblError2.TabIndex = 15;
            lblError2.Text = "Please Fill In All Fields";
            // 
            // Sign_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 468);
            Controls.Add(lblError2);
            Controls.Add(lblError);
            Controls.Add(label7);
            Controls.Add(btnMakeAccount);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLast);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(label1);
            Name = "Sign_In";
            Text = "Sign_In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirst;
        private Label label2;
        private TextBox txtLast;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnMakeAccount;
        private Label label7;
        private Label lblError;
        private Label lblError2;
    }
}