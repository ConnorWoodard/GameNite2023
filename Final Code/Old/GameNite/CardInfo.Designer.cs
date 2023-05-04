namespace GameNite
{
    partial class CardInfo
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCardNumber = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnUseCard = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(49, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(291, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(49, 150);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(367, 27);
            txtCardNumber.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(49, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(291, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 45);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 45);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 127);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 7;
            label3.Text = "Card Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 217);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Exp. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 217);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 9;
            label5.Text = "CVC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(140, 9);
            label6.Name = "label6";
            label6.Size = new Size(177, 28);
            label6.TabIndex = 10;
            label6.Text = "Card Information";
            // 
            // btnUseCard
            // 
            btnUseCard.Location = new Point(166, 320);
            btnUseCard.Name = "btnUseCard";
            btnUseCard.Size = new Size(119, 29);
            btnUseCard.TabIndex = 11;
            btnUseCard.Text = "Use Card";
            btnUseCard.UseVisualStyleBackColor = true;
            btnUseCard.Click += btnUseCard_Click;
            // 
            // CardInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 392);
            Controls.Add(btnUseCard);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(txtCardNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "CardInfo";
            Text = "CardInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCardNumber;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnUseCard;
    }
}