using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckProjectPage369
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13},
            };

            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            DuckComparer comparer = new DuckComparer();

            PrintDucks(ducks);
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);



            Console.ReadKey();
        }

        static void PrintDucks(List<Duck> ducks)
        {
            string result = "";

            foreach (Duck ducky in ducks)
            {
                result += ducky.Size + "-inch " + ducky.Kind + "\n";
            }
            MessageBox.Show(result);
        }
    }
}
