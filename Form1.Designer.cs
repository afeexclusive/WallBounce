namespace WallBounce
{
    partial class BallWall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BallWall));
            this.ball = new System.Windows.Forms.PictureBox();
            this.strock = new System.Windows.Forms.PictureBox();
            this.horizontal = new System.Windows.Forms.Timer(this.components);
            this.vertical = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPaused = new System.Windows.Forms.Panel();
            this.lbPause = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.timerscore = new System.Windows.Forms.Timer(this.components);
            this.lbHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPaused.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(12, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(52, 52);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // strock
            // 
            this.strock.BackColor = System.Drawing.Color.Lime;
            this.strock.Location = new System.Drawing.Point(322, 557);
            this.strock.Name = "strock";
            this.strock.Size = new System.Drawing.Size(196, 11);
            this.strock.TabIndex = 1;
            this.strock.TabStop = false;
            // 
            // horizontal
            // 
            this.horizontal.Enabled = true;
            this.horizontal.Interval = 10;
            this.horizontal.Tick += new System.EventHandler(this.horizontal_Tick);
            // 
            // vertical
            // 
            this.vertical.Enabled = true;
            this.vertical.Interval = 10;
            this.vertical.Tick += new System.EventHandler(this.vertical_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(851, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPaused
            // 
            this.panelPaused.Controls.Add(this.lbPause);
            this.panelPaused.Location = new System.Drawing.Point(42, 189);
            this.panelPaused.Name = "panelPaused";
            this.panelPaused.Size = new System.Drawing.Size(816, 100);
            this.panelPaused.TabIndex = 3;
            this.panelPaused.Visible = false;
            // 
            // lbPause
            // 
            this.lbPause.AutoSize = true;
            this.lbPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPause.Location = new System.Drawing.Point(172, 15);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(528, 73);
            this.lbPause.TabIndex = 0;
            this.lbPause.Text = "Game Paused  II";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.Lime;
            this.lblScores.Location = new System.Drawing.Point(433, 11);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(85, 20);
            this.lblScores.TabIndex = 1;
            this.lblScores.Text = "Scores: 0";
            // 
            // timerscore
            // 
            this.timerscore.Enabled = true;
            this.timerscore.Interval = 1000;
            this.timerscore.Tick += new System.EventHandler(this.timerscore_Tick);
            // 
            // lbHighScore
            // 
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScore.ForeColor = System.Drawing.Color.Lime;
            this.lbHighScore.Location = new System.Drawing.Point(265, 11);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(66, 20);
            this.lbHighScore.TabIndex = 4;
            this.lbHighScore.Text = "High: 0";
            // 
            // BallWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(886, 576);
            this.Controls.Add(this.lbHighScore);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.panelPaused);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.strock);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BallWall";
            this.Text = "Wall Ball";
            this.Load += new System.EventHandler(this.BallWall_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BallWall_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BallWall_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPaused.ResumeLayout(false);
            this.panelPaused.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox strock;
        private System.Windows.Forms.Timer horizontal;
        private System.Windows.Forms.Timer vertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPaused;
        private System.Windows.Forms.Label lbPause;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Timer timerscore;
        private System.Windows.Forms.Label lbHighScore;
    }
}

