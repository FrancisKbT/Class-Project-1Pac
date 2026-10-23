using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio40
    {
// 40. Frecuencia de elementos - Generar 20 números aleatorios (1-10). Mostrar la frecuencia de
// cada número y cuál es el más y menos frecuente.
// Logica: Genera 20 numeros con Random, cuenta apariciones en un arreglo de 11 posiciones y evalua extremos.
        public void FrecuenciaNumeros()
        {
            Console.WriteLine("Frecuencia de 20 numeros aleatorios (1 al 10)");
            Random aleatorio = new Random();
            int[] numeros = new int[20];
            int[] conteos = new int[11]; // Del indice 1 al 10

            Console.WriteLine("Numeros generados:");
            for (int i = 0; i < 20; i++)
            {
                numeros[i] = aleatorio.Next(1, 11);
                Console.Write($"{numeros[i]} ");
                conteos[numeros[i]]++;
            }
            Console.WriteLine();

            Console.WriteLine("Frecuencia de cada numero:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Numero {i}: {conteos[i]} veces");
            }

            int masfrecuente = 1;
            int menosfrecuente = 1;

            for (int i = 2; i <= 10; i++)
            {
                if (conteos[i] > conteos[masfrecuente])
                {
                    masfrecuente = i;
                }
                if (conteos[i] < conteos[menosfrecuente])
                {
                    menosfrecuente = i;
                }
            }

            Console.WriteLine($"El numero mas frecuente fue: {masfrecuente} (con {conteos[masfrecuente]} apariciones)");
            Console.WriteLine($"El numero menos frecuente fue: {menosfrecuente} (con {conteos[menosfrecuente]} apariciones)");
        }
    }
}