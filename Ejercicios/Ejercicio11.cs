using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio11
    {
// Positivo, negativo o cero - Solicitar un número entero e indicar si es positivo, negativo o cero.
// Además, usando el operador ternario, mostrar si el número es par o impar.
//este ejercicio lo desarrollo de forma directa, usando if, else if, else y el operador ternario para verificar la pariedad
        public void Evaluacion()
        {
            Console.WriteLine("Positivo, negativo o 0");
            Console.WriteLine("Ingrese el numero entero que desea evaluar");
            int numero= int.TryParse(Console.ReadLine(), out int nro) ? nro:0;

            if (numero > 0)
            {
                Console.WriteLine($"el numero {numero} es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"el numero {numero} es negativo");
            }
            else 
            {
                Console.WriteLine($"el numero {numero} es 0");
            }
            string par =(numero%2 == 0) ? "par" : "impar"; 
            Console.WriteLine($"el numero {numero} es {par}");

        }
    } 
}