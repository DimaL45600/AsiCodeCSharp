namespace DataBaseBasic
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
            button1 = new Button();
            NameInput = new TextBox();
            SurNameInput = new TextBox();
            AgeInput = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            EditAge = new NumericUpDown();
            EditSurName = new TextBox();
            EditName = new TextBox();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AgeInput).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 224);
            button1.Name = "button1";
            button1.Size = new Size(800, 43);
            button1.TabIndex = 1;
            button1.Text = "Load data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(12, 22);
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "Enter Name";
            NameInput.Size = new Size(100, 23);
            NameInput.TabIndex = 2;
            // 
            // SurNameInput
            // 
            SurNameInput.Location = new Point(12, 51);
            SurNameInput.Name = "SurNameInput";
            SurNameInput.PlaceholderText = "Enter SurName";
            SurNameInput.Size = new Size(100, 23);
            SurNameInput.TabIndex = 3;
            // 
            // AgeInput
            // 
            AgeInput.Location = new Point(12, 80);
            AgeInput.Name = "AgeInput";
            AgeInput.Size = new Size(100, 23);
            AgeInput.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(12, 109);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "Add Person";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 133);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 6;
            button3.Text = "Edit Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NameInput);
            groupBox1.Controls.Add(SurNameInput);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(AgeInput);
            groupBox1.Location = new Point(0, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 139);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Data";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(EditAge);
            groupBox2.Controls.Add(EditSurName);
            groupBox2.Controls.Add(EditName);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(128, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(119, 162);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cleaner", "Director", "Manager" });
            comboBox1.Location = new Point(6, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 10;
            // 
            // EditAge
            // 
            EditAge.Location = new Point(6, 77);
            EditAge.Name = "EditAge";
            EditAge.Size = new Size(107, 23);
            EditAge.TabIndex = 9;
            // 
            // EditSurName
            // 
            EditSurName.Location = new Point(6, 48);
            EditSurName.Name = "EditSurName";
            EditSurName.Size = new Size(107, 23);
            EditSurName.TabIndex = 8;
            // 
            // EditName
            // 
            EditName.Location = new Point(6, 22);
            EditName.Name = "EditName";
            EditName.Size = new Size(107, 23);
            EditName.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(253, 389);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Delete Data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 371);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // button5
            // 
            button5.Location = new Point(601, 276);
            button5.Name = "button5";
            button5.Size = new Size(187, 23);
            button5.TabIndex = 11;
            button5.Text = "Open positions window";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 206);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AgeInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox NameInput;
        private TextBox SurNameInput;
        private NumericUpDown AgeInput;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown EditAge;
        private TextBox EditSurName;
        private TextBox EditName;
        private Button button4;
        private Label label1;
        private Button button5;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}
