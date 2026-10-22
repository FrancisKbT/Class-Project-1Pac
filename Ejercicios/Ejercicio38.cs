using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio38
    {
// 38. Arreglo de nombres - Almacenar 5 nombres en un arreglo de strings. Mostrar los nombres en
// orden inverso, encontrar el nombre más largo y buscar un nombre ingresado por el usuario.
// Logica: Guarda strings en arreglo fijo de 5 posiciones, recorre hacia atras y compara longitudes y coincidencias.
        public void ArregloNombres()
        {
            Console.WriteLine("Gestion de arreglo de 5 nombres");
            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduzca el nombre {i + 1}:");
                string texto = Console.ReadLine() ?? "";
                nombres[i] = string.IsNullOrEmpty(texto) ? "Sin nombre" : texto;
            }

            // Mostrar en orden inverso
            Console.WriteLine("Nombres en orden inverso:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine($"- {nombres[i]}");
            }

            // Encontrar el nombre mas largo
            string nombrelargo = nombres[0];
            for (int i = 1; i < 5; i++)
            {
                if (nombres[i].Length > nombrelargo.Length)
                {
                    nombrelargo = nombres[i];
                }
            }
            Console.WriteLine($"El nombre mas largo es: {nombrelargo}");

            // Busqueda de un nombre
            Console.WriteLine("Introduzca un nombre para buscar en la lista:");
            string buscar = Console.ReadLine() ?? "";
            bool encontrado = false;
            int posicion = -1;

            for (int i = 0; i < 5; i++)
            {
                if (nombres[i].ToLower() == buscar.ToLower())
                {
                    encontrado = true;
                    posicion = i + 1;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"El nombre '{buscar}' si existe, en la posicion {posicion}");
            }
            else
            {
                Console.WriteLine($"El nombre '{buscar}' no se encontro en el arreglo");
            }
        }
    }
}