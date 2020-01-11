using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Clones are wreaking havoc at the factory. Help!";
            message.IsDistressCall();

        }
    }
}


namespace MyExtensions
{
    public static class HumanExtensions
    {
        public static bool IsDistressCall (this string s)
        {
            if (s.Contains("Help!"))
                return true;
            else
                return false;
        }
    }
}