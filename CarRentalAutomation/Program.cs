using OfficeOpenXml;

namespace CarRentalAutomation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            using (SplashScreen splashScreen = new SplashScreen())
            {
                if (splashScreen.ShowDialog() == DialogResult.OK)
                {
                    using (UserLogin loginForm = new UserLogin())
                    {
                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new MainForm());
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    //Application.Run(new MainForm());
                }
                else
                {
                    Application.Exit();
                }
            }

        }
    }
}