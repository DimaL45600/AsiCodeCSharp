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
            HostLabel = new Label();
            JoinBox = new GroupBox();
            CancelButton = new Button();
            Connect = new Button();
            label3 = new Label();
            label2 = new Label();
            PortInput = new TextBox();
            IPInput = new TextBox();
            CancelHostButton = new Button();
            ExitButton = new Button();
            JoinBox.SuspendLayout();
            SuspendLayout();
            // 
            // HostButton
            // 
            HostButton.Location = new Point(12, 89);
            HostButton.Name = "HostButton";
            HostButton.Size = new Size(263, 44);
            HostButton.TabIndex = 0;
            HostButton.Text = "Host";
            HostButton.UseVisualStyleBackColor = true;
            HostButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 86);
            label1.TabIndex = 1;
            label1.Text = "BattleShips";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // JoinButton
            // 
            JoinButton.Location = new Point(12, 167);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(263, 44);
            JoinButton.TabIndex = 2;
            JoinButton.Text = "Join";
            JoinButton.UseVisualStyleBackColor = true;
            JoinButton.Click += JoinButton_Click;
            // 
            // HostLabel
            // 
            HostLabel.AutoSize = true;
            HostLabel.Location = new Point(12, 143);
            HostLabel.Name = "HostLabel";
            HostLabel.Size = new Size(38, 15);
            HostLabel.TabIndex = 3;
            HostLabel.Text = "label2";
            HostLabel.Visible = false;
            // 
            // JoinBox
            // 
            JoinBox.Controls.Add(CancelButton);
            JoinBox.Controls.Add(Connect);
            JoinBox.Controls.Add(label3);
            JoinBox.Controls.Add(label2);
            JoinBox.Controls.Add(PortInput);
            JoinBox.Controls.Add(IPInput);
            JoinBox.Location = new Point(12, 217);
            JoinBox.Name = "JoinBox";
            JoinBox.Size = new Size(263, 139);
            JoinBox.TabIndex = 4;
            JoinBox.TabStop = false;
            JoinBox.Text = "Join data";
            JoinBox.Visible = false;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(6, 109);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(251, 23);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Connect
            // 
            Connect.Location = new Point(6, 80);
            Connect.Name = "Connect";
            Connect.Size = new Size(251, 23);
            Connect.TabIndex = 4;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "PORT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "IP";
            // 
            // PortInput
            // 
            PortInput.Location = new Point(50, 51);
            PortInput.Name = "PortInput";
            PortInput.Size = new Size(207, 23);
            PortInput.TabIndex = 1;
            // 
            // IPInput
            // 
            IPInput.Location = new Point(50, 22);
            IPInput.Name = "IPInput";
            IPInput.Size = new Size(207, 23);
            IPInput.TabIndex = 0;
            IPInput.Text = "127.0.0.1";
            // 
            // CancelHostButton
            // 
            CancelHostButton.Location = new Point(186, 139);
            CancelHostButton.Name = "CancelHostButton";
            CancelHostButton.Size = new Size(89, 23);
            CancelHostButton.TabIndex = 6;
            CancelHostButton.Text = "Cancel";
            CancelHostButton.UseVisualStyleBackColor = true;
            CancelHostButton.Visible = false;
            CancelHostButton.Click += CancelHostButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 362);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(263, 44);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 418);
            Controls.Add(ExitButton);
            Controls.Add(CancelHostButton);
            Controls.Add(JoinBox);
            Controls.Add(HostLabel);
            Controls.Add(JoinButton);
            Controls.Add(label1);
            Controls.Add(HostButton);
            Name = "MenuForm";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            JoinBox.ResumeLayout(false);
            JoinBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HostButton;
        private Label label1;
        private Button JoinButton;
        private Label HostLabel;
        private GroupBox JoinBox;
        private Button Connect;
        private Label label3;
        private Label label2;
        private TextBox PortInput;
        private TextBox IPInput;
        private Button CancelButton;
        private Button CancelHostButton;
        private Button ExitButton;
    }
}
