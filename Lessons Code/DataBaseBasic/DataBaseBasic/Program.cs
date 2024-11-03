using Microsoft.Data.Sqlite;

namespace DataBaseBasic
{
    internal static class Program
    {
        static string connectionString = "Data Source=EmployersDatabase.db;";
        public static SqliteConnection connection = new SqliteConnection(connectionString);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}