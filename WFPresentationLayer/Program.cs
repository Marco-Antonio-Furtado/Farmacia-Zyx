using System.Globalization;
using WfPresentationLayer.Alteraçoes;
using WfPresentationLayer.FormCadastros;
using WfPresentationLayer.FormsMostrarClientes;
using WfPresentationLayer.Trancaçoes;
using static System.Environment;

namespace WfPresentationLayer
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
            Application.Run(new FormLogin());
        }
    }
}