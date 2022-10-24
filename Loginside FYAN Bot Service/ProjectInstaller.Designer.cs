namespace Loginside_FYAN_Bot_Service
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallermain = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerMain = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallermain
            // 
            this.serviceProcessInstallermain.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallermain.Password = null;
            this.serviceProcessInstallermain.Username = null;
            // 
            // serviceInstallerMain
            // 
            this.serviceInstallerMain.Description = "FRT Inside autobot YAN";
            this.serviceInstallerMain.DisplayName = "Loginside FYAN Bot";
            this.serviceInstallerMain.ServiceName = "ServiceLoginsideFYANBot";
            this.serviceInstallerMain.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallermain,
            this.serviceInstallerMain});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallermain;
        private System.ServiceProcess.ServiceInstaller serviceInstallerMain;
    }
}