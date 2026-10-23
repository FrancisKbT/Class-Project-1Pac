using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio44
    {
// 44. Histograma de calificaciones - Registrar N calificaciones (0-100) en un arreglo, contar cuántas
// caen en cada rango (0-59, 60-69, 70-79, 80-89, 90-100) y dibujar el histograma con barras de asteriscos.
// Logica: Clasifica calificaciones ingresadas en 5 rangos fijos y muestra una barra de asteriscos por cada conteo acumulado.
        public void Histograma()
        {
            Console.WriteLine("Histograma de calificaciones");
            Console.WriteLine("Cuantas notas desea registrar?");
            int n = int.TryParse(Console.ReadLine(), out int cant) ? cant : 0;

            if (n <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero");
            }
            else
            {
                int r0a59 = 0;
                int r60a69 = 0;
                int r70a79 = 0;
                int r80a89 = 0;
                int r90a100 = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduzca la calificacion {i + 1} (0 a 100):");
                    int nota = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;

                    if (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("Nota fuera de rango, se registrara como 0");
                        nota = 0;
                    }

                    if (nota <= 59)
                    {
                        r0a59++;
                    }
                    else if (nota <= 69)
                    {
                        r60a69++;
                    }
                    else if (nota <= 79)
                    {
                        r70a79++;
                    }
                    else if (nota <= 89)
                    {
                        r80a89++;
                    }
                    else
                    {
                        r90a100++;
                    }
                }

                Console.WriteLine("Histograma de resultados:");

                Console.Write("00-59  : ");
                for (int j = 0; j < r0a59; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r0a59})");

                Console.Write("60-69  : ");
                for (int j = 0; j < r60a69; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r60a69})");

                Console.Write("70-79  : ");
                for (int j = 0; j < r70a79; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r70a79})");

                Console.Write("80-89  : ");
                for (int j = 0; j < r80a89; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r80a89})");

                Console.Write("90-100 : ");
                for (int j = 0; j < r90a100; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r90a100})");
            }
        }
    }
}