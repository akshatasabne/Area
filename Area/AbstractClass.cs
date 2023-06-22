using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public abstract class Abclass
    {
        public abstract void CalculateArea();
       
    }
    public class Rectangle:Abclass
    {
        public int length, breadth;
        public int Area;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            Area = length * breadth;
        }
        public override string ToString()
        {
            return $"Area of Reactangle = {Area}";
        }
    }
}
