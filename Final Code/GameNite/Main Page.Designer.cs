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
            pbBanner = new PictureBox();
            lnkLogIn = new LinkLabel();
            lnkSignUp = new LinkLabel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnCheckOut = new Button();
            lnkAccessories = new LinkLabel();
            lnkBoardGames = new LinkLabel();
            lnkBooks = new LinkLabel();
            lnkCardGames = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pbBanner).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pbBanner
            // 
            pbBanner.Location = new Point(12, 12);
            pbBanner.Name = "pbBanner";
            pbBanner.Size = new Size(808, 73);
            pbBanner.TabIndex = 0;
            pbBanner.TabStop = false;
            // 
            // lnkLogIn
            // 
            lnkLogIn.AutoSize = true;
            lnkLogIn.Location = new Point(826, 12);
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
            lnkSignUp.Location = new Point(826, 52);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(61, 20);
            lnkSignUp.TabIndex = 2;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            lnkSignUp.VisitedLinkColor = Color.Blue;
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(695, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(826, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(61, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Board Games";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(111, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Card Games";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(71, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Books";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 116);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(107, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Accessories";
            checkBox4.TextAlign = ContentAlignment.TopCenter;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(128, 150);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dice;
            pictureBox1.Location = new Point(253, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Catan;
            pictureBox2.Location = new Point(432, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CoC;
            pictureBox3.Location = new Point(253, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Fluxx;
            pictureBox4.Location = new Point(432, 274);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 112);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(793, 380);
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
            lnkAccessories.Location = new Point(276, 234);
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
            lnkBoardGames.Location = new Point(447, 234);
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
            lnkBooks.Location = new Point(294, 389);
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
            lnkCardGames.Location = new Point(447, 389);
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
            ClientSize = new Size(899, 450);
            Controls.Add(lnkCardGames);
            Controls.Add(lnkBooks);
            Controls.Add(lnkBoardGames);
            Controls.Add(lnkAccessories);
            Controls.Add(btnCheckOut);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lnkSignUp);
            Controls.Add(lnkLogIn);
            Controls.Add(pbBanner);
            Name = "Main_Page";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pbBanner).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBanner;
        private LinkLabel lnkLogIn;
        private LinkLabel lnkSignUp;
        private TextBox txtSearch;
        private Button btnSearch;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox1;
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