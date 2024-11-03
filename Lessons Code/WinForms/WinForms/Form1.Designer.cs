namespace WinForms
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            MainLabel = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            NameInput = new TextBox();
            AgeInput = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            DragButton = new Button();
            PanelData = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 15F);
            MainLabel.Location = new Point(26, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(65, 28);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "label1";
            MainLabel.MouseEnter += MainLabel_MouseEnter;
            MainLabel.MouseLeave += MainLabel_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(238, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 67);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(676, 34);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(236, 23);
            NameInput.TabIndex = 5;
            // 
            // AgeInput
            // 
            AgeInput.Location = new Point(676, 64);
            AgeInput.Name = "AgeInput";
            AgeInput.Size = new Size(236, 23);
            AgeInput.TabIndex = 6;
            AgeInput.TextChanged += AgeInput_TextChanged;
            AgeInput.KeyPress += AgeInput_KeyPress;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(632, 143);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 139);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(632, 104);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(791, 104);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 9;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(DragButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(26, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 330);
            panel1.TabIndex = 10;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // DragButton
            // 
            DragButton.Dock = DockStyle.Top;
            DragButton.Location = new Point(0, 113);
            DragButton.Name = "DragButton";
            DragButton.Size = new Size(596, 53);
            DragButton.TabIndex = 0;
            DragButton.Text = "Move me";
            DragButton.UseVisualStyleBackColor = true;
            DragButton.Click += DragButton_Click;
            DragButton.MouseDown += DragButton_MouseDown;
            DragButton.MouseUp += DragButton_MouseUp;
            // 
            // PanelData
            // 
            PanelData.AutoSize = true;
            PanelData.Font = new Font("Segoe UI", 16F);
            PanelData.Location = new Point(26, 75);
            PanelData.Name = "PanelData";
            PanelData.Size = new Size(0, 30);
            PanelData.TabIndex = 11;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 53);
            button3.Name = "button3";
            button3.Size = new Size(596, 60);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(596, 53);
            button4.TabIndex = 2;
            button4.Text = "Move me";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 166);
            button5.Name = "button5";
            button5.Size = new Size(596, 53);
            button5.TabIndex = 3;
            button5.Text = "Move me";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 219);
            button6.Name = "button6";
            button6.Size = new Size(596, 53);
            button6.TabIndex = 4;
            button6.Text = "Move me";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 272);
            button7.Name = "button7";
            button7.Size = new Size(596, 53);
            button7.TabIndex = 5;
            button7.Text = "Move me";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(997, 450);
            Controls.Add(PanelData);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(AgeInput);
            Controls.Add(NameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(MainLabel);
            Name = "Form1";
            Text = "WindowsFormsEvents";
            Load += Form1_Load;
            ResizeBegin += Form1_ResizeBegin;
            ResizeEnd += Form1_ResizeEnd;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private TextBox NameInput;
        private TextBox AgeInput;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label PanelData;
        private Button DragButton;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button4;
    }
}
