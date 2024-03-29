﻿namespace CO435_WinFormsAnswer
{
    partial class GameForm
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
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.comPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scoreRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Score = new System.Windows.Forms.TextBox();
            this.lblRoundNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quitButton.Location = new System.Drawing.Point(710, 329);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(110, 55);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitForm);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scissorsRadioButton);
            this.groupBox1.Controls.Add(this.paperRadioButton);
            this.groupBox1.Controls.Add(this.rockRadioButton);
            this.groupBox1.Controls.Add(this.userPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 487);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You";
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Location = new System.Drawing.Point(59, 356);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(113, 30);
            this.scissorsRadioButton.TabIndex = 3;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            this.scissorsRadioButton.CheckedChanged += new System.EventHandler(this.DisplayScissors);
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(59, 323);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(88, 30);
            this.paperRadioButton.TabIndex = 2;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            this.paperRadioButton.CheckedChanged += new System.EventHandler(this.DisplayPaper);
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.Checked = true;
            this.rockRadioButton.Location = new System.Drawing.Point(59, 289);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(80, 30);
            this.rockRadioButton.TabIndex = 1;
            this.rockRadioButton.TabStop = true;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = true;
            this.rockRadioButton.CheckedChanged += new System.EventHandler(this.DisplayRock);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(6, 47);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(265, 219);
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playButton);
            this.groupBox2.Controls.Add(this.comPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer";
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(78, 317);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(110, 55);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.GetComputerChoice);
            // 
            // comPictureBox
            // 
            this.comPictureBox.Location = new System.Drawing.Point(6, 47);
            this.comPictureBox.Name = "comPictureBox";
            this.comPictureBox.Size = new System.Drawing.Size(265, 219);
            this.comPictureBox.TabIndex = 0;
            this.comPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scoreRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(625, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 276);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Score";
            // 
            // scoreRichTextBox
            // 
            this.scoreRichTextBox.Location = new System.Drawing.Point(19, 47);
            this.scoreRichTextBox.Name = "scoreRichTextBox";
            this.scoreRichTextBox.ReadOnly = true;
            this.scoreRichTextBox.Size = new System.Drawing.Size(238, 219);
            this.scoreRichTextBox.TabIndex = 1;
            this.scoreRichTextBox.TabStop = false;
            this.scoreRichTextBox.Text = "";
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(500, 500);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(300, 23);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score:";
            // 
            // lblRoundNo
            // 
            this.lblRoundNo.AutoSize = true;
            this.lblRoundNo.Location = new System.Drawing.Point(400, 400);
            this.lblRoundNo.Name = "lblRoundNo";
            this.lblRoundNo.Size = new System.Drawing.Size(0, 26);
            this.lblRoundNo.TabIndex = 2;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(912, 510);
            this.Controls.Add(this.lblRoundNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GameForm";
            this.Text = "Rock Paper Scissors by Chris Edgley";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox comPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox scoreRichTextBox;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.Label lblRoundNo;
    }
}