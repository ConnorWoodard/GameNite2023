namespace GameNite
{
    partial class Main_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lnkLogIn = new LinkLabel();
            lnkSignUp = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnCheckOut = new Button();
            lnkAccessories = new LinkLabel();
            lnkBoardGames = new LinkLabel();
            lnkBooks = new LinkLabel();
            lnkCardGames = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lnkLogIn
            // 
            lnkLogIn.AutoSize = true;
            lnkLogIn.Location = new Point(447, 29);
            lnkLogIn.Name = "lnkLogIn";
            lnkLogIn.Size = new Size(50, 20);
            lnkLogIn.TabIndex = 1;
            lnkLogIn.TabStop = true;
            lnkLogIn.Text = "Log In";
            lnkLogIn.VisitedLinkColor = Color.Blue;
            lnkLogIn.LinkClicked += lnkLogIn_LinkClicked;
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.Location = new Point(447, 65);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(61, 20);
            lnkSignUp.TabIndex = 2;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            lnkSignUp.VisitedLinkColor = Color.Blue;
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dice;
            pictureBox1.Location = new Point(103, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Catan;
            pictureBox2.Location = new Point(328, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CoC;
            pictureBox3.Location = new Point(103, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Fluxx;
            pictureBox4.Location = new Point(328, 274);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 112);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(502, 412);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(94, 29);
            btnCheckOut.TabIndex = 19;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lnkAccessories
            // 
            lnkAccessories.AutoSize = true;
            lnkAccessories.Location = new Point(123, 234);
            lnkAccessories.Name = "lnkAccessories";
            lnkAccessories.Size = new Size(85, 20);
            lnkAccessories.TabIndex = 20;
            lnkAccessories.TabStop = true;
            lnkAccessories.Text = "Accessories";
            lnkAccessories.VisitedLinkColor = Color.Blue;
            lnkAccessories.LinkClicked += lnkAccessories_LinkClicked;
            // 
            // lnkBoardGames
            // 
            lnkBoardGames.AutoSize = true;
            lnkBoardGames.Location = new Point(343, 234);
            lnkBoardGames.Name = "lnkBoardGames";
            lnkBoardGames.Size = new Size(98, 20);
            lnkBoardGames.TabIndex = 21;
            lnkBoardGames.TabStop = true;
            lnkBoardGames.Text = "Board Games";
            lnkBoardGames.VisitedLinkColor = Color.Blue;
            lnkBoardGames.LinkClicked += lnkBoardGames_LinkClicked;
            // 
            // lnkBooks
            // 
            lnkBooks.AutoSize = true;
            lnkBooks.Location = new Point(144, 389);
            lnkBooks.Name = "lnkBooks";
            lnkBooks.Size = new Size(49, 20);
            lnkBooks.TabIndex = 22;
            lnkBooks.TabStop = true;
            lnkBooks.Text = "Books";
            lnkBooks.VisitedLinkColor = Color.Blue;
            lnkBooks.LinkClicked += lnkBooks_LinkClicked;
            // 
            // lnkCardGames
            // 
            lnkCardGames.AutoSize = true;
            lnkCardGames.Location = new Point(343, 389);
            lnkCardGames.Name = "lnkCardGames";
            lnkCardGames.Size = new Size(89, 20);
            lnkCardGames.TabIndex = 23;
            lnkCardGames.TabStop = true;
            lnkCardGames.Text = "Card Games";
            lnkCardGames.VisitedLinkColor = Color.Blue;
            lnkCardGames.LinkClicked += lnkCardGames_LinkClicked;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(608, 453);
            Controls.Add(lnkCardGames);
            Controls.Add(lnkBooks);
            Controls.Add(lnkBoardGames);
            Controls.Add(lnkAccessories);
            Controls.Add(btnCheckOut);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lnkSignUp);
            Controls.Add(lnkLogIn);
            Name = "Main_Page";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lnkLogIn;
        private LinkLabel lnkSignUp;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnCheckOut;
        private LinkLabel lnkAccessories;
        private LinkLabel lnkBoardGames;
        private LinkLabel lnkBooks;
        private LinkLabel lnkCardGames;
    }
}