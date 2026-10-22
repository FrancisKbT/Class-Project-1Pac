using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio37
    {
// 37. Registro de números - Leer N números enteros en un arreglo. Recorrerlo con for y con foreach
// para calcular la suma, el promedio, el valor mayor y el menor.
// Logica: Llena el arreglo con un for y luego calcula extremos y suma recorriendo con foreach.
        public void RegistroNumeros()
        {
            Console.WriteLine("Registro de numeros en arreglo");
            Console.WriteLine("Cuantos numeros desea ingresar?");
            int cantidad = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero");
            }
            else
            {
                int[] numeros = new int[cantidad];

                // Llenado usando for
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Introduzca el numero para la posicion {i + 1}:");
                    numeros[i] = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
                }

                int suma = 0;
                int mayor = numeros[0];
                int menor = numeros[0];

                // Recorrido usando foreach para calculos
                foreach (int elemento in numeros)
                {
                    suma += elemento;

                    if (elemento > mayor)
                    {
                        mayor = elemento;
                    }
                    if (elemento < menor)
                    {
                        menor = elemento;
                    }
                }

                double promedio = (double)suma / cantidad;

                Console.WriteLine("Resultados del arreglo:");
                Console.WriteLine($"Suma total: {suma}");
                Console.WriteLine($"Promedio: {promedio}");
                Console.WriteLine($"Valor mayor: {mayor}");
                Console.WriteLine($"Valor menor: {menor}");
            }
        }
    }
}