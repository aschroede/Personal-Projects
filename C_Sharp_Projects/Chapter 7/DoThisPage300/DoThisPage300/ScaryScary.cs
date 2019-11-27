using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThisPage300
{
    abstract class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;

        public ScaryScary(int numberOfScaryThings, string funnyThingIhave) : base(funnyThingIhave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIhave
        {
            get
            {
                return "I have" + numberOfScaryThings + " spiders";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("You can't have my "+ funnyThingIHave);

        }
    }
}
