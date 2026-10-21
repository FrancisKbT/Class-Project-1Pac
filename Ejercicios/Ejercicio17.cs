using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio17
    {
        public void Descuentos()
        {
// Calculadora de descuentos - Según el monto de compra aplicar descuentos escalonados: 5%
// (L500-999), 10% (L1000-2499), 15% (L2500+). Mostrar precio original, descuento y precio final.
            Console.WriteLine("Calculadora de descuentos");
            Console.WriteLine("inserte el monto de su compra:");
            double Precio = double.TryParse(Console.ReadLine(), out double nro) ? nro:0;
            double Descuento= 0;
            if (Precio <= 0)
            {
                Console.WriteLine("El precio que introdujo es invalido");
            }
            else if (Precio >= 2500)
            {
                Descuento= 0.15;
            }
            else if (Precio >= 1000)
            {
                Descuento=0.10;
            }
            else if (Precio >= 500)
            {
                Descuento=0.05;
            }
            else if(Precio<500)
            {
                Descuento = 0;
            }

            Console.WriteLine($"El monto inicial es de {Precio}, con un descuento de {Precio*Descuento} su total es de {Precio-(Precio*Descuento)}");

        }
    }
}