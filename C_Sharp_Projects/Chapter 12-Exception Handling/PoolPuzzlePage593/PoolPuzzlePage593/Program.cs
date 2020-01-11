using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PoolPuzzlePage593
{
    class Program
    {
        static void Main(string[] args)
        {
            Kangaroo joey = new Kangaroo();
            int koala = joey.Wombat(joey.Wombat(joey.Wombat(1)));

            try
            {
                Console.WriteLine((15 / koala) + " eggs per pound");
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("G'Day Mate!");
            }

            Console.ReadKey();
        }
    }

    class Kangaroo
    {
        FileStream fs;
        int croc;
        int dingo = 0;

        public int Wombat(int wallaby)
        {
            wallaby++;

            try
            {
                if( croc > 0)
                {
                    fs = File.OpenWrite("wobbiegong");
                    croc = 0;
                }
                else if (croc < 0)
                {
                    croc = 3;
                }
                else
                {
                    fs = File.OpenRead("wobbiegong");
                    croc = 1;
                }
            }
            catch (IOException)
            {
                croc = -3;
            }
            catch
            {
                croc = 4;
            }

            finally
            {
                if ( wallaby > 2)
                {
                    croc-=dingo;
                }
            }

            return dingo;
        }
    }
}
