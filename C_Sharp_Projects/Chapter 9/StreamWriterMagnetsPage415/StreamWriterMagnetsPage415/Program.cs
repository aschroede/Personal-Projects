using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterMagnetsPage415
{
    class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }

        class Flobbo
        {
            private string zap;
            public StreamWriter Snobbo()
            {
                return new StreamWriter(@"D:\Documents\Business\C_Sharp_Projects\Chapter 9\StreamWriterMagnetsPage415\macaw.txt");
            }
            public Flobbo(string zap)
            {
                this.zap = zap;
            }

            public bool Blobbo(bool Already, StreamWriter sw)
            {
                if (Already)
                {
                    sw.WriteLine(zap);
                    sw.Close();
                    return false;
                }
                else
                {                  
                    sw.WriteLine(zap);
                    zap = "red orange";
                    return true;
                }
            }

            public bool Blobbo(StreamWriter sw)
            {
                sw.WriteLine(zap);
                zap = "green purple";
                return false;
            }

            // blue yellow
            // green purple
            // red orange
        }
    }
}
