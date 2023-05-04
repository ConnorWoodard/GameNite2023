namespace GameNite
{
    partial class CardGames
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lnkCoup = new LinkLabel();
            lnkFluxx = new LinkLabel();
            lnkGloom = new LinkLabel();
            lnkMTG = new LinkLabel();
            lnkPokemon = new LinkLabel();
            lnkONW = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Coup;
            pictureBox1.Location = new Point(61, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Fluxx;
            pictureBox2.Location = new Point(271, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Gloom;
            pictureBox3.Location = new Point(479, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 171);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.MTG;
            pictureBox4.Location = new Point(61, 236);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(169, 171);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.PTCG;
            pictureBox5.Location = new Point(271, 236);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(169, 171);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Werewolf;
            pictureBox6.Location = new Point(479, 236);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(169, 171);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // lnkCoup
            // 
            lnkCoup.AutoSize = true;
            lnkCoup.Location = new Point(122, 213);
            lnkCoup.Name = "lnkCoup";
            lnkCoup.Size = new Size(44, 20);
            lnkCoup.TabIndex = 8;
            lnkCoup.TabStop = true;
            lnkCoup.Text = "Coup";
            lnkCoup.LinkClicked += lnkCoup_LinkClicked;
            // 
            // lnkFluxx
            // 
            lnkFluxx.AutoSize = true;
            lnkFluxx.Location = new Point(332, 213);
            lnkFluxx.Name = "lnkFluxx";
            lnkFluxx.Size = new Size(42, 20);
            lnkFluxx.TabIndex = 9;
            lnkFluxx.TabStop = true;
            lnkFluxx.Text = "Fluxx";
            lnkFluxx.LinkClicked += lnkFluxx_LinkClicked;
            // 
            // lnkGloom
            // 
            lnkGloom.AutoSize = true;
            lnkGloom.Location = new Point(535, 213);
            lnkGloom.Name = "lnkGloom";
            lnkGloom.Size = new Size(54, 20);
            lnkGloom.TabIndex = 10;
            lnkGloom.TabStop = true;
            lnkGloom.Text = "Gloom";
            lnkGloom.LinkClicked += lnkGloom_LinkClicked;
            // 
            // lnkMTG
            // 
            lnkMTG.AutoSize = true;
            lnkMTG.Location = new Point(52, 410);
            lnkMTG.Name = "lnkMTG";
            lnkMTG.Size = new Size(187, 20);
            lnkMTG.TabIndex = 11;
            lnkMTG.TabStop = true;
            lnkMTG.Text = "MTG March of the Machine";
            lnkMTG.LinkClicked += lnkMTG_LinkClicked;
            // 
            // lnkPokemon
            // 
            lnkPokemon.AutoSize = true;
            lnkPokemon.Location = new Point(271, 410);
            lnkPokemon.Name = "lnkPokemon";
            lnkPokemon.Size = new Size(170, 20);
            lnkPokemon.TabIndex = 12;
            lnkPokemon.TabStop = true;
            lnkPokemon.Text = "Pokemon Silver Tempest";
            lnkPokemon.LinkClicked += lnkPokemon_LinkClicked;
            // 
            // lnkONW
            // 
            lnkONW.AutoSize = true;
            lnkONW.Location = new Point(492, 410);
            lnkONW.Name = "lnkONW";
            lnkONW.Size = new Size(144, 20);
            lnkONW.TabIndex = 13;
            lnkONW.TabStop = true;
            lnkONW.Text = "One Night Werewolf";
            lnkONW.LinkClicked += lnkONW_LinkClicked;
            // 
            // CardGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(lnkONW);
            Controls.Add(lnkPokemon);
            Controls.Add(lnkMTG);
            Controls.Add(lnkGloom);
            Controls.Add(lnkFluxx);
            Controls.Add(lnkCoup);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CardGames";
            Text = "CardGames";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private LinkLabel lnkCoup;
        private LinkLabel lnkFluxx;
        private LinkLabel lnkGloom;
        private LinkLabel lnkMTG;
        private LinkLabel lnkPokemon;
        private LinkLabel lnkONW;
    }
}