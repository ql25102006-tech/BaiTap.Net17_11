using Bai6_1_RetailSalesSystem.GUI;

namespace Bai6_1_RetailSalesSystem;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmSalesMain());
    }
}
