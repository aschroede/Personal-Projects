using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HideAndSeek;
using System.Windows.Forms;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace HideAndSeekConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Main logger instance
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                .WriteTo.File("log.txt",
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true)
                .CreateLogger();
            HideAndSeek.Program.Main();
        }
    }
}
