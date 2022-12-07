using System.ComponentModel;
using System.Configuration.Install;

namespace Loginside_FYAN_Bot_Service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller() => InitializeComponent();
    }
}
