using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio20
    {
// Año bisiesto y días del mes - Solicitar año y mes, determinar si es bisiesto y mostrar cuántos
// días tiene ese mes.
        public void DeterminaAnio(){
            bool aniob= false;
            Console.WriteLine("Determinacion de anio biciesto y dias del mes");
            Console.WriteLine("Introduzca el anio:");
            int year = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            Console.WriteLine("Introduzca el mes del 1 al 12:");
            int mes = int.TryParse(Console.ReadLine(), out int nromes) ? nromes:0;
            if(year<=0 || mes>12 || mes < 1)
            {
                Console.WriteLine("Uno de los datos introducidos es invalido");
            }
            else
            {
                if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"El anio {year} introdujo es biciesto");
                    aniob = true;
                }
                else
                {
                    Console.WriteLine($"El anio {year} no es biciesto");
                }

                if (mes == 2)
                {
                   if(aniob == true) 
                   {
                        Console.WriteLine("Febrero tiene 29 Dias");
                   }
                    else
                    {
                        Console.WriteLine("Febrero tiene 28 Dias");
                    }

                }
                else if(mes==4 || mes==6 || mes==9 || mes == 11)
                {
                    Console.WriteLine($"El mes numero {mes} tiene 30 dias");
                }
                else
                {
                    Console.WriteLine($"El mes {mes} tiene 31 dias");
                }
            }  

            



        }
    }
}