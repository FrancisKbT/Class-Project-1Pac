using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio42
    {
// 42. Búsqueda y ordenamiento - Llenar arreglo de 10 enteros. Implementar: búsqueda lineal,
// encontrar el segundo mayor, ordenar de forma ascendente (burbuja) y mostrar elementos en posiciones pares.
// Logica: Llena 10 enteros, realiza busqueda lineal, ordena con metodo burbuja e identifica el segundo mayor y posiciones pares.
        public void BusquedaOrdenamiento()
        {
            Console.WriteLine("Arreglo de 10 enteros: busqueda y ordenamiento");
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Introduzca el numero para la posicion {i + 1}:");
                numeros[i] = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
            }

            // Busqueda lineal
            Console.WriteLine("Introduzca un numero a buscar:");
            int buscado = int.TryParse(Console.ReadLine(), out int nrobuscado) ? nrobuscado : 0;
            bool hallado = false;
            int posicionhallada = -1;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] == buscado)
                {
                    hallado = true;
                    posicionhallada = i + 1;
                    break;
                }
            }

            if (hallado)
            {
                Console.WriteLine($"El numero {buscado} fue encontrado en la posicion {posicionhallada}");
            }
            else
            {
                Console.WriteLine($"El numero {buscado} no se encuentra en el arreglo");
            }

            // Mostrar elementos en posiciones pares (indices 0, 2, 4, 6, 8 que corresponden a 2, 4, 6, 8, 10 en posicion fisica)
            Console.WriteLine("Elementos en posiciones pares del arreglo original:");
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine($"Posicion {i + 1}: {numeros[i]}");
            }

            // Ordenamiento por burbuja ascendente
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temporal = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temporal;
                    }
                }
            }

            Console.WriteLine("Arreglo ordenado ascendentemente:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
            Console.WriteLine();

            // Encontrar el segundo mayor (buscando desde el final hacia atras el primer elemento distinto al mayor)
            int mayor = numeros[9];
            int segundomayor = numeros[9];
            bool existesegundo = false;

            for (int i = 8; i >= 0; i--)
            {
                if (numeros[i] < mayor)
                {
                    segundomayor = numeros[i];
                    existesegundo = true;
                    break;
                }
            }

            if (existesegundo)
            {
                Console.WriteLine($"El segundo elemento mayor es: {segundomayor}");
            }
            else
            {
                Console.WriteLine("No existe un segundo mayor porque todos los numeros son iguales");
            }
        }
    }
}