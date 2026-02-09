using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_crash
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}
    using System;

    class Program
    {
        // Application version
        const int AppVersion = 3;

        // Feature toggles (Enabled / Disabled)
        static readonly bool LoginEnabled = true;
        static readonly bool ExportEnabled = false;
        static readonly bool AdminPanelEnabled = true;

        // Minimum required versions
        const int LoginMinVersion = 1;
        const int ExportMinVersion = 3;
        const int AdminPanelMinVersion = 4;

        static void Main()
        {
            CheckFeature("Login", LoginEnabled, LoginMinVersion);
            CheckFeature("Export", ExportEnabled, ExportMinVersion);
            CheckFeature("AdminPanel", AdminPanelEnabled, AdminPanelMinVersion);
        }

        static void CheckFeature(string name, bool enabled, int minVersion)
        {
            if (enabled)
            {
                string result = AppVersion >= minVersion
                    ? "Feature is running "
                    : "App version too low   ";

                Console.WriteLine($"{name}: {result}");
            }
            else
            {
                Console.WriteLine($"{name}: Feature is disabled ❌");
            }
        }
    }

}
