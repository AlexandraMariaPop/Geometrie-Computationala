using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTRODUCETI COORDONATELE PRIMULUI PUNCT: A");
            Console.WriteLine($"xa=");
            int xa = int.Parse(Console.ReadLine());
            Console.WriteLine($"ya=");
            int ya = int.Parse(Console.ReadLine());

            int xb, yb;
            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL DOILEA PUNCT: B");
            Console.WriteLine("xb=");
            xb = int.Parse(Console.ReadLine());
            Console.WriteLine("yb=");
            yb = int.Parse(Console.ReadLine());

            Console.WriteLine("PUNCTELE INTRODUSE SUNT: ");
            Console.WriteLine($"A({xa}, {ya})");
            Console.WriteLine($"B({xb}, {yb})");

            Console.WriteLine($"ECUATIA DREPTEI DETERMINATA DE PUNCTELE: A({xa}, {ya}) si B({xb}, {yb}) ESTE:");
            int a = ya - yb;
            int b = xb - xa;
            int c = xa * yb - ya * xb;
            if(a==0)
                Console.WriteLine($"{b}y + {c} = 0" );
            else
            
                if(b==0)
                    Console.WriteLine($"{a}x + {c} = 0");
                else
                    if(c==0)
                    Console.WriteLine($"{a}x + {b}y = 0");
                else
                    Console.WriteLine($"{a}x + {b}y + {c} = 0");
            
            Console.ReadKey();
        }
    }
}
