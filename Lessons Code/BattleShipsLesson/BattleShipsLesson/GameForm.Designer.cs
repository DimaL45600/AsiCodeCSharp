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
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 554);
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
    }
}