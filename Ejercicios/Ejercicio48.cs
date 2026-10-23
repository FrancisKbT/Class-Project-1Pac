using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio48
    {
// 48. Fusión de listas - Leer dos listas de números enteros. Implementar: unión sin duplicados,
// intersección (elementos en ambas) y diferencia (elementos en lista A pero no en B).
// Logica: Solicita dos listas y genera colecciones secundarias evaluando la pertenencia mediante Contains.
        public void FusionListas()
        {
            Console.WriteLine("Operaciones entre conjuntos de listas (A y B)");

            Console.WriteLine("Cuantos elementos tendra la Lista A?");
            int tamanoa = int.TryParse(Console.ReadLine() ?? "", out int ca) ? ca : 0;
            List<int> listaa = new List<int>();

            for (int i = 0; i < tamanoa; i++)
            {
                Console.WriteLine($"Lista A - Dato {i + 1}:");
                listaa.Add(int.TryParse(Console.ReadLine() ?? "", out int da) ? da : 0);
            }

            Console.WriteLine("Cuantos elementos tendra la Lista B?");
            int tamanob = int.TryParse(Console.ReadLine() ?? "", out int cb) ? cb : 0;
            List<int> listab = new List<int>();

            for (int i = 0; i < tamanob; i++)
            {
                Console.WriteLine($"Lista B - Dato {i + 1}:");
                listab.Add(int.TryParse(Console.ReadLine() ?? "", out int db) ? db : 0);
            }

            // Union sin duplicados
            List<int> union = new List<int>();
            for (int i = 0; i < listaa.Count; i++)
            {
                if (!union.Contains(listaa[i]))
                {
                    union.Add(listaa[i]);
                }
            }
            for (int i = 0; i < listab.Count; i++)
            {
                if (!union.Contains(listab[i]))
                {
                    union.Add(listab[i]);
                }
            }

            // Interseccion (elementos en ambas)
            List<int> interseccion = new List<int>();
            for (int i = 0; i < listaa.Count; i++)
            {
                if (listab.Contains(listaa[i]) && !interseccion.Contains(listaa[i]))
                {
                    interseccion.Add(listaa[i]);
                }
            }

            // Diferencia (elementos en A que no estan en B)
            List<int> diferencia = new List<int>();
            for (int i = 0; i < listaa.Count; i++)
            {
                if (!listab.Contains(listaa[i]) && !diferencia.Contains(listaa[i]))
                {
                    diferencia.Add(listaa[i]);
                }
            }

            Console.WriteLine("Resultados de las operaciones:");

            Console.Write("Union: ");
            foreach (int item in union)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write("Interseccion: ");
            foreach (int item in interseccion)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write("Diferencia (A - B): ");
            foreach (int item in diferencia)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}