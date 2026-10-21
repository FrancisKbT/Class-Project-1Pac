using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio18
    {
// Tarifa de estacionamiento - Calcular el pago según las horas estacionado: la primera hora
// cuesta L20, cada hora adicional L10, con un tope máximo de L100 por día. Validar que las horas
// sean positivas.

        public void Tarifa()
        {
            Console.WriteLine("Calculo de tarifa de estacionamiento");
            Console.WriteLine("Introduzca la cantidad de horas:");
            int horas = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            if (horas <=0)
            {
                Console.WriteLine("la cantidad de horas que introdujo es invalida");
            }
            else if (horas > 9)
            {
                Console.WriteLine($"Introdujo {horas}, el limite diario de cobro es de 100 Lps");
            }
            else
            {
                Console.WriteLine($"Introdujo {horas} horas, se le cobraran {((horas-1)*(10))+20} Lempiras");
            }
        }
    }
}