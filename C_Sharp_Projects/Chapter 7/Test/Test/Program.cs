using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
                //.WriteTo.File("log.txt",
                //    rollingInterval: RollingInterval.Day,
                //    rollOnFileSizeLimit: true)
                .CreateLogger();
            Log.Error("This is a test of your worthiness");
            Log.Information("This is a test of your worthiness");
            Log.Fatal("This is a test of your worthiness");
            Log.Warning("This is a test of your worthiness");
            Console.ReadKey();
        }
    }
}
