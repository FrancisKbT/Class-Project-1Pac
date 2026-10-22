using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio29
    {
// 29. Serie Fibonacci - Generar los primeros N términos de Fibonacci. Mostrar también la suma total
// y el promedio.
// Logica: Suma los dos valores previos en un ciclo for calculando suma total y promedio.
        public void Fibonacci()
        {
            Console.WriteLine("Serie Fibonacci");
            Console.WriteLine("Introduzca la cantidad de terminos a mostrar:");
            int cantidad = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            if (cantidad <= 0)
            {
                Console.WriteLine("El numero que introdujo no es valido");
            }
            else
            {
                long valor1 = 0;
                long valor2 = 1;
                long sumatotal = 0;

                Console.WriteLine($"Primeros {cantidad} terminos de Fibonacci:");

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write($"{valor1} ");
                    sumatotal += valor1;

                    long siguiente = valor1 + valor2; //uso long por los limites de memoria
                    valor1 = valor2;
                    valor2 = siguiente;
                }

                Console.WriteLine();
                Console.WriteLine($"Suma total de la serie: {sumatotal}");
                Console.WriteLine($"Promedio de la serie: {(double)sumatotal / cantidad}");
            }
        }
    }
}