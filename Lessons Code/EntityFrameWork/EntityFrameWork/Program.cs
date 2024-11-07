namespace EntityFrameWork
{
    internal static class Program
    {
        public static CarContext context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            context = new CarContext();
            Application.Run(new Form1());
        }
    }
}