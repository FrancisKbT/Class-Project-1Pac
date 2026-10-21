using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio09
    {
// Cálculo de salario semanal - Ingresar horas trabajadas y tarifa por hora. Las horas extras (más
// de 44) se pagan al 150%. Mostrar desglose y total.
// Usare un condicional para el requisito de horas extra, esto deberia ser en la otra seccion pero no encuentro otra forma directa.

    public void SalarioSemanal()
        {
            int HorasExtra=0;
            Console.WriteLine("Calculo de pago de salario");
            Console.WriteLine("Ingrese sus horas trabajadas esta semana");
            int horas = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            Console.WriteLine("Ingrese su pago por hora");
            decimal pago = decimal.TryParse(Console.ReadLine(), out decimal nr) ? nr:0;

            if(horas<0 || pago < 0m)
            {
                Console.WriteLine("Los datos que ingreso son invalidos");
            }
            else
            {
                if (horas > 44)
                {
                    HorasExtra = horas-44; //no usare un else, en caso de que esto no se cumpla solo procedera al calculo
                    horas=44;
                }

                Console.WriteLine($"Se le pagara un total de {(horas*pago)} En horas comunes y {(HorasExtra*(pago+(pago/2m)))} por horas extra ");
                Console.WriteLine($"con un total de  {(horas*pago)+(HorasExtra*(pago+(pago/2m)))} ");

            }
        }
    }
}