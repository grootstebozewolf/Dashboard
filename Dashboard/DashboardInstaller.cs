using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Linq;


namespace HelpdeskKPI
{
    [RunInstaller(true)]
    public partial class DashboardInstaller : Installer
    {

        public DashboardInstaller()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            string targetDirectory = Context.Parameters["targetdir"];
            string exePath = string.Format("{0}HelpdeskKPI.exe", targetDirectory);
            Configuration config = ConfigurationManager.OpenExeConfiguration(exePath);
            config.AppSettings.Settings["LogoLocation"].Value = targetDirectory + @"Icons";
            config.Save();
        }
    }
}
