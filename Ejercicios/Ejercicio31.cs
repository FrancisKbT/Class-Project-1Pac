using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio31
    {
// 31. MCD y MCM - Calcular el máximo común divisor de dos números usando el algoritmo de
// Euclides (while) y, a partir de él, obtener el mínimo común múltiplo.
// Logica: Aplica residuos sucesivos en while hasta que el residuo sea cero y calcula MCM con la formula (a*b)/MCD.
        public void McidyMcim()
        {
            Console.WriteLine("Calculo de MCD y MCM");
            Console.WriteLine("Introduzca el primer numero:");
            int numero1 = int.TryParse(Console.ReadLine(), out int nro1) ? nro1 : 0;

            Console.WriteLine("Introduzca el segundo numero:");
            int numero2 = int.TryParse(Console.ReadLine(), out int nro2) ? nro2 : 0;

            if (numero1 <= 0 || numero2 <= 0)
            {
                Console.WriteLine("Ambos numeros deben ser enteros positivos.");
            }
            else
            {
                int a = numero1;
                int b = numero2;

                while (b != 0)
                {
                    int residuo = a % b;
                    a = b;
                    b = residuo;
                }

                int mcd = a;
                int mcm = (numero1 * numero2) / mcd;

                Console.WriteLine($"El MCD de {numero1} y {numero2} es: {mcd}");
                Console.WriteLine($"El MCM de {numero1} y {numero2} es: {mcm}");
            }
        }
    }
}