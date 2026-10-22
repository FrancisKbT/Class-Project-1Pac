using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio23
    {
        // Tabla de multiplicar extendida - Solicitar un número y mostrar su tabla del 1 al 12 con formato
        // alineado.
        public void Tablas()
        {
            Console.WriteLine("Tabla de multiplicar");
            Console.WriteLine("Introduzca el numero que quiera multiplicar:");
            int numero = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            Console.WriteLine($"\n--- Tabla del {numero} ---");

            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
               
                Console.WriteLine($"{numero, 4} x {i, 2} = {resultado, 4}");
            }
        }
    }
}