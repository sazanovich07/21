namespace WinFormsApp1
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            chipsLabel = new Label();
            scoreLabel = new Label();
            currentPlayerLabel = new Label();
            rollButton = new Button();
            stopButton = new Button();
            pictureBox = new PictureBox();
            betButton = new Button();
            bankLabel = new Label();
            minimum = new Label();
            GameOver = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // chipsLabel
            // 
            chipsLabel.AutoSize = true;
            chipsLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            chipsLabel.ForeColor = SystemColors.ControlLightLight;
            chipsLabel.Location = new Point(41, 298);
            chipsLabel.Name = "chipsLabel";
            chipsLabel.Size = new Size(302, 40);
            chipsLabel.TabIndex = 21;
            chipsLabel.Text = "Количество денег";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            scoreLabel.ForeColor = SystemColors.ControlLightLight;
            scoreLabel.Location = new Point(805, 68);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(450, 40);
            scoreLabel.TabIndex = 20;
            scoreLabel.Text = "Количество очков в раунде";
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.BackColor = Color.FromArgb(67, 135, 60);
            currentPlayerLabel.Cursor = Cursors.IBeam;
            currentPlayerLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            currentPlayerLabel.ForeColor = SystemColors.ControlLightLight;
            currentPlayerLabel.Location = new Point(75, 68);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(198, 40);
            currentPlayerLabel.TabIndex = 19;
            currentPlayerLabel.Text = "Имя игрока";
            // 
            // rollButton
            // 
            rollButton.BackColor = Color.FromArgb(207, 67, 51);
            rollButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rollButton.ForeColor = SystemColors.ControlLightLight;
            rollButton.Location = new Point(805, 468);
            rollButton.Name = "rollButton";
            rollButton.Size = new Size(169, 111);
            rollButton.TabIndex = 18;
            rollButton.Text = "Бросить кость";
            rollButton.UseVisualStyleBackColor = false;
            rollButton.Click += Roll_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.FromArgb(207, 67, 51);
            stopButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            stopButton.ForeColor = SystemColors.ControlLightLight;
            stopButton.Location = new Point(1086, 468);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(169, 111);
            stopButton.TabIndex = 17;
            stopButton.Text = "Завершить ход";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += Stop_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(491, 176);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(243, 250);
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            // 
            // betButton
            // 
            betButton.BackColor = Color.FromArgb(207, 67, 51);
            betButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            betButton.ForeColor = SystemColors.ControlLightLight;
            betButton.Location = new Point(104, 468);
            betButton.Name = "betButton";
            betButton.Size = new Size(169, 111);
            betButton.TabIndex = 23;
            betButton.Text = "Сделать ставку";
            betButton.UseVisualStyleBackColor = false;
            betButton.Click += Bet_Click;
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            bankLabel.ForeColor = SystemColors.ControlLightLight;
            bankLabel.Location = new Point(491, 68);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new Size(215, 40);
            bankLabel.TabIndex = 24;
            bankLabel.Text = "Банк раунда";
            // 
            // minimum
            // 
            minimum.AutoSize = true;
            minimum.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            minimum.ForeColor = SystemColors.ControlLightLight;
            minimum.Location = new Point(805, 298);
            minimum.Name = "minimum";
            minimum.Size = new Size(339, 40);
            minimum.TabIndex = 25;
            minimum.Text = "Минимальное число";
            // 
            // GameOver
            // 
            GameOver.AutoSize = true;
            GameOver.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            GameOver.ForeColor = SystemColors.ControlLightLight;
            GameOver.Location = new Point(540, 68);
            GameOver.Name = "GameOver";
            GameOver.Size = new Size(98, 40);
            GameOver.TabIndex = 26;
            GameOver.Text = "label1";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 135, 60);
            ClientSize = new Size(1374, 616);
            Controls.Add(bankLabel);
            Controls.Add(GameOver);
            Controls.Add(minimum);
            Controls.Add(betButton);
            Controls.Add(chipsLabel);
            Controls.Add(scoreLabel);
            Controls.Add(currentPlayerLabel);
            Controls.Add(rollButton);
            Controls.Add(stopButton);
            Controls.Add(pictureBox);
            Name = "GameForm";
            Text = "Игра";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label chipsLabel;
        private Label scoreLabel;
        private Label currentPlayerLabel;
        private Button rollButton;
        private Button stopButton;
        private PictureBox pictureBox;
        private Button betButton;
        private Label bankLabel;
        private Label minimum;
        private Label GameOver;
    }
}