using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio27
    {
// 27. Inversión de número - Invertir los dígitos de un número entero usando while, división entera y
// módulo. Indicar además si el número es palíndromo (capicúa).
// Logica: Extrae el ultimo digito con modulo 10 y lo une multiplicando por 10 en un while.
        public void Invertir()
        {
            Console.WriteLine("Inversion de numero");
            Console.WriteLine("Introduzca un numero entero:");
            int numero = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            int original = numero;
            int numtemporal = numero;
            int invertido = 0;

            if (numtemporal < 0)
            {
                numtemporal = numtemporal * -1;
            }

            while (numtemporal > 0)
            {
                int digito = numtemporal % 10;
                invertido = (invertido * 10) + digito;
                numtemporal = numtemporal / 10;
            }

            if (numero < 0)
            {
                invertido = invertido * -1;
            }

            Console.WriteLine($"Numero original: {original}");
            Console.WriteLine($"Numero invertido: {invertido}");

            if (original == invertido)
            {
                Console.WriteLine("El numero es palindromo");
            }
            else
            {
                Console.WriteLine("El numero no es palindromo");
            }
        }
    }
}