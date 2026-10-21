using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio10
    {
// Calculadora de préstamo simple - Solicitar monto, tasa de interés anual y plazo en meses.
// Calcular el interés total y la cuota mensual fija.
        public void CalculadoraPrestamo()
        {
            Console.WriteLine("Calculadora de prestamo simple");
            Console.WriteLine("Ingrese el monto:");
            decimal monto = decimal.TryParse(Console.ReadLine(), out decimal nro) ? nro:0;
            Console.WriteLine("Ingrese la tasa de interes anual:");
            decimal tasa = decimal.TryParse(Console.ReadLine(), out  nro) ? nro:0;
            Console.WriteLine("Ingrese el plazo (en meses):");
            decimal tiempomeses = decimal.TryParse(Console.ReadLine(), out  nro) ? nro:0;
            if(monto<=0 || tasa<=0 || tiempomeses <= 0)
            {
                Console.WriteLine("uno o mas de los datos que introdujo es invalido");
            }
            else
            {
                decimal tiempoanio = tiempomeses/12m;
                decimal tasaporcentual = tasa/100;
                decimal interes= monto*tiempoanio*tasaporcentual;
                decimal mensualidad= (monto+interes)/tiempomeses;
                Console.WriteLine($"El interes total es de {interes} y la mensualidad es de {mensualidad}");
            }

        }
    }
}