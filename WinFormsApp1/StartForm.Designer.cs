namespace WinFormsApp1
{
    partial class StartForm
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
            inputPlayer = new TextBox();
            startGameButton = new Button();
            numPlayer = new Label();
            SuspendLayout();
            // 
            // inputPlayer
            // 
            inputPlayer.BackColor = Color.FromArgb(67, 135, 60);
            inputPlayer.Font = new Font("Tw Cen MT Condensed Extra Bold", 40F);
            inputPlayer.ForeColor = SystemColors.ControlLightLight;
            inputPlayer.Location = new Point(695, 256);
            inputPlayer.MaxLength = 1;
            inputPlayer.Name = "inputPlayer";
            inputPlayer.Size = new Size(45, 65);
            inputPlayer.TabIndex = 7;
            inputPlayer.TextAlign = HorizontalAlignment.Center;
            inputPlayer.UseWaitCursor = true;
            // 
            // startGameButton
            // 
            startGameButton.BackColor = Color.FromArgb(207, 67, 51);
            startGameButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            startGameButton.ForeColor = SystemColors.ControlLightLight;
            startGameButton.Location = new Point(593, 420);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(225, 122);
            startGameButton.TabIndex = 8;
            startGameButton.Text = "Перейти к старту игры";
            startGameButton.UseVisualStyleBackColor = false;
            startGameButton.Click += StartGame_Click;
            // 
            // numPlayer
            // 
            numPlayer.AutoSize = true;
            numPlayer.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            numPlayer.ForeColor = SystemColors.ControlLightLight;
            numPlayer.Location = new Point(390, 80);
            numPlayer.Name = "numPlayer";
            numPlayer.Size = new Size(630, 40);
            numPlayer.TabIndex = 9;
            numPlayer.Text = "Введите количество игроков (от 2 до 6)";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 135, 60);
            ClientSize = new Size(1381, 625);
            Controls.Add(numPlayer);
            Controls.Add(startGameButton);
            Controls.Add(inputPlayer);
            Name = "StartForm";
            Text = "Старт игры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputPlayer;
        private Button startGameButton;
        private Label numPlayer;
    }
}
