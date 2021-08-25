namespace SDEV_360_Motorcycle_Game
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
            this.Acceleration = new System.Windows.Forms.Timer(this.components);
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.timerFlyingImagemover = new System.Windows.Forms.Timer(this.components);
            this.timerControlFlying = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxFlying = new PictureBoxEx();
            this.pictureBoxBiker = new PictureBoxEx();
            this.pictureBoxTarget = new PictureBoxEx();
            this.buttonEndGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBiker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // Acceleration
            // 
            this.Acceleration.Enabled = true;
            this.Acceleration.Interval = 20;
            this.Acceleration.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerAnimate
            // 
            this.timerAnimate.Enabled = true;
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // timerSpeed
            // 
            this.timerSpeed.Enabled = true;
            this.timerSpeed.Interval = 8;
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // timerFlyingImagemover
            // 
            this.timerFlyingImagemover.Enabled = true;
            this.timerFlyingImagemover.Interval = 30;
            this.timerFlyingImagemover.Tick += new System.EventHandler(this.timerFlyingImagemover_Tick);
            // 
            // timerControlFlying
            // 
            this.timerControlFlying.Enabled = true;
            this.timerControlFlying.Interval = 40;
            this.timerControlFlying.Tick += new System.EventHandler(this.timerControlFlying_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Click anywhere on the screen to accelerate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(849, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "Keep clicking after the crash to boost to the target!";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Red;
            this.labelScore.Location = new System.Drawing.Point(13, 25);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(207, 60);
            this.labelScore.TabIndex = 21;
            this.labelScore.Text = "Score: ";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxFlying
            // 
            this.pictureBoxFlying.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFlying.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.flying01;
            this.pictureBoxFlying.Location = new System.Drawing.Point(-16, 863);
            this.pictureBoxFlying.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFlying.Name = "pictureBoxFlying";
            this.pictureBoxFlying.Size = new System.Drawing.Size(78, 96);
            this.pictureBoxFlying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFlying.TabIndex = 18;
            this.pictureBoxFlying.TabStop = false;
            this.pictureBoxFlying.Visible = false;
            // 
            // pictureBoxBiker
            // 
            this.pictureBoxBiker.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBiker.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.sprite_bike__5_01;
            this.pictureBoxBiker.Location = new System.Drawing.Point(40, 329);
            this.pictureBoxBiker.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBiker.Name = "pictureBoxBiker";
            this.pictureBoxBiker.Size = new System.Drawing.Size(78, 96);
            this.pictureBoxBiker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBiker.TabIndex = 17;
            this.pictureBoxBiker.TabStop = false;
            this.pictureBoxBiker.Click += new System.EventHandler(this.pictureBoxEx1_Click);
            // 
            // pictureBoxTarget
            // 
            this.pictureBoxTarget.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTarget.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.Target_1;
            this.pictureBoxTarget.Location = new System.Drawing.Point(2376, 1040);
            this.pictureBoxTarget.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTarget.Name = "pictureBoxTarget";
            this.pictureBoxTarget.Size = new System.Drawing.Size(137, 279);
            this.pictureBoxTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTarget.TabIndex = 16;
            this.pictureBoxTarget.TabStop = false;
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndGame.Location = new System.Drawing.Point(417, 459);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(381, 205);
            this.buttonEndGame.TabIndex = 22;
            this.buttonEndGame.Text = "Press to update score";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Visible = false;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SDEV_360_Motorcycle_Game.Properties.Resources.backgrounddual21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1372, 892);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFlying);
            this.Controls.Add(this.pictureBoxBiker);
            this.Controls.Add(this.pictureBoxTarget);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1374, 840);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotorCycle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBiker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer Acceleration;
        public System.Windows.Forms.Timer timerAnimate;
        private PictureBoxEx pictureBoxTarget;
        private PictureBoxEx pictureBoxBiker;
        public System.Windows.Forms.Timer timerSpeed;
        private PictureBoxEx pictureBoxFlying;
        public System.Windows.Forms.Timer timerFlyingImagemover;
        public System.Windows.Forms.Timer timerControlFlying;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonEndGame;
    }
}

