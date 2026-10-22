using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio22
    {
// Cajero automático - Simular retiro: verificar que el monto sea múltiplo de 20, no exceda el
// saldo (inicializado en código) y mostrar desglose de billetes entregados.
        public void Cajero()
        {
            int Dinero = 20000;
            Console.WriteLine("Cajero automatico");
            Console.WriteLine("ingrese la cantidad que desea retirar:");
            int Retiro = int.TryParse(Console.ReadLine(), out int nro) ? nro : 0;

            if (Retiro < 1 || Retiro > Dinero)
            {
                Console.WriteLine("Monto invalido o no hay suficiente dinero");
            }
            else
            {
                if (Retiro % 20 == 0)
                {
                    Console.WriteLine("Retiro exitoso.");
                    Console.WriteLine("Desglose de billetes entregados:");

                    int sobrante = Retiro;

                    int b500 = sobrante / 500;
                    sobrante = sobrante % 500;

                    int b100 = sobrante / 100;
                    sobrante = sobrante % 100;

                    int b20 = sobrante / 20;

                    if (b500 > 0)
                    {
                        Console.WriteLine($"Billetes de 500: {b500}");
                    }
                    if (b100 > 0)
                    {
                        Console.WriteLine($"Billetes de 100: {b100}");
                    }
                    if (b20 > 0)
                    {
                        Console.WriteLine($"Billetes de 20: {b20}");
                    }
                }
                else
                {
                    Console.WriteLine("No es posible realizar el retiro en billetes de 20");
                }
            }
        }
    }
}