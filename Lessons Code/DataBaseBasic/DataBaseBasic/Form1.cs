
using Microsoft.Data.Sqlite;
using System.Data;
namespace DataBaseBasic
{
    public partial class Form1 : Form
    {

        int selectedCell = 0;
        string connectionString = "Data Source=EmployersDatabase.db;";
        public Form1()
        {
            InitializeComponent();
            SQLitePCL.Batteries.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectDataQuery = "SELECT PersonData.Id, PersonData.Name, PersonData.SurName, PersonData.Age, Positions.Name AS \"Position\", Positions.Access, Positions.Salary, (Positions.Salary * 12) AS \"Annual Salary\" FROM PersonData " + 
                        "JOIN Positions ON PersonData.PositionId = Positions.Id;";
                    DataTable dt = new DataTable();
                    using (SqliteCommand command = new SqliteCommand(selectDataQuery, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                       dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        void AddPerson()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO PersonData (Name,Age,SurName) VALUES(@Name, @Age, @SurName)";

                using (SqliteCommand command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", NameInput.Text);
                    command.Parameters.AddWithValue("@Age", (int)AgeInput.Value);
                    command.Parameters.AddWithValue("@SurName", SurNameInput.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Data Added!");
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedCell = int.Parse(dataGridView1.CurrentCell.Value.ToString());
                groupBox2.Text = selectedCell.ToString();
                LoadPersonData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                selectedCell = -1;
                groupBox2.Text = "Select id";
            }

        }
        void LoadPersonData()
        {
            string selectQuery = $"SELECT Name, SurName, Age, PositionId FROM PersonData WHERE Id = {selectedCell};";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(selectQuery, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EditName.Text = reader["Name"].ToString();
                            EditSurName.Text = reader["SurName"].ToString();
                            EditAge.Value = Convert.ToInt32(reader["Age"]);
                            comboBox1.SelectedIndex = Convert.ToInt32(reader["PositionId"])-1;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedCell != -1) EditPerson();
            else MessageBox.Show("Select ID!");
        }

        void EditPerson()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = $"UPDATE PersonData SET Name = @Name, SurName = @SurName, Age = @Age, PositionId = @PositionId WHERE Id = {selectedCell}";
                using (SqliteCommand command = new SqliteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", EditName.Text);
                    command.Parameters.AddWithValue("@Age", (int)EditAge.Value);
                    command.Parameters.AddWithValue("@SurName", EditSurName.Text);
                    command.Parameters.AddWithValue("@PositionId", comboBox1.SelectedIndex+1);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Data was updated!");
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedCell != -1)
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = $"DELETE FROM PersonData;";// WHERE Id = {selectedCell}";
                    using (SqliteCommand command = new SqliteCommand(deleteQuery, connection))
                    {
                        label1.Text = command.ExecuteNonQuery().ToString();
                    }
                }
                MessageBox.Show("Data was Deleted!");
                LoadData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2.GetInstance().Show();
        }
    }
}
