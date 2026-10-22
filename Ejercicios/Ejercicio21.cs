using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio21
    {
// Validador de fecha - Ingresar día, mes y año por separado. Validar que sea una fecha real
// considerando días por mes y años bisiestos.
        public void ValidarFecha()
        {
            bool biciesto = false;
            Console.WriteLine("Validador de fecha");
            Console.WriteLine("introduzca el anio:");
            int anio = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;

            Console.WriteLine("introduzca el mes:");
            int mes = int.TryParse(Console.ReadLine(), out int nromes) ? nromes:0;

            Console.WriteLine("introduzca el dia:");
            int dia = int.TryParse(Console.ReadLine(), out int nrodia) ? nrodia:0;

            if(anio<1 || mes > 12 || mes<1 || dia<1 || dia > 31)
            {
                Console.WriteLine("Uno de los datos que introdujo es invalido");
            }
            else
            {
                if((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                { 
                    biciesto = true;
                }
            if (mes == 2)
                {
                    if (biciesto == true)
                    {
                        if(dia<1 || dia>29)
                        {
                        Console.WriteLine("El dia no es posible");
                        }
                        else
                        {
                            Console.WriteLine("El dia es posible");
                        }
                    }
                    else if(dia<1 || dia>28)
                    {
                    Console.WriteLine("El dia no es posible");
                    }
                    else Console.WriteLine("El dia es posible");

                }
                else if(mes==4 || mes==6 || mes==9 || mes == 11)
                {
                    if(dia<1 || dia > 30)
                    {
                        Console.WriteLine("El dia no es posible");
                    }
                    else
                    {
                        Console.WriteLine("El dia es posible");
                    }
                }
                else
                {
                    if(dia<1 || dia > 31)
                    {
                        Console.WriteLine("El dia no es posible");
                    }
                    else
                    {
                        Console.WriteLine("El dia es posible");
                    }
                }    
                
            }

        }
    }
}