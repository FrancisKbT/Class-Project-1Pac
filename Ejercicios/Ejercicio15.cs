using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
//  15. Vocal o consonante - Solicitar una letra y determinar si es vocal o consonante usando switch.
// Validar que el carácter ingresado sea realmente una letra.
//para este ejercicio investigue y encontre el uso de IsLetter y ToLower, sin esas 2 "funciones" me habrian salido mas de 
//42 cases
    public class Ejercicio15
    {
        public void ConsonanteVocal()
{
            Console.WriteLine("Consonante o vocal");
            Console.WriteLine("Ingrese una letra:");
            string entrada = Console.ReadLine() ?? "";

            if (!char.TryParse(entrada, out char letra) || !char.IsLetter(letra))
            {
                Console.WriteLine("Error: Debe ingresar una única letra válida.");
                return;
            }

         switch (char.ToLower(letra))
            {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"La letra '{letra}' es una vocal.");
                break;
            default:
                Console.WriteLine($"La letra '{letra}' es una consonante.");
                break;
    }
}
}
}