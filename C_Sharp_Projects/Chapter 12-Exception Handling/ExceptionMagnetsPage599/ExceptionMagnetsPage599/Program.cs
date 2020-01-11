using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMagnetsPage599
{
    // when it thaws it throws.
    //
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("when it ");
            ExTestDrive.Zero("yes");
            Console.Write(" it ");
            ExTestDrive.Zero("no");
            Console.WriteLine(".");
            Console.ReadKey();
        }
    }

    class MyException : Exception { }

    class ExTestDrive
    {
        public static void Zero(string test)
        {
            try
            {
                Console.Write("t");
                DoRisky(test);
                Console.Write("o");
            }
            catch (MyException)
            {
                Console.Write("a");
            }
            finally
            {
                Console.Write("w");
                Console.Write("s");
            }

        }

        static void DoRisky(String t)
        {
            Console.Write("h");

            if(t == "yes")
            {
                throw new MyException();
            }
            Console.Write("r");           
        }
    }
}


//a 1
//o 1
//t 2
//w 2
//s 2

    //th a   w s
    //th r o w s