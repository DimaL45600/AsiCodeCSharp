namespace DataBaseBasic
{
    partial class PositionAdding
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
            button1 = new Button();
            NameInput = new TextBox();
            SalaryInput = new NumericUpDown();
            AccesSelecter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)SalaryInput).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 99);
            button1.Name = "button1";
            button1.Size = new Size(199, 50);
            button1.TabIndex = 0;
            button1.Text = "Add position";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(12, 12);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(199, 23);
            NameInput.TabIndex = 1;
            // 
            // SalaryInput
            // 
            SalaryInput.Location = new Point(12, 41);
            SalaryInput.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            SalaryInput.Name = "SalaryInput";
            SalaryInput.Size = new Size(199, 23);
            SalaryInput.TabIndex = 2;
            // 
            // AccesSelecter
            // 
            AccesSelecter.FormattingEnabled = true;
            AccesSelecter.Items.AddRange(new object[] { "Basic", "Medium", "Full" });
            AccesSelecter.Location = new Point(12, 70);
            AccesSelecter.Name = "AccesSelecter";
            AccesSelecter.Size = new Size(199, 23);
            AccesSelecter.TabIndex = 3;
            // 
            // PositionAdding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 160);
            Controls.Add(AccesSelecter);
            Controls.Add(SalaryInput);
            Controls.Add(NameInput);
            Controls.Add(button1);
            Name = "PositionAdding";
            Text = "PositionAdding";
            ((System.ComponentModel.ISupportInitialize)SalaryInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox NameInput;
        private NumericUpDown SalaryInput;
        private ComboBox AccesSelecter;
    }
}