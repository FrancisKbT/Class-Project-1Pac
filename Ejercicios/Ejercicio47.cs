using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio47
    {
// 47. Filtrado y transformación - Llenar una lista con N números enteros. Generar: lista de pares,
// lista de impares, lista con cada elemento elevado al cuadrado y lista sin duplicados.
// Logica: Llena una List<int> y luego itera para poblar nuevas listas aplicando condiciones modulares y unicidad.
        public void FiltradoTransformacion()
        {
            Console.WriteLine("Filtrado y transformacion de colecciones");
            Console.WriteLine("Cuantos numeros enteros desea ingresar a la lista?");
            int n = int.TryParse(Console.ReadLine() ?? "", out int cant) ? cant : 0;

            if (n <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero");
            }
            else
            {
                List<int> original = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduzca el dato {i + 1}:");
                    int val = int.TryParse(Console.ReadLine() ?? "", out int num) ? num : 0;
                    original.Add(val);
                }

                List<int> pares = new List<int>();
                List<int> impares = new List<int>();
                List<int> cuadrados = new List<int>();
                List<int> sinrepetidos = new List<int>();

                for (int i = 0; i < original.Count; i++)
                {
                    int elemento = original[i];

                    // Pares e impares
                    if (elemento % 2 == 0)
                    {
                        pares.Add(elemento);
                    }
                    else
                    {
                        impares.Add(elemento);
                    }

                    // Cuadrados
                    cuadrados.Add(elemento * elemento);

                    // Sin duplicados
                    if (!sinrepetidos.Contains(elemento))
                    {
                        sinrepetidos.Add(elemento);
                    }
                }

                Console.WriteLine("Reporte de listas generadas:");

                Console.Write("Pares: ");
                foreach (int item in pares)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();

                Console.Write("Impares: ");
                foreach (int item in impares)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();

                Console.Write("Cuadrados: ");
                foreach (int item in cuadrados)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();

                Console.Write("Sin duplicados: ");
                foreach (int item in sinrepetidos)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}