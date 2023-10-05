using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO7_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Ingrese el valor de n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double suma = 0;

                for (int i = 1; i <= n; i++)
                {
                    double termino = (16 - i) / (3.0 * i);
                    suma += termino;
                    Console.WriteLine($"resultado: {suma} para i={i}");
                }

                Console.WriteLine($"La suma de la secuencia para n={n} es: {suma}");
            
        }
    }
}
