using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upside;

namespace Sideways
{
    // a buck begets more bucks
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            bool b = true;
            string s = i.ToPrice();
            s.SendIt();

            b.Green().SendIt();
            i = 3;
            i.ToPrice().SendIt();

            b = false;
            b.Green().SendIt();
            
            Console.ReadKey();
        }
    }
}
namespace Upside
{
    public static class Margin
    {
        public static void SendIt(this string s)
        {
            Console.Write(s);
        }

        public static string ToPrice(this int n)
        {
            if (n == 1)
                return "a buck ";
            else
                return "gets";
        }

        public static string Green (this bool b)
        {
            if (b == true)
                return "be";
            else
                return " more bucks";
        }
    }
}
