using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding : Building
    {
        int storey;
        public int Storey
        {
            get
            {
                return storey;
            }
            set
            {
                if (Storey > 0)
                    this.Storey = storey;
            }

        }

        public MultiBuilding(string adress, double length, double width, double height, int storey)
            : base(adress, length, width, height)
        {
            this.storey = storey;
        }
        public override void Print()
        {
            Console.WriteLine($"Здание, размерами {Length}x{Width}x{Height}, с количеством этажей, равном {Storey}, расположено по адресу {Adress}");
        }

    }
}
