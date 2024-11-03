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
    
    public partial class Form2 : Form
    {
        List<Position> positionsList;
        string connectionString = "Data Source=EmployersDatabase.db;";
        static Form2? instance = null;
        public Form2()
        {
            InitializeComponent();
            positionsList = new List<Position>();
            LoadData();

        }
        public static Form2 GetInstance()
        {
            if (instance == null)
                instance = new Form2();
            return instance;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
        public void LoadData()
        {
            try
            {
                Program.connection.Open();
                string selectDataQuery = "SELECT Id, Name, Salary, Access FROM Positions";
                using (SqliteCommand command = new SqliteCommand(selectDataQuery, Program.connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (positionsList.Count > 0) positionsList.Clear();
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string name = reader["Name"].ToString();
                            int salary = Convert.ToInt32(reader["Salary"]);
                            string access = reader["Access"].ToString();
                            positionsList.Add(new Position() { Id = id, Name = name, Salary = salary, Access = access });
                        }
                        label1.Text = $"Positions counter = {positionsList.Count}";
                        ShowData();
                    }
                }
                Program.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }
        private void ShowData()
        {
            foreach(Position row in positionsList)
            {
                Panel panel = new Panel();
                panel.Parent = panel1;
                panel.BackColor = Color.White;
                panel.Dock = DockStyle.Top;
                panel.Height = 50;
                Label AccessOutput = new Label();
                AccessOutput.Text = row.Access;
                AccessOutput.Dock = DockStyle.Left;
                AccessOutput.Width = 50;
                AccessOutput.Parent = panel;
                Label SalaryOutput = new Label();
                SalaryOutput.Text = row.Salary.ToString();
                SalaryOutput.Dock = DockStyle.Left;
                SalaryOutput.Width = 50;
                SalaryOutput.Parent = panel;
                Label NameOutput = new Label();
                NameOutput.Text = row.Name;
                NameOutput.Dock = DockStyle.Left;
                NameOutput.Width = 100;
                NameOutput.Parent = panel;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new PositionAdding().ShowDialog();
        }
    }
    class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Access { get; set; }
    }
}
