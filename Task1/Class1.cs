using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Building
    {
        string adress;
        public string Adress 
        {
            get
            {
                return adress;
            }
            set
            {
                this.Adress = value;
            }
            
        }
        double length;
        double width;
        double height;

        public double Length 
        {
            get
            {
                return length;
            } 
            set
            {
                if (Length > 0)
                    length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (Width > 0)
                    width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (Height > 0)
                    height = value;
            }
        }
        public Building (string adress, double length, double width, double height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public virtual void Print()
        {
                       Console.WriteLine($"Здание, размерами {length}x{width}x{height} расположено по адресу {adress}");
        }

    }
   
}
