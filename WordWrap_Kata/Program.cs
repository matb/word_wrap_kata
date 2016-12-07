using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrap_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://www.personal.uni-jena.de/~dps/advent.html
            string[] lines = WordWrap.CreateLines("Es blaut die Nacht,die Sternlein blinken,Schneeflöcklein leis hernieder sinken.".Split(' '),14);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();

        }
    }
}
