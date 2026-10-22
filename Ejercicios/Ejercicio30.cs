using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio30
    {
// 30. Factorial y combinaciones - Calcular el factorial de N y luego calcular C(n,r) = n! / (r!(n-r)!) para
// valores ingresados.
// Calcula factoriales con ciclos for y aplica la formula de combinatoria C(n,r).
        public void Combinaciones()
        {
            Console.WriteLine("Calculo de Factorial y Combinaciones");
            Console.WriteLine("Introduzca el valor de n:");
            int n = int.TryParse(Console.ReadLine(), out int nron) ? nron : 0;

            Console.WriteLine("Introduzca el valor de r:");
            int r = int.TryParse(Console.ReadLine(), out int nror) ? nror : 0;

            if (n < 0 || r < 0 || r > n)
            {
                Console.WriteLine("Los datos ingresados no son validos");
            }
            else
            {
                long factn = 1;
                for (int i = 1; i <= n; i++)
                {
                    factn *= i;
                }

                long factr = 1;
                for (int i = 1; i <= r; i++)
                {
                    factr *= i;
                }

                long factresta = 1;
                for (int i = 1; i <= (n - r); i++)
                {
                    factresta *= i;
                }

                long combinacion = factn / (factr * factresta);

                Console.WriteLine($"Factorial de {n} es: {factn}");
                Console.WriteLine($"Factorial de {r} es: {factr}");
                Console.WriteLine($"Combinacion C({n},{r}) es: {combinacion}");
            }
        }
    }
}