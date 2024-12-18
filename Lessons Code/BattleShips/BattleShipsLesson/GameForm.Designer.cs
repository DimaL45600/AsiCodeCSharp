namespace BattleShipsLesson
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
            PlayerField = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            EnemyField = new TableLayoutPanel();
            PrepairBox = new GroupBox();
            ResetButton = new Button();
            IsVertical = new CheckBox();
            ShipR4 = new RadioButton();
            ShipR3 = new RadioButton();
            ShipR2 = new RadioButton();
            ShipR1 = new RadioButton();
            ReadyButton = new Button();
            IsHostLabel = new Label();
            label3 = new Label();
            TurnLabel = new Label();
            player4label = new Label();
            player3label = new Label();
            player2label = new Label();
            player1label = new Label();
            enemy1Label = new Label();
            enemy2Label = new Label();
            enemy3Label = new Label();
            enemy4Label = new Label();
            PrepairBox.SuspendLayout();
            SuspendLayout();
            // 
            // PlayerField
            // 
            PlayerField.BackColor = SystemColors.ButtonHighlight;
            PlayerField.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PlayerField.ColumnCount = 10;
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            PlayerField.Location = new Point(12, 35);
            PlayerField.Name = "PlayerField";
            PlayerField.RowCount = 10;
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            PlayerField.Size = new Size(262, 262);
            PlayerField.TabIndex = 0;
            PlayerField.CellPaint += PlayerField_CellPaint;
            PlayerField.MouseClick += PalyerField_MouseClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 23);
            label1.TabIndex = 1;
            label1.Text = "Player Field";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(638, 9);
            label2.Name = "label2";
            label2.Size = new Size(262, 23);
            label2.TabIndex = 3;
            label2.Text = "Enemy Field";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EnemyField
            // 
            EnemyField.BackColor = SystemColors.ButtonHighlight;
            EnemyField.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            EnemyField.ColumnCount = 10;
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            EnemyField.Location = new Point(638, 35);
            EnemyField.Name = "EnemyField";
            EnemyField.RowCount = 10;
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            EnemyField.Size = new Size(262, 262);
            EnemyField.TabIndex = 2;
            EnemyField.CellPaint += EnemyField_CellPaint;
            EnemyField.MouseClick += EnemyField_MouseClick;
            // 
            // PrepairBox
            // 
            PrepairBox.Controls.Add(ResetButton);
            PrepairBox.Controls.Add(IsVertical);
            PrepairBox.Controls.Add(ShipR4);
            PrepairBox.Controls.Add(ShipR3);
            PrepairBox.Controls.Add(ShipR2);
            PrepairBox.Controls.Add(ShipR1);
            PrepairBox.Location = new Point(12, 303);
            PrepairBox.Name = "PrepairBox";
            PrepairBox.Size = new Size(262, 131);
            PrepairBox.TabIndex = 4;
            PrepairBox.TabStop = false;
            PrepairBox.Text = "Ships";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(123, 45);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(133, 23);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // IsVertical
            // 
            IsVertical.AutoSize = true;
            IsVertical.Location = new Point(123, 22);
            IsVertical.Name = "IsVertical";
            IsVertical.Size = new Size(64, 19);
            IsVertical.TabIndex = 4;
            IsVertical.Text = "Vertical";
            IsVertical.UseVisualStyleBackColor = true;
            // 
            // ShipR4
            // 
            ShipR4.AutoSize = true;
            ShipR4.Location = new Point(6, 97);
            ShipR4.Name = "ShipR4";
            ShipR4.Size = new Size(112, 19);
            ShipR4.TabIndex = 3;
            ShipR4.Text = "battleship       (1)";
            ShipR4.UseVisualStyleBackColor = true;
            ShipR4.CheckedChanged += ShipR4_CheckedChanged;
            // 
            // ShipR3
            // 
            ShipR3.AutoSize = true;
            ShipR3.Location = new Point(6, 72);
            ShipR3.Name = "ShipR3";
            ShipR3.Size = new Size(112, 19);
            ShipR3.TabIndex = 2;
            ShipR3.Text = "cruisers           (2)";
            ShipR3.UseVisualStyleBackColor = true;
            ShipR3.CheckedChanged += ShipR3_CheckedChanged;
            // 
            // ShipR2
            // 
            ShipR2.AutoSize = true;
            ShipR2.Location = new Point(6, 47);
            ShipR2.Name = "ShipR2";
            ShipR2.Size = new Size(111, 19);
            ShipR2.TabIndex = 1;
            ShipR2.Text = "destroyers      (3)";
            ShipR2.UseVisualStyleBackColor = true;
            ShipR2.CheckedChanged += ShipR2_CheckedChanged;
            // 
            // ShipR1
            // 
            ShipR1.AutoSize = true;
            ShipR1.Checked = true;
            ShipR1.Location = new Point(6, 22);
            ShipR1.Name = "ShipR1";
            ShipR1.Size = new Size(111, 19);
            ShipR1.TabIndex = 0;
            ShipR1.TabStop = true;
            ShipR1.Text = "torpedo boat (4)";
            ShipR1.UseVisualStyleBackColor = true;
            ShipR1.CheckedChanged += ShipR1_CheckedChanged;
            // 
            // ReadyButton
            // 
            ReadyButton.Enabled = false;
            ReadyButton.Location = new Point(280, 35);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(352, 23);
            ReadyButton.TabIndex = 5;
            ReadyButton.Text = "Ready";
            ReadyButton.UseVisualStyleBackColor = true;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // IsHostLabel
            // 
            IsHostLabel.Location = new Point(280, 15);
            IsHostLabel.Name = "IsHostLabel";
            IsHostLabel.Size = new Size(352, 23);
            IsHostLabel.TabIndex = 6;
            IsHostLabel.Text = "label3";
            IsHostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(814, 15);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Ready";
            label3.Visible = false;
            // 
            // TurnLabel
            // 
            TurnLabel.Location = new Point(280, 39);
            TurnLabel.Name = "TurnLabel";
            TurnLabel.Size = new Size(352, 23);
            TurnLabel.TabIndex = 8;
            TurnLabel.Text = "Turn";
            TurnLabel.TextAlign = ContentAlignment.MiddleCenter;
            TurnLabel.Visible = false;
            // 
            // player4label
            // 
            player4label.AutoSize = true;
            player4label.Location = new Point(280, 61);
            player4label.Name = "player4label";
            player4label.Size = new Size(68, 15);
            player4label.TabIndex = 9;
            player4label.Text = "Player(4) : 1";
            // 
            // player3label
            // 
            player3label.AutoSize = true;
            player3label.Location = new Point(280, 76);
            player3label.Name = "player3label";
            player3label.Size = new Size(68, 15);
            player3label.TabIndex = 10;
            player3label.Text = "Player(3) : 2";
            // 
            // player2label
            // 
            player2label.AutoSize = true;
            player2label.Location = new Point(280, 91);
            player2label.Name = "player2label";
            player2label.Size = new Size(68, 15);
            player2label.TabIndex = 11;
            player2label.Text = "Player(2) : 3";
            // 
            // player1label
            // 
            player1label.AutoSize = true;
            player1label.Location = new Point(280, 106);
            player1label.Name = "player1label";
            player1label.Size = new Size(71, 15);
            player1label.TabIndex = 12;
            player1label.Text = "Player(1) : 4 ";
            // 
            // enemy1Label
            // 
            enemy1Label.AutoSize = true;
            enemy1Label.Location = new Point(564, 106);
            enemy1Label.Name = "enemy1Label";
            enemy1Label.Size = new Size(75, 15);
            enemy1Label.TabIndex = 16;
            enemy1Label.Text = "Enemy(1) : 4 ";
            // 
            // enemy2Label
            // 
            enemy2Label.AutoSize = true;
            enemy2Label.Location = new Point(564, 91);
            enemy2Label.Name = "enemy2Label";
            enemy2Label.Size = new Size(72, 15);
            enemy2Label.TabIndex = 15;
            enemy2Label.Text = "Enemy(2) : 3";
            // 
            // enemy3Label
            // 
            enemy3Label.AutoSize = true;
            enemy3Label.Location = new Point(564, 76);
            enemy3Label.Name = "enemy3Label";
            enemy3Label.Size = new Size(72, 15);
            enemy3Label.TabIndex = 14;
            enemy3Label.Text = "Enemy(3) : 2";
            // 
            // enemy4Label
            // 
            enemy4Label.AutoSize = true;
            enemy4Label.Location = new Point(564, 61);
            enemy4Label.Name = "enemy4Label";
            enemy4Label.Size = new Size(72, 15);
            enemy4Label.TabIndex = 13;
            enemy4Label.Text = "Enemy(4) : 1";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 554);
            Controls.Add(enemy1Label);
            Controls.Add(enemy2Label);
            Controls.Add(enemy3Label);
            Controls.Add(enemy4Label);
            Controls.Add(player1label);
            Controls.Add(player2label);
            Controls.Add(player3label);
            Controls.Add(player4label);
            Controls.Add(TurnLabel);
            Controls.Add(label3);
            Controls.Add(IsHostLabel);
            Controls.Add(ReadyButton);
            Controls.Add(PrepairBox);
            Controls.Add(label2);
            Controls.Add(EnemyField);
            Controls.Add(label1);
            Controls.Add(PlayerField);
            Name = "GameForm";
            Text = "GameForm";
            FormClosing += GameForm_FormClosing;
            PrepairBox.ResumeLayout(false);
            PrepairBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel PlayerField;
        private Label label1;
        private Label label2;
        private TableLayoutPanel EnemyField;
        private GroupBox PrepairBox;
        private CheckBox IsVertical;
        private RadioButton ShipR4;
        private RadioButton ShipR3;
        private RadioButton ShipR2;
        private RadioButton ShipR1;
        private Button ResetButton;
        private Button ReadyButton;
        private Label IsHostLabel;
        private Label label3;
        private Label TurnLabel;
        private Label player4label;
        private Label player3label;
        private Label player2label;
        private Label player1label;
        private Label enemy1Label;
        private Label enemy2Label;
        private Label enemy3Label;
        private Label enemy4Label;
    }
}