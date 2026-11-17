using Bai6_2_HRMPayrollSystem.GUI;

namespace Bai6_2_HRMPayrollSystem;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmHRMMain());
    }
}
