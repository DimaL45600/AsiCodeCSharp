namespace EntityFrameWork
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
            OutputListBox = new ListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            BrandNameInput = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            BasePriceInput = new NumericUpDown();
            ModelNameInput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BrandIdSelect = new ComboBox();
            groupBox3 = new GroupBox();
            SpecNameInput = new TextBox();
            label8 = new Label();
            ModelIdSelect = new ComboBox();
            button4 = new Button();
            AddedPriceInput = new NumericUpDown();
            label7 = new Label();
            DriveTypeInput = new TextBox();
            TransmissionInput = new TextBox();
            EngineInput = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BasePriceInput).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddedPriceInput).BeginInit();
            SuspendLayout();
            // 
            // OutputListBox
            // 
            OutputListBox.FormattingEnabled = true;
            OutputListBox.ItemHeight = 15;
            OutputListBox.Location = new Point(302, 11);
            OutputListBox.Name = "OutputListBox";
            OutputListBox.Size = new Size(486, 589);
            OutputListBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(302, 601);
            button1.Name = "button1";
            button1.Size = new Size(486, 23);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BrandNameInput);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 78);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "BrandData";
            // 
            // button2
            // 
            button2.Location = new Point(6, 51);
            button2.Name = "button2";
            button2.Size = new Size(272, 23);
            button2.TabIndex = 2;
            button2.Text = "Add Brand";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Brand name";
            // 
            // BrandNameInput
            // 
            BrandNameInput.Location = new Point(83, 22);
            BrandNameInput.Name = "BrandNameInput";
            BrandNameInput.Size = new Size(195, 23);
            BrandNameInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(BasePriceInput);
            groupBox2.Controls.Add(ModelNameInput);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(BrandIdSelect);
            groupBox2.Location = new Point(12, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 145);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ModelData";
            // 
            // button3
            // 
            button3.Location = new Point(6, 116);
            button3.Name = "button3";
            button3.Size = new Size(272, 23);
            button3.TabIndex = 5;
            button3.Text = "Add model";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BasePriceInput
            // 
            BasePriceInput.Location = new Point(83, 87);
            BasePriceInput.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            BasePriceInput.Name = "BasePriceInput";
            BasePriceInput.Size = new Size(195, 23);
            BasePriceInput.TabIndex = 4;
            // 
            // ModelNameInput
            // 
            ModelNameInput.Location = new Point(83, 54);
            ModelNameInput.Name = "ModelNameInput";
            ModelNameInput.Size = new Size(195, 23);
            ModelNameInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Base price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Model name";
            // 
            // BrandIdSelect
            // 
            BrandIdSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            BrandIdSelect.FormattingEnabled = true;
            BrandIdSelect.Location = new Point(6, 22);
            BrandIdSelect.Name = "BrandIdSelect";
            BrandIdSelect.Size = new Size(272, 23);
            BrandIdSelect.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SpecNameInput);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(ModelIdSelect);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(AddedPriceInput);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(DriveTypeInput);
            groupBox3.Controls.Add(TransmissionInput);
            groupBox3.Controls.Add(EngineInput);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(18, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(278, 251);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Specification";
            // 
            // SpecNameInput
            // 
            SpecNameInput.Location = new Point(100, 57);
            SpecNameInput.Name = "SpecNameInput";
            SpecNameInput.Size = new Size(172, 23);
            SpecNameInput.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 60);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 10;
            label8.Text = "Spec name";
            // 
            // ModelIdSelect
            // 
            ModelIdSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ModelIdSelect.FormattingEnabled = true;
            ModelIdSelect.Location = new Point(0, 22);
            ModelIdSelect.Name = "ModelIdSelect";
            ModelIdSelect.Size = new Size(272, 23);
            ModelIdSelect.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(6, 198);
            button4.Name = "button4";
            button4.Size = new Size(266, 23);
            button4.TabIndex = 8;
            button4.Text = "add spec";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AddedPriceInput
            // 
            AddedPriceInput.Location = new Point(100, 169);
            AddedPriceInput.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            AddedPriceInput.Name = "AddedPriceInput";
            AddedPriceInput.Size = new Size(172, 23);
            AddedPriceInput.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 172);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 6;
            label7.Text = "Added price";
            // 
            // DriveTypeInput
            // 
            DriveTypeInput.Location = new Point(100, 140);
            DriveTypeInput.Name = "DriveTypeInput";
            DriveTypeInput.Size = new Size(172, 23);
            DriveTypeInput.TabIndex = 5;
            // 
            // TransmissionInput
            // 
            TransmissionInput.Location = new Point(100, 114);
            TransmissionInput.Name = "TransmissionInput";
            TransmissionInput.Size = new Size(172, 23);
            TransmissionInput.TabIndex = 4;
            // 
            // EngineInput
            // 
            EngineInput.Location = new Point(100, 86);
            EngineInput.Name = "EngineInput";
            EngineInput.Size = new Size(172, 23);
            EngineInput.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 143);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 2;
            label6.Text = "Drive type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 117);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 1;
            label5.Text = "Transmission";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 89);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Engine";
            // 
            // button5
            // 
            button5.Location = new Point(18, 504);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(OutputListBox);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BasePriceInput).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddedPriceInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox OutputListBox;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label1;
        private TextBox BrandNameInput;
        private GroupBox groupBox2;
        private ComboBox BrandIdSelect;
        private Button button3;
        private NumericUpDown BasePriceInput;
        private TextBox ModelNameInput;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button4;
        private NumericUpDown AddedPriceInput;
        private Label label7;
        private TextBox DriveTypeInput;
        private TextBox TransmissionInput;
        private TextBox EngineInput;
        private ComboBox ModelIdSelect;
        private TextBox SpecNameInput;
        private Label label8;
        private Button button5;
    }
}
