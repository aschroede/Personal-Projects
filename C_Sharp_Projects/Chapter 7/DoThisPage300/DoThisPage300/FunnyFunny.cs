using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThisPage300
{
    class FunnyFunny : IClown
    {
        protected string funnyThingIHave;

        public FunnyFunny(string funnyThingIhave)
        {
            this.funnyThingIHave = funnyThingIhave;
        }

        public string FunnyThingIhave {
            get
            {
                return "Hi kids! I have " + funnyThingIHave;
            }
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIhave);
        }
    }
}
