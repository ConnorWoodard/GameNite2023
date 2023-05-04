namespace GameNite
{
    partial class ThankYou
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
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 79);
            label1.Name = "label1";
            label1.Size = new Size(236, 72);
            label1.TabIndex = 0;
            label1.Text = "Thank You For Your Purchase!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 173);
            label2.Name = "label2";
            label2.Size = new Size(236, 66);
            label2.TabIndex = 1;
            label2.Text = "We Hope To See You Again!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(131, 284);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ThankYou
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 338);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThankYou";
            Text = "ThankYou";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnClose;
    }
}