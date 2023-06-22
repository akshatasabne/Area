using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle= new Rectangle(15,12);
            rectangle.CalculateArea();
            rectangle.ToString();
           Console.WriteLine(rectangle);
        }

    }
}
