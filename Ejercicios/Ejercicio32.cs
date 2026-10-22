using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio32
    {
// 32. Números primos en rango - Dado un rango (inicio, fin), mostrar todos los números primos y
// contar cuántos hay.
// Logica: Recorre el rango con un for y cuenta divisores con un segundo for anidado para saber si es primo.
        public void PrimosRango()
        {
            Console.WriteLine("Numeros primos en un rango");
            Console.WriteLine("Introduzca el numero de inicio:");
            int inicio = int.TryParse(Console.ReadLine(), out int nroini) ? nroini : 0;

            Console.WriteLine("Introduzca el numero de fin:");
            int fin = int.TryParse(Console.ReadLine(), out int nrofin) ? nrofin : 0;

            if (inicio > fin || fin < 2)
            {
                Console.WriteLine("Rango no valido, el fin debe ser mayor o igual al inicio y minimo 2");
            }
            else
            {
                int cprimos = 0;
                Console.WriteLine($"Numeros primos entre {inicio} y {fin}:");

                for (int i = inicio; i <= fin; i++)
                {
                    if (i >= 2)
                    {
                        int divisores = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                divisores++;
                            }
                        }

                        if (divisores == 2)
                        {
                            Console.Write($"{i} ");
                            cprimos++;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Total de numeros primos encontrados: {cprimos}");
            }
        }
    }
}