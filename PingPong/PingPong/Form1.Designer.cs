namespace PingPong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackColor = System.Drawing.Color.White;
            this.pbPlayer1.Location = new System.Drawing.Point(68, 84);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(20, 80);
            this.pbPlayer1.TabIndex = 0;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.Color.White;
            this.pbPlayer2.Location = new System.Drawing.Point(536, 84);
            this.pbPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(20, 80);
            this.pbPlayer2.TabIndex = 1;
            this.pbPlayer2.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.Location = new System.Drawing.Point(289, 116);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(25, 25);
            this.pbBall.TabIndex = 2;
            this.pbBall.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 11);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.BackColor = System.Drawing.Color.Black;
            this.lblP1Score.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold);
            this.lblP1Score.ForeColor = System.Drawing.SystemColors.Control;
            this.lblP1Score.Location = new System.Drawing.Point(36, 318);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(81, 90);
            this.lblP1Score.TabIndex = 4;
            this.lblP1Score.Text = "0";
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.BackColor = System.Drawing.Color.Black;
            this.lblP2Score.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold);
            this.lblP2Score.ForeColor = System.Drawing.SystemColors.Control;
            this.lblP2Score.Location = new System.Drawing.Point(521, 318);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(81, 90);
            this.lblP2Score.TabIndex = 5;
            this.lblP2Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbPlayer1;
        public System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label lblP2Score;
    }
}

