namespace WinFormsApp1
{
    partial class SettingsForm
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
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            bindingSource1 = new BindingSource(components);
            startRoundButton = new Button();
            currentPlayerLabel = new Label();
            Round = new Label();
            rollsLabel = new Label();
            minNumber = new Label();
            minNum = new TextBox();
            saveButton = new Button();
            oneMore = new RadioButton();
            split = new RadioButton();
            playerNameLabel = new Label();
            inputName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // startRoundButton
            // 
            startRoundButton.BackColor = Color.FromArgb(207, 67, 51);
            startRoundButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            startRoundButton.ForeColor = SystemColors.ControlLightLight;
            startRoundButton.Location = new Point(861, 396);
            startRoundButton.Name = "startRoundButton";
            startRoundButton.Size = new Size(169, 111);
            startRoundButton.TabIndex = 10;
            startRoundButton.Text = "Начать игру";
            startRoundButton.UseVisualStyleBackColor = false;
            startRoundButton.Click += Start_Click;
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            currentPlayerLabel.ForeColor = SystemColors.ControlLightLight;
            currentPlayerLabel.Location = new Point(581, 26);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(198, 40);
            currentPlayerLabel.TabIndex = 12;
            currentPlayerLabel.Text = "Имя игрока";
            // 
            // Round
            // 
            Round.AutoSize = true;
            Round.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            Round.ForeColor = SystemColors.ControlLightLight;
            Round.Location = new Point(960, 128);
            Round.Name = "Round";
            Round.Size = new Size(236, 40);
            Round.TabIndex = 14;
            Round.Text = "Исход раунда";
            // 
            // rollsLabel
            // 
            rollsLabel.AutoSize = true;
            rollsLabel.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rollsLabel.Location = new Point(1139, 128);
            rollsLabel.Name = "rollsLabel";
            rollsLabel.Size = new Size(0, 46);
            rollsLabel.TabIndex = 15;
            // 
            // minNumber
            // 
            minNumber.AutoSize = true;
            minNumber.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            minNumber.ForeColor = SystemColors.ControlLightLight;
            minNumber.Location = new Point(530, 134);
            minNumber.Name = "minNumber";
            minNumber.Size = new Size(319, 44);
            minNumber.TabIndex = 20;
            minNumber.Text = "Введите мин число";
            minNumber.UseCompatibleTextRendering = true;
            // 
            // minNum
            // 
            minNum.BackColor = Color.FromArgb(67, 135, 60);
            minNum.Font = new Font("Tw Cen MT Condensed Extra Bold", 40F);
            minNum.ForeColor = SystemColors.ControlLightLight;
            minNum.Location = new Point(640, 258);
            minNum.MaxLength = 2;
            minNum.Name = "minNum";
            minNum.Size = new Size(75, 65);
            minNum.TabIndex = 21;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(207, 67, 51);
            saveButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            saveButton.ForeColor = SystemColors.ControlLightLight;
            saveButton.Location = new Point(356, 396);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(169, 111);
            saveButton.TabIndex = 23;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += Save_Click;
            // 
            // oneMore
            // 
            oneMore.AutoSize = true;
            oneMore.Font = new Font("Tw Cen MT Condensed Extra Bold", 15F);
            oneMore.ForeColor = SystemColors.ControlLightLight;
            oneMore.Location = new Point(1121, 269);
            oneMore.Name = "oneMore";
            oneMore.Size = new Size(163, 27);
            oneMore.TabIndex = 24;
            oneMore.TabStop = true;
            oneMore.Text = "Сыграть доп раунд";
            oneMore.UseVisualStyleBackColor = true;
            // 
            // split
            // 
            split.AutoSize = true;
            split.Font = new Font("Tw Cen MT Condensed Extra Bold", 15F);
            split.ForeColor = SystemColors.ControlLightLight;
            split.Location = new Point(923, 269);
            split.Name = "split";
            split.Size = new Size(135, 27);
            split.TabIndex = 25;
            split.TabStop = true;
            split.Text = "Поделить банк";
            split.UseVisualStyleBackColor = true;
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Font = new Font("Tw Cen MT Condensed Extra Bold", 25F);
            playerNameLabel.ForeColor = SystemColors.ControlLightLight;
            playerNameLabel.Location = new Point(104, 128);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(220, 40);
            playerNameLabel.TabIndex = 26;
            playerNameLabel.Text = "Введите имя\r\n";
            // 
            // inputName
            // 
            inputName.BackColor = Color.FromArgb(67, 135, 60);
            inputName.Font = new Font("Tw Cen MT Condensed Extra Bold", 40F);
            inputName.ForeColor = SystemColors.ControlLightLight;
            inputName.Location = new Point(104, 258);
            inputName.Name = "inputName";
            inputName.Size = new Size(220, 65);
            inputName.TabIndex = 27;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 135, 60);
            ClientSize = new Size(1346, 543);
            Controls.Add(inputName);
            Controls.Add(playerNameLabel);
            Controls.Add(split);
            Controls.Add(oneMore);
            Controls.Add(saveButton);
            Controls.Add(minNum);
            Controls.Add(minNumber);
            Controls.Add(rollsLabel);
            Controls.Add(Round);
            Controls.Add(currentPlayerLabel);
            Controls.Add(startRoundButton);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "SettingsForm";
            Text = "Настройки игры";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private BindingSource bindingSource1;
        private Button startRoundButton;
        private Label currentPlayerLabel;
        private Label scoreLabel;
        private Label Round;
        private Label rollsLabel;
        private Label minNumber;
        private TextBox minNum;
        private Button saveButton;
        private RadioButton oneMore;
        private RadioButton split;
        private Label playerNameLabel;
        private TextBox inputName;
    }
}