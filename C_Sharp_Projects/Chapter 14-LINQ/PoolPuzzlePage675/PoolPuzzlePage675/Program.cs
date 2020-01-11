using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzlePage675
{
    // Horses enjoy eating carrots, but they love eating apples
    class Program
    {
        
        static void Main(string[] args)
        {
            Line[] lines =
            {
                new Line(new string[] {"eating", "carrots","but","enjoy", "Horses"}, 1),
                new Line(new string[] {"zebras?", "hay","Cow","bridge.", "bolted"}, 2),
                //new Line(new string[] {"fork", "dogs!","Engine","and"}, 3),
                new Line(new string[] {"love", "they","apples.","eating"}, 2),
                new Line(new string[] {"whistled", "Bump"}, 1),
            };

            var words =
                from line in lines
                group line by line.Value
                into wordGroups
                orderby wordGroups.Key
                select wordGroups;

            var twoGroups = words.Take(2);

            foreach (var group in twoGroups)
            {
                int i = 0;

                foreach (var inner in group)
                {
                    i++;
                    
                    if(i == group.Key)
                    {
                        var poem =
                            from word in inner.Words
                            orderby word descending
                            select word + " ";
                        foreach (var word in poem)
                        {
                            Console.Write(word);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }

    class Line
    {
        public string[] Words;
        public int Value;
        public Line(string[] Words, int Value)
        {
            this.Words = Words; this.Value = Value;
        }
    }

    
}
