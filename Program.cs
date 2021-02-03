using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerCorte
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, a = "0", b = "0", c = "0";
            volver:
            Console.WriteLine("Ingrese un valor de 3 digitos");
            n = Console.ReadLine();

            if (n.Length == 3)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    if (i == 0) { a = n.Substring(i, 1); }
                    if (i == 1) { b = n.Substring(i, 1); }
                    if (i == 2) { c = n.Substring(i, 1); }
                }
                Console.Clear();
                Console.WriteLine("A = " + a + "\nB = " + b + "\nC = " + c);
                Console.WriteLine("AACB = " + a + a + b + c + "\nBCA = " + b + c + a + "\nBCBC = " + b + c + b + c);
                Console.WriteLine("Presiene '1' para volver a usar");
                n = Console.ReadLine();
                if(n == "1") { Console.Clear(); goto volver; }
            }
            else
            {
                Console.WriteLine("El valor debe tener solo 3 digitos");
                goto volver;
            }
        }
    }
}
