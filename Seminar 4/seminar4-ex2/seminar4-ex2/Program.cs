using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int xa, ya;
            Console.WriteLine("INTRODUCETI COORDONATELE PUNCTULUI: A");
            Console.WriteLine("xa=");
            xa = int.Parse(Console.ReadLine());
            Console.WriteLine("ya=");
            ya = int.Parse(Console.ReadLine());

            Console.WriteLine("INTRODUCETI COORDONATELE DREPTEI D:");
            int a, b, c;
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("COODONATELE PUNCTULUI INTRODUS SUNT: ");
            Console.WriteLine($"A({xa}, {ya})");
            Console.WriteLine("DREAPTA INTRODUSA ESTE:");
            Console.WriteLine($"{a}x + {b}y + {c} = 0");
               // double r1 = a * xa + b * ya + c;
               // Console.WriteLine(r1);
               // double r2 = Math.Sqrt(a * a + b * b);
               // Console.WriteLine(r2);
            double distanta = Math.Abs(((a * xa + b * ya + c) / Math.Sqrt(a * a + b * b)));

            Console.WriteLine("DISTANTA DE LA PUNCTUL A LA DRAPTA D ESTE: "+distanta);
            Console.ReadKey();

        }
    }
}
