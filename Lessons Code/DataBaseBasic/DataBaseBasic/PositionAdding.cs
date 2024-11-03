using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseBasic
{
    public partial class PositionAdding : Form
    {
        public PositionAdding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Add new position?", "Cofirm", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Program.connection.Open();
                string insertQuery = "INSERT INTO Positions (Name,Salary,Access) VALUES(@Name, @Salary, @Access)";

                using (SqliteCommand command = new SqliteCommand(insertQuery, Program.connection))
                {
                    command.Parameters.AddWithValue("@Name", NameInput.Text);
                    command.Parameters.AddWithValue("@Salary", (int)SalaryInput.Value);
                    command.Parameters.AddWithValue("@Access", AccesSelecter.SelectedItem);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Data Added!");
                Program.connection.Close();
                Form2.GetInstance().LoadData();
                this.Close();
            }
        }
    }
}
