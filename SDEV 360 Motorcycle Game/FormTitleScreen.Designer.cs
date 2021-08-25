namespace SDEV_360_Motorcycle_Game
{
    partial class FormTitleScreen
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
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.txtHiddenMemberID = new System.Windows.Forms.TextBox();
            this.labelNewScore = new System.Windows.Forms.Label();
            this.labelLINQ = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Location = new System.Drawing.Point(632, 13);
            this.buttonGameStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(232, 71);
            this.buttonGameStart.TabIndex = 0;
            this.buttonGameStart.Text = "Game Start!";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonGameStart_Click);
            // 
            // txtHiddenMemberID
            // 
            this.txtHiddenMemberID.Location = new System.Drawing.Point(964, 13);
            this.txtHiddenMemberID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHiddenMemberID.Name = "txtHiddenMemberID";
            this.txtHiddenMemberID.Size = new System.Drawing.Size(196, 31);
            this.txtHiddenMemberID.TabIndex = 15;
            this.txtHiddenMemberID.TabStop = false;
            this.txtHiddenMemberID.Visible = false;
            // 
            // labelNewScore
            // 
            this.labelNewScore.AutoSize = true;
            this.labelNewScore.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewScore.ForeColor = System.Drawing.Color.Firebrick;
            this.labelNewScore.Location = new System.Drawing.Point(49, 29);
            this.labelNewScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewScore.Name = "labelNewScore";
            this.labelNewScore.Size = new System.Drawing.Size(430, 55);
            this.labelNewScore.TabIndex = 16;
            this.labelNewScore.Text = "Your new score";
            // 
            // labelLINQ
            // 
            this.labelLINQ.AutoSize = true;
            this.labelLINQ.Location = new System.Drawing.Point(20, 402);
            this.labelLINQ.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLINQ.Name = "labelLINQ";
            this.labelLINQ.Size = new System.Drawing.Size(0, 25);
            this.labelLINQ.TabIndex = 17;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(744, 113);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 31);
            this.textBoxPlayerName.TabIndex = 18;
            // 
            // FormTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 179);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelLINQ);
            this.Controls.Add(this.labelNewScore);
            this.Controls.Add(this.txtHiddenMemberID);
            this.Controls.Add(this.buttonGameStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTitleScreen";
            this.Text = "Motorcycle Game!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTitleScreen_FormClosed);
            this.Load += new System.EventHandler(this.FormTitleScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.TextBox txtHiddenMemberID;
        private System.Windows.Forms.Label labelNewScore;
        private System.Windows.Forms.Label labelLINQ;
        private System.Windows.Forms.TextBox textBoxPlayerName;
    }
}