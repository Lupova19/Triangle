using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи данни за триъгълник едно:");
            Triangle tr1 = new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Triangle tr2 = new Triangle(5, 4, 2);
            Triangle tr3 = new Triangle(8, 7, 3);
            Triangle tr4 = new Triangle(9, 6, 4);

             Console.WriteLine($"Триъгълник 1: S={tr1.Area():f2}, P={tr1.Perimeter()}");
             Console.WriteLine($"Триъгълник 2: S={tr2.Area():f2}, P={tr2.Perimeter()}");
             Console.WriteLine($"Триъгълник 3: S={tr3.Area():f2}, P={tr3.Perimeter()}");
             Console.WriteLine($"Триъгълник 4: S={tr4.Area():f2}, P={tr4.Perimeter()}");
        }
    }
}
