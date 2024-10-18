namespace RockPaperScissorsWinForms
{
    partial class Form1
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbPlayerChoice = new System.Windows.Forms.PictureBox();
            this.pbComputerChoice = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(287, 293);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(106, 32);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "ROCK";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(213, 331);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(106, 32);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "PAPER";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(351, 331);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(106, 32);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "SCISSORS";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(475, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(163, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Choose Rock, Paper, or Scissors";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(42, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(62, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0 - 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(287, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbPlayerChoice
            // 
            this.pbPlayerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayerChoice.Location = new System.Drawing.Point(45, 101);
            this.pbPlayerChoice.Name = "pbPlayerChoice";
            this.pbPlayerChoice.Size = new System.Drawing.Size(164, 145);
            this.pbPlayerChoice.TabIndex = 6;
            this.pbPlayerChoice.TabStop = false;
            // 
            // pbComputerChoice
            // 
            this.pbComputerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbComputerChoice.Location = new System.Drawing.Point(247, 101);
            this.pbComputerChoice.Name = "pbComputerChoice";
            this.pbComputerChoice.Size = new System.Drawing.Size(163, 147);
            this.pbComputerChoice.TabIndex = 7;
            this.pbComputerChoice.TabStop = false;
            this.pbComputerChoice.Click += new System.EventHandler(this.pbComputerChoice_Click);
            // 
            // pbResult
            // 
            this.pbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResult.Location = new System.Drawing.Point(458, 101);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(180, 147);
            this.pbResult.TabIndex = 8;
            this.pbResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pbComputerChoice);
            this.Controls.Add(this.pbPlayerChoice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbPlayerChoice;
        private System.Windows.Forms.PictureBox pbComputerChoice;
        private System.Windows.Forms.PictureBox pbResult;
    }
}

