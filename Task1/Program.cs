using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding house = new MultiBuilding("г. Иркутск", 20, 15, 12, 3);
            house.Print();
            Console.ReadLine();
        }
    }
}
