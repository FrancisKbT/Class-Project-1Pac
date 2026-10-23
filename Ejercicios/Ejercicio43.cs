using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio43
    {
// 43. Rotación de arreglo - Crear arreglo de N elementos. Implementar menú para: rotar K
// posiciones a la izquierda, rotar K posiciones a la derecha, invertir el arreglo.
// Logica: Crea arreglo dinamico de tamano N y aplica desplazamientos modulares o inversiones segun opcion seleccionada.
        public void RotacionArreglo()
        {
            Console.WriteLine("Operaciones y rotacion de arreglo");
            Console.WriteLine("Introduzca la cantidad N de elementos:");
            int n = int.TryParse(Console.ReadLine(), out int tam) ? tam : 0;

            if (n <= 0)
            {
                Console.WriteLine("El tamano debe ser mayor a cero");
            }
            else
            {
                int[] arreglo = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Introduzca el dato {i + 1}:");
                    arreglo[i] = int.TryParse(Console.ReadLine(), out int dato) ? dato : 0;
                }

                Console.WriteLine("Menu de operaciones:");
                Console.WriteLine("1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir el arreglo");
                Console.WriteLine("Seleccione una opcion:");
                int opcion = int.TryParse(Console.ReadLine(), out int opt) ? opt : 0;

                if (opcion == 1 || opcion == 2)
                {
                    Console.WriteLine("Introduzca el numero de posiciones K a rotar:");
                    int k = int.TryParse(Console.ReadLine(), out int rot) ? rot : 0;

                    if (k < 0)
                    {
                        k = k * -1;
                    }
                    k = k % n; // Evita vueltas innecesarias

                    int[] rotado = new int[n];

                    if (opcion == 1)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            int nuevapos = (i - k + n) % n;
                            rotado[nuevapos] = arreglo[i];
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            int nuevapos = (i + k) % n;
                            rotado[nuevapos] = arreglo[i];
                        }
                    }

                    Console.WriteLine("Arreglo rotado:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"{rotado[i]} ");
                    }
                    Console.WriteLine();
                }
                else if (opcion == 3)
                {
                    int[] invertido = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        invertido[i] = arreglo[n - 1 - i];
                    }

                    Console.WriteLine("Arreglo invertido:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"{invertido[i]} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Opcion de menu no valida");
                }
            }
        }
    }
}