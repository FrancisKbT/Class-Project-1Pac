using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio28
    {
// 28. Decimal a binario - Convertir un número entero positivo a binario usando divisiones sucesivas
// entre 2 dentro de un ciclo.
// Logica: Divide sucesivamente entre 2 y guarda los residuos a la izquierda de la cadena.
        public void Binario()
        {
            Console.WriteLine("Conversion a binario");
            Console.WriteLine("Introduzca un numero entero positivo:");
            int numero = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            if (numero < 0)
            {
                Console.WriteLine("El numero que introdujo no es valido");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El numero en binario es: 0");
            }
            else
            {
                string binario = "";
                int numtemporal = numero;

                while (numtemporal > 0)
                {
                    int residuo = numtemporal % 2;
                    binario = residuo + binario;
                    numtemporal = numtemporal / 2;
                }

                Console.WriteLine($"El numero {numero} en binario es: {binario}");
            }
        }
    }
}