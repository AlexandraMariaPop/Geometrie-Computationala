using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            int[] b = new int[4];
            int[] c = new int[4];
            Console.WriteLine("INTRODUCETI COORDONATELE PRIMULUI punct: A");
            Console.WriteLine($"xa=");
            a[1] = int.Parse(Console.ReadLine());
            Console.WriteLine($"ya=");
            a[2] = int.Parse(Console.ReadLine());
            Console.WriteLine($"za=");
            a[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL DOILEA PUNCT: B");
            Console.WriteLine($"xb=");
            b[1] = int.Parse(Console.ReadLine());
            Console.WriteLine($"yb=");
            b[2] = int.Parse(Console.ReadLine());
            Console.WriteLine($"zb=");
            b[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUCETI COORDONATELE CELUI DE-AL TREILEA PUNCT: B");
            Console.WriteLine($"xc=");
            c[1] = int.Parse(Console.ReadLine());
            Console.WriteLine($"yc=");
            c[2] = int.Parse(Console.ReadLine());
            Console.WriteLine($"zc=");
            c[3] = int.Parse(Console.ReadLine());
            int[] ab=new int [4];
            int[] ac=new int [4];
            int[]bc=new int [4];
            for (int i = 1; i <=3; i++)
            {
                ab[i] = b[i] - a[i];
                ac[i] = c[i] - a[i];
                bc[i] = c[i] - b[i];

            }
            Console.WriteLine($"A({a[1]}, {a[2]}, {a[3]})");
            Console.WriteLine($"B({b[1]}, {b[2]}, {b[3]})");
            Console.WriteLine($"C({c[1]}, {c[2]}, {c[3]})");
            Console.WriteLine($"AB={ab[1]}i+ {ab[2]}j+ {ab[3]}k");
            Console.WriteLine($"AC={ac[1]}i+ {ac[2]}j+ {ac[3]}k");
            Console.WriteLine($"BC={bc[1]}i+ {bc[2]}j+ {bc[3]}k");
            double lab=0;
            double lac=0;
            double lbc = 0;
            lab = Math.Sqrt(ab[1] * ab[1] + ab[2] * ab[2] + ab[3] * ab[3]);
            lac = Math.Sqrt(ac[1] * ac[1] + ac[2] * ac[2] + ac[3] * ac[3]);
            lbc = Math.Sqrt(bc[1] * bc[1] + bc[2] * bc[2] + bc[3] * bc[3]);
            Console.WriteLine($"LUNGIMEA LUI AB: ||AB||={lab}");
            Console.WriteLine($"LUNGIMEA LUI AC: ||AC||={lac}");
            Console.WriteLine($"LUNGIMEA LUI BC: ||BC||={lbc}");
            //PRodus scalar 
           int produsABAC = ab[1] * ac[1] + ab[2] * ac[2] + ab[3] * ac[3];
            Console.WriteLine($"PRODUSUL SCALAR <AB,AC>={produsABAC}");
            int produsABBC = ab[1] * bc[1] + ab[2] * bc[2] + ab[3] * bc[3];
            Console.WriteLine($"PRODUSUL SCALAR <AB,BC>={produsABBC}");
            int produsACBC = ac[1] * bc[1] + ac[2] * bc[2] + ac[3] * bc[3];
            Console.WriteLine($"PRODUSUL SCALAR <AC,BC>={produsACBC}");
            //COSINUS
            double cos = produsABAC / (lab * lac);
            Console.WriteLine($"COSINUSUL UNGHIULUI DINTRE AB SI AC:cos(AB,AC)={cos} ");
            //ARIA
            int i1 = ab[2] * bc[3] - ab[3] * bc[2];
            int j1 = ab[3] * bc[1] - ab[1] * bc[3];
            int k1=ab[1] * bc[2] - ab[2] * bc[1];
            double aria1 = Math.Sqrt(i1 * i1 + j1 * j1 + k1 * k1);
            Console.WriteLine($"ARIA: A(AB, BC)={aria1}");
            int i2 = ac[2] * bc[3] - ac[3] * bc[2];
            int j2 = ac[3] * bc[1] - ac[1] * bc[3];
            int k2 = ac[1] * bc[2] - ac[2] * bc[1];
            double aria2 = Math.Sqrt(i2 * i2 + j2 * j2 + k2 * k2);
            Console.WriteLine($"ARIA: A(AC, BC)={aria2+lab}");
            //perimetru
            Console.WriteLine($"PERIMETRUL TRIUNGHIULUI ABC: P(ABC)={lab+lac+lbc}");
            //volum
            int det =- ab[1] * ac[2] * bc[3] + ac[1] * bc[2] * ab[3] + ab[2] * ac[3] * bc[1] - ab[3] * ac[2] * bc[1] - ab[2] * ac[1] * bc[3] - ac[3] * bc[2] * ab[1];
            if (det < 0)
                Console.WriteLine($"Volumul: (AB,AC,BC)={-det}");
            else
                Console.WriteLine($"Volumul: (AB,AC,BC)={det}");
            Console.ReadKey() ;
            
        }
    }
}
