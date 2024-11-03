using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private List<Person> persons;
        private bool isDraging = false;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var formData = sender as Form1;
            formData.Text = "LoadedForm";
            MainLabel.Text = "Form Loaded";
            textBox1.Visible = false;
            timer1.Enabled = true;
        }

        private void MainLabel_MouseEnter(object sender, EventArgs e)
        {
            MainLabel.BackColor = Color.Azure;
        }

        private void MainLabel_MouseLeave(object sender, EventArgs e)
        {
            MainLabel.BackColor = Color.Blue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MainLabel.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AgeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-') e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                persons.Add(new Person() { Name = NameInput.Text, Age = int.Parse(AgeInput.Text) });
                string data = $"{persons.Count - 1}| {persons.Last().ToString()}";
                listBox1.Items.Add(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("incorect age input", "Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var answer = MessageBox.Show("Delete selectedItem?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No || answer == DialogResult.Cancel) return;
                var toDelete = int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]);
                persons.RemoveAt(toDelete);
                listBox1.Items.Clear();
                for (int i = 0; i < persons.Count; i++)
                {
                    listBox1.Items.Add($"{i}| {persons[i].ToString()}");
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            PanelData.Text = $"Mouse coordinates: X-{e.X}, Y-{e.Y}";
            if (isDraging)
            {
                DragButton.Location = new Point(e.X + 37, e.Y + 11);
            }
        }

        private void DragButton_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void DragButton_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void DragButton_Click(object sender, EventArgs e)
        {
            if (isDraging) isDraging = false;
            else isDraging = true;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MainLabel.Text = "Resize start";
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void AgeInput_TextChanged(object sender, EventArgs e)
        {
            label2.Text = AgeInput.Text;
        }
    }
}
