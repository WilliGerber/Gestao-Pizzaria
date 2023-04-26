
using System.Configuration;
using System.Drawing;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

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

            string language = ConfigurationManager.AppSettings["IdiomaRegiao"];
            string separadorDecimal;
            string currencySymbol;


            if (language == "pt-BR")
            {
                currencySymbol = "R$";
                separadorDecimal = ",";
            }
            else if (language == "eng")
            {
                currencySymbol = "US$";
                separadorDecimal = ".";
            }
            else if (language == "es")
            {
                currencySymbol = "$";
                separadorDecimal = ",";
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Menu());



            
        }
    }
}
