using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThisPage299
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get; }
        public int StingerLength { get; set; }
        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int length)
        {
            return 1;
        }
    }
}
