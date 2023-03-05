using System.ServiceProcess;
using static System.ServiceProcess.ServiceBase;

namespace Loginside_FYAN_Bot_Service;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    private static void Main() => Run(new ServiceBase[]
    {
        new ServiceMain()
    });
}
