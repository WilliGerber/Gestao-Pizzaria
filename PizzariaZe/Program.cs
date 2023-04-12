
using System.Configuration;
using System.Globalization;
namespace PizzariaZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // en-US, es, pt-BR, etc
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}
