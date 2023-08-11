using RestSharp;

namespace HomeWork_Algebra
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hello from the console!");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}