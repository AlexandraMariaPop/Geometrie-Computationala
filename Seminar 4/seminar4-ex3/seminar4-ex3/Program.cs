using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4_ex3
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

            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL DOILEA PUNCT: B");
            Console.WriteLine($"xb=");
            int xb = int.Parse(Console.ReadLine());
            Console.WriteLine($"yb=");
            int yb = int.Parse(Console.ReadLine());

            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL TREILEA PUNCT: C");
            Console.WriteLine($"xc=");
            int xc = int.Parse(Console.ReadLine());
            Console.WriteLine($"yc=");
            int yc = int.Parse(Console.ReadLine());

            Console.WriteLine("PUNCTELE INTRODUSE SUNT: ");
            Console.WriteLine($"A({xa}, {ya})");
            Console.WriteLine($"B({xb}, {yb})");
            Console.WriteLine($"C({xc}, {yc})");

            int delta = Math.Abs(xa * yb + xb * yc + ya * xc - xc * yb - yc * xa - xb * ya);
           if(delta!=0)
            Console.WriteLine("ARIA TRIUNGHIULUI DETERMINATA DE CELE 3 PUNCTE ESTE: "+delta/2  );
                else
                Console.WriteLine("ARIA COORDONATELOR CURENTE NU EXISTA");


            Console.ReadKey();
        }

    }
}
