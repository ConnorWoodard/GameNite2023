namespace GameNite
{
    partial class Log_In
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
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            lblError = new Label();
            label5 = new Label();
            btnSignUp = new Button();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 27);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(339, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(59, 247);
            lblError.Name = "lblError";
            lblError.Size = new Size(232, 28);
            lblError.TabIndex = 5;
            lblError.Text = "Invalid Email/Password";
            lblError.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(104, 306);
            label5.Name = "label5";
            label5.Size = new Size(130, 56);
            label5.TabIndex = 6;
            label5.Text = "Don't Have\r\nAn Account?";
            label5.Visible = false;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(118, 374);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(118, 205);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 8;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(btnLogIn);
            Controls.Add(btnSignUp);
            Controls.Add(label5);
            Controls.Add(lblError);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Log_In";
            Text = "Log_In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Label lblError;
        private Label label5;
        private Button btnSignUp;
        private Button btnLogIn;
    }
}