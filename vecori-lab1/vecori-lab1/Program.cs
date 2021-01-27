using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vecori_lab1
{
    class Program
    {
        static void Main(string[] args)
            {
            int[] a = new int[4];
            int[] b = new int[4];
            Console.WriteLine("INTRODUCETI COORDONATELE PRIMULUI VECTOR: a");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"a{i}=");
                
                a[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL DOILEA VECTOR: b");
            for (int i = 1; i <= 3; i++)
            {
               Console.WriteLine($"b{i}=");
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"a={a[1]}i+{a[2]}j+{a[3]}k");
            Console.WriteLine($"b={b[1]}i+{b[2]}j+{b[3]}k");
            //Suma vectorilor
            int[] suma = new int[4];
            for (int i = 1; i <= 3; i++)
            {
                suma[i] = a[i] + b[i];
            }
            Console.WriteLine($"SUMA VECTORILOR ESTE: a+b={suma[1]}i+{suma[2]}j+{suma[3]}k");
            //Produs scalar 
            int produs = 1;
            bool ok = true;
            if (((a[1] == 0) && (a[2] == 0) && (a[3] == 0)) || ((b[1] == 0) && (b[2] == 0) && (b[3] == 0)))
            {
                ok = false;
                Console.WriteLine("VECTORII SUNT PERPENDICULARI");
            }
            if(ok==true)
            {
                produs = a[1] * b[1] + a[2] * b[2] + a[3] * b[3];
                Console.WriteLine($"PRODUSUL SCALAR <a,b>={produs}");
            }
            //lungimile vectorilor
           double la = 0;
            double lb = 0;
            la = Math.Sqrt(a[1] * a[1] + a[2] * a[2] + a[3] * a[3]);
            lb = Math.Sqrt(b[1] * b[1] + b[2] * b[2] + b[3] * b[3]);
            Console.WriteLine($"LUNGIMEA LUI a:||a||={la}");
            Console.WriteLine($"LUNGIMEA LUI b: ||b||={lb}");
            //proiectia vectorului a pe b
            double prapeb = (double)produs / lb;
            Console.WriteLine($"Proiectia lui a pe b este:{prapeb}");
            double prbpea = (double)produs / la;
            Console.WriteLine($"Proiectia lui b pe a este:{prbpea}");
            //cos
            double cos = (produs / (la * lb));
            Console.WriteLine($"COSINUSUL UNGHIULUI DINTRE a SI b:cos(a,b)={cos} ");

            Console.ReadKey();

        }
    }
}
