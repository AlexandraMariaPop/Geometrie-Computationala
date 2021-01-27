using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            int[] b = new int[4];
            int[] c = new int[4];
            Console.WriteLine("INTRODUCETI COORDONATELE PRIMULUI VECTOR: a");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"a{i}=");

                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL DOILEA VECTOR: b");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"b{i}=");
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL TREILEA VECTOR: c");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"c{i}=");
                c[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"a={a[1]}i+{a[2]}j+{a[3]}k");
            Console.WriteLine($"b={b[1]}i+{b[2]}j+{b[3]}k");
            Console.WriteLine($"c={c[1]}i+{c[2]}j+{c[3]}k");
            //Produsul mixt 
            int det = a[1] * b[2] * c[3] + b[1] * c[2] * a[3] + a[2] * b[3] * c[1] - a[3] * b[2] * c[1] - a[2] * b[1] * c[3] - b[3] * c[2] * a[1];
            if(det<0)
                Console.WriteLine($"Volumul: (a,b,c)={-det}");
            else
                Console.WriteLine($"Volumul: (a,b,c)={det}");
            Console.ReadKey();
        }
    }
}
