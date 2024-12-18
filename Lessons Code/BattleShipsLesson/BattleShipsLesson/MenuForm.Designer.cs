namespace BattleShipsLesson
{
    partial class MenuForm
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
            HostButton = new Button();
            label1 = new Label();
            JoinButton = new Button();
            HostDataLabel = new Label();
            CancelHostButton = new Button();
            JoinBox = new GroupBox();
            JoinCancelButton = new Button();
            ConnectButton = new Button();
            IPInput = new TextBox();
            label2 = new Label();
            ExitButton = new Button();
            JoinBox.SuspendLayout();
            SuspendLayout();
            // 
            // HostButton
            // 
            HostButton.AutoSize = true;
            HostButton.Location = new Point(12, 65);
            HostButton.Name = "HostButton";
            HostButton.Size = new Size(307, 41);
            HostButton.TabIndex = 0;
            HostButton.Text = "Host game";
            HostButton.UseVisualStyleBackColor = true;
            HostButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 62);
            label1.TabIndex = 1;
            label1.Text = "Battleships";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // JoinButton
            // 
            JoinButton.AutoSize = true;
            JoinButton.Location = new Point(12, 134);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(307, 41);
            JoinButton.TabIndex = 2;
            JoinButton.Text = "Join game";
            JoinButton.UseVisualStyleBackColor = true;
            JoinButton.Click += JoinButton_Click;
            // 
            // HostDataLabel
            // 
            HostDataLabel.AutoSize = true;
            HostDataLabel.Location = new Point(12, 109);
            HostDataLabel.Name = "HostDataLabel";
            HostDataLabel.Size = new Size(38, 15);
            HostDataLabel.TabIndex = 3;
            HostDataLabel.Text = "label2";
            HostDataLabel.Visible = false;
            // 
            // CancelHostButton
            // 
            CancelHostButton.Location = new Point(244, 105);
            CancelHostButton.Name = "CancelHostButton";
            CancelHostButton.Size = new Size(75, 23);
            CancelHostButton.TabIndex = 4;
            CancelHostButton.Text = "Cancel";
            CancelHostButton.UseVisualStyleBackColor = true;
            CancelHostButton.Visible = false;
            CancelHostButton.Click += CancelHostButton_Click;
            // 
            // JoinBox
            // 
            JoinBox.Controls.Add(JoinCancelButton);
            JoinBox.Controls.Add(ConnectButton);
            JoinBox.Controls.Add(IPInput);
            JoinBox.Controls.Add(label2);
            JoinBox.Location = new Point(12, 181);
            JoinBox.Name = "JoinBox";
            JoinBox.Size = new Size(307, 109);
            JoinBox.TabIndex = 5;
            JoinBox.TabStop = false;
            JoinBox.Text = "Join data";
            JoinBox.Visible = false;
            // 
            // JoinCancelButton
            // 
            JoinCancelButton.Location = new Point(6, 77);
            JoinCancelButton.Name = "JoinCancelButton";
            JoinCancelButton.Size = new Size(295, 23);
            JoinCancelButton.TabIndex = 3;
            JoinCancelButton.Text = "Cancel";
            JoinCancelButton.UseVisualStyleBackColor = true;
            JoinCancelButton.Click += JoinCancelButton_Click;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(6, 45);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(295, 27);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // IPInput
            // 
            IPInput.Location = new Point(29, 16);
            IPInput.Name = "IPInput";
            IPInput.Size = new Size(272, 23);
            IPInput.TabIndex = 1;
            IPInput.Text = "127.0.0.1";
            IPInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 0;
            label2.Text = "IP";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Location = new Point(12, 309);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(307, 41);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 362);
            Controls.Add(ExitButton);
            Controls.Add(JoinBox);
            Controls.Add(CancelHostButton);
            Controls.Add(HostDataLabel);
            Controls.Add(JoinButton);
            Controls.Add(label1);
            Controls.Add(HostButton);
            Name = "MenuForm";
            Text = "Form1";
            JoinBox.ResumeLayout(false);
            JoinBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HostButton;
        private Label label1;
        private Button JoinButton;
        private Label HostDataLabel;
        private Button CancelHostButton;
        private GroupBox JoinBox;
        private Button JoinCancelButton;
        private Button ConnectButton;
        private TextBox IPInput;
        private Label label2;
        private Button ExitButton;
    }
}
