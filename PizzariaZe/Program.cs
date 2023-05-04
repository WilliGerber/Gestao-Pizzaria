
using System.Configuration;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace PizzariaZe
{
    internal static class Program
    {
        public static string currencySymbol;
        public static string separadorDecimal;
        public static string language = ConfigurationManager.AppSettings["IdiomaRegiao"];
        public static bool isChangingLanguage = false;



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            // en-US, es, pt-BR, etc
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";

            //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            if (language == "pt-BR")
            {
                currencySymbol = "R$";
                separadorDecimal = ",";
            }
            else if (language == "en-US")
            {
                currencySymbol = "$";
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
