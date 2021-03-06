using System;
using System.Collections.Generic;
using System.Text;

namespace Eshopping.PainelAdministrador.Data
{
    public class AppSettings
    {
        public const string SectionName = "AppSettings";
        public string ProjectPath { get; set; }
        public string ConnectionString { get; set; }
        public string DBProviderFactory { get; set; }
        public string[] AllowedReferrers { get; set; }
        public bool EnabledProfiler { get; set; }
    }
}
