namespace Hangman
{
    partial class frmHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            this.lblSecret = new System.Windows.Forms.Label();
            this.txtBxSecret = new System.Windows.Forms.TextBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.txtBxIncorrect = new System.Windows.Forms.RichTextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtBxWord = new System.Windows.Forms.TextBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtBxGuess = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.picBxBase = new System.Windows.Forms.PictureBox();
            this.picBxTallVert = new System.Windows.Forms.PictureBox();
            this.picBxHorizontal = new System.Windows.Forms.PictureBox();
            this.picBxShortVert = new System.Windows.Forms.PictureBox();
            this.picBxHead = new System.Windows.Forms.PictureBox();
            this.picBxBody = new System.Windows.Forms.PictureBox();
            this.picBxLeftArm = new System.Windows.Forms.PictureBox();
            this.picBxRightArm = new System.Windows.Forms.PictureBox();
            this.picBxRightLeg = new System.Windows.Forms.PictureBox();
            this.picBxLeftLeg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTallVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxShortVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftLeg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(41, 26);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(70, 13);
            this.lblSecret.TabIndex = 0;
            this.lblSecret.Text = "Secret Word:";
            // 
            // txtBxSecret
            // 
            this.txtBxSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSecret.Location = new System.Drawing.Point(44, 42);
            this.txtBxSecret.Name = "txtBxSecret";
            this.txtBxSecret.ReadOnly = true;
            this.txtBxSecret.Size = new System.Drawing.Size(186, 38);
            this.txtBxSecret.TabIndex = 1;
            this.txtBxSecret.TabStop = false;
            this.txtBxSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(323, 26);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(96, 13);
            this.lblIncorrect.TabIndex = 2;
            this.lblIncorrect.Text = "Incorrect Guesses:";
            // 
            // txtBxIncorrect
            // 
            this.txtBxIncorrect.Location = new System.Drawing.Point(326, 42);
            this.txtBxIncorrect.Name = "txtBxIncorrect";
            this.txtBxIncorrect.ReadOnly = true;
            this.txtBxIncorrect.Size = new System.Drawing.Size(191, 96);
            this.txtBxIncorrect.TabIndex = 3;
            this.txtBxIncorrect.TabStop = false;
            this.txtBxIncorrect.Text = "";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(297, 166);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(45, 13);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "Player 1";
            // 
            // txtBxWord
            // 
            this.txtBxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxWord.ForeColor = System.Drawing.Color.Gray;
            this.txtBxWord.Location = new System.Drawing.Point(348, 163);
            this.txtBxWord.Name = "txtBxWord";
            this.txtBxWord.Size = new System.Drawing.Size(100, 20);
            this.txtBxWord.TabIndex = 5;
            this.txtBxWord.Text = "Enter Word";
            this.txtBxWord.TextChanged += new System.EventHandler(this.txtBxWord_TextChanged);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(454, 160);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(47, 23);
            this.btnWord.TabIndex = 6;
            this.btnWord.Text = "&Enter";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Enabled = false;
            this.lblGuess.Location = new System.Drawing.Point(297, 204);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(45, 13);
            this.lblGuess.TabIndex = 7;
            this.lblGuess.Text = "Player 2";
            // 
            // txtBxGuess
            // 
            this.txtBxGuess.Enabled = false;
            this.txtBxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxGuess.ForeColor = System.Drawing.Color.Gray;
            this.txtBxGuess.Location = new System.Drawing.Point(348, 201);
            this.txtBxGuess.Name = "txtBxGuess";
            this.txtBxGuess.Size = new System.Drawing.Size(100, 20);
            this.txtBxGuess.TabIndex = 8;
            this.txtBxGuess.TabStop = false;
            this.txtBxGuess.Text = "Enter Guess";
            this.txtBxGuess.TextChanged += new System.EventHandler(this.txtBxGuess_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(454, 198);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(30, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.TabStop = false;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblWinLose
            // 
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblWinLose.Location = new System.Drawing.Point(295, 267);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(198, 45);
            this.lblWinLose.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(465, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPlay.Location = new System.Drawing.Point(363, 227);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "&Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(373, 335);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 13;
            this.btnAgain.TabStop = false;
            this.btnAgain.Text = "Play &Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // picBxBase
            // 
            this.picBxBase.Image = ((System.Drawing.Image)(resources.GetObject("picBxBase.Image")));
            this.picBxBase.Location = new System.Drawing.Point(25, 312);
            this.picBxBase.Name = "picBxBase";
            this.picBxBase.Size = new System.Drawing.Size(165, 10);
            this.picBxBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxBase.TabIndex = 14;
            this.picBxBase.TabStop = false;
            this.picBxBase.Visible = false;
            // 
            // picBxTallVert
            // 
            this.picBxTallVert.Image = ((System.Drawing.Image)(resources.GetObject("picBxTallVert.Image")));
            this.picBxTallVert.Location = new System.Drawing.Point(96, 102);
            this.picBxTallVert.Name = "picBxTallVert";
            this.picBxTallVert.Size = new System.Drawing.Size(10, 220);
            this.picBxTallVert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxTallVert.TabIndex = 15;
            this.picBxTallVert.TabStop = false;
            this.picBxTallVert.Visible = false;
            // 
            // picBxHorizontal
            // 
            this.picBxHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("picBxHorizontal.Image")));
            this.picBxHorizontal.Location = new System.Drawing.Point(96, 102);
            this.picBxHorizontal.Name = "picBxHorizontal";
            this.picBxHorizontal.Size = new System.Drawing.Size(94, 10);
            this.picBxHorizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxHorizontal.TabIndex = 16;
            this.picBxHorizontal.TabStop = false;
            this.picBxHorizontal.Visible = false;
            // 
            // picBxShortVert
            // 
            this.picBxShortVert.Image = ((System.Drawing.Image)(resources.GetObject("picBxShortVert.Image")));
            this.picBxShortVert.Location = new System.Drawing.Point(180, 102);
            this.picBxShortVert.Name = "picBxShortVert";
            this.picBxShortVert.Size = new System.Drawing.Size(10, 36);
            this.picBxShortVert.TabIndex = 17;
            this.picBxShortVert.TabStop = false;
            this.picBxShortVert.Visible = false;
            // 
            // picBxHead
            // 
            this.picBxHead.Image = ((System.Drawing.Image)(resources.GetObject("picBxHead.Image")));
            this.picBxHead.Location = new System.Drawing.Point(159, 131);
            this.picBxHead.Name = "picBxHead";
            this.picBxHead.Size = new System.Drawing.Size(48, 39);
            this.picBxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxHead.TabIndex = 18;
            this.picBxHead.TabStop = false;
            this.picBxHead.Visible = false;
            // 
            // picBxBody
            // 
            this.picBxBody.Image = ((System.Drawing.Image)(resources.GetObject("picBxBody.Image")));
            this.picBxBody.Location = new System.Drawing.Point(180, 166);
            this.picBxBody.Name = "picBxBody";
            this.picBxBody.Size = new System.Drawing.Size(6, 83);
            this.picBxBody.TabIndex = 19;
            this.picBxBody.TabStop = false;
            this.picBxBody.Visible = false;
            // 
            // picBxLeftArm
            // 
            this.picBxLeftArm.Image = ((System.Drawing.Image)(resources.GetObject("picBxLeftArm.Image")));
            this.picBxLeftArm.Location = new System.Drawing.Point(183, 176);
            this.picBxLeftArm.Name = "picBxLeftArm";
            this.picBxLeftArm.Size = new System.Drawing.Size(50, 40);
            this.picBxLeftArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLeftArm.TabIndex = 20;
            this.picBxLeftArm.TabStop = false;
            this.picBxLeftArm.Visible = false;
            // 
            // picBxRightArm
            // 
            this.picBxRightArm.Image = ((System.Drawing.Image)(resources.GetObject("picBxRightArm.Image")));
            this.picBxRightArm.Location = new System.Drawing.Point(127, 176);
            this.picBxRightArm.Name = "picBxRightArm";
            this.picBxRightArm.Size = new System.Drawing.Size(50, 40);
            this.picBxRightArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxRightArm.TabIndex = 21;
            this.picBxRightArm.TabStop = false;
            this.picBxRightArm.Visible = false;
            // 
            // picBxRightLeg
            // 
            this.picBxRightLeg.Image = ((System.Drawing.Image)(resources.GetObject("picBxRightLeg.Image")));
            this.picBxRightLeg.Location = new System.Drawing.Point(180, 250);
            this.picBxRightLeg.Name = "picBxRightLeg";
            this.picBxRightLeg.Size = new System.Drawing.Size(50, 40);
            this.picBxRightLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxRightLeg.TabIndex = 22;
            this.picBxRightLeg.TabStop = false;
            this.picBxRightLeg.Visible = false;
            // 
            // picBxLeftLeg
            // 
            this.picBxLeftLeg.Image = ((System.Drawing.Image)(resources.GetObject("picBxLeftLeg.Image")));
            this.picBxLeftLeg.Location = new System.Drawing.Point(127, 250);
            this.picBxLeftLeg.Name = "picBxLeftLeg";
            this.picBxLeftLeg.Size = new System.Drawing.Size(50, 40);
            this.picBxLeftLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLeftLeg.TabIndex = 23;
            this.picBxLeftLeg.TabStop = false;
            this.picBxLeftLeg.Visible = false;
            // 
            // frmHangman
            // 
            this.AcceptButton = this.btnWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 380);
            this.Controls.Add(this.picBxLeftLeg);
            this.Controls.Add(this.picBxRightLeg);
            this.Controls.Add(this.picBxRightArm);
            this.Controls.Add(this.picBxLeftArm);
            this.Controls.Add(this.picBxBody);
            this.Controls.Add(this.picBxHead);
            this.Controls.Add(this.picBxShortVert);
            this.Controls.Add(this.picBxHorizontal);
            this.Controls.Add(this.picBxTallVert);
            this.Controls.Add(this.picBxBase);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBxGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.txtBxWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtBxIncorrect);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.txtBxSecret);
            this.Controls.Add(this.lblSecret);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "frmHangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.picBxBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTallVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxShortVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftLeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TextBox txtBxSecret;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.RichTextBox txtBxIncorrect;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtBxWord;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtBxGuess;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.PictureBox picBxBase;
        private System.Windows.Forms.PictureBox picBxTallVert;
        private System.Windows.Forms.PictureBox picBxHorizontal;
        private System.Windows.Forms.PictureBox picBxShortVert;
        private System.Windows.Forms.PictureBox picBxHead;
        private System.Windows.Forms.PictureBox picBxBody;
        private System.Windows.Forms.PictureBox picBxLeftArm;
        private System.Windows.Forms.PictureBox picBxRightArm;
        private System.Windows.Forms.PictureBox picBxRightLeg;
        private System.Windows.Forms.PictureBox picBxLeftLeg;
    }
}

