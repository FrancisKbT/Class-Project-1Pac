using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio07
    {
        public void DiferenciaHoras()
        {   int totseg1=0;
            int totseg2=0;
            Console.WriteLine("Calculadora de diferencia entre horas");
            Console.WriteLine("Primera hora");
            Console.WriteLine("Ingrese la Hora 1 (solo hora, ej: 8) :");
            int hora= int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;
            if(hora>=0 && hora <= 23)
            {
                hora=hora*3600;
                Console.WriteLine("Ingrese los minutos(ej: 20) :");
                int minutos= int.TryParse(Console.ReadLine(), out nro) ? nro: 0;
                if(minutos>=0 && minutos <= 59)
                {
                    minutos=minutos*60;
                    Console.WriteLine("Ingrese los segundos(ej: 50) :");
                int segundos= int.TryParse(Console.ReadLine(), out nro) ? nro: 0;
                
                if(segundos>=0 && segundos <= 59)
                    {
                         totseg1=hora+minutos+segundos;
                    }

                    else Console.WriteLine("El numero que escribio es invalido");

                }
                else Console.WriteLine("El numero que escribio es invalido");
            }
            else Console.WriteLine("El numero que escribio es invalido");

            Console.WriteLine("segunda hora");
            Console.WriteLine("Ingrese la Hora 2 (solo hora, ej: 8) :");
            int hora2= int.TryParse(Console.ReadLine(), out  nro) ? nro: 0;
            if(hora>=0 && hora <= 23)
            {
                hora2=hora2*3600;
                Console.WriteLine("Ingrese los minutos(ej: 20) :");
                int minutos= int.TryParse(Console.ReadLine(), out nro) ? nro: 0;
                if(minutos>=0 && minutos <= 59)
                {
                    minutos=minutos*60;
                    Console.WriteLine("Ingrese los segundos(ej: 50) :");
                int segundos= int.TryParse(Console.ReadLine(), out nro) ? nro: 0;
                
                if(segundos>=0 && segundos <= 59)
                    {
                         totseg2=hora2+minutos+segundos;
                    }

                    else Console.WriteLine("El numero que escribio es invalido");

                }
                else Console.WriteLine("El numero que escribio es invalido");
            }
            else Console.WriteLine("El numero que escribio es invalido");
            int diferencia = totseg2 - totseg1;
            if (diferencia < 0)
            {
                diferencia += 86400; // Si pasa de la medianoche suma las 24 horas en segundos para no obtener un resultado negativo
            }

            int horasFinales = diferencia / 3600;
            int minutosFinales = (diferencia % 3600) / 60;
            int segundosFinales = diferencia % 60;

            Console.WriteLine($"\nTiempo transcurrido: {horasFinales} horas, {minutosFinales} minutos y {segundosFinales} segundos.");
        }
    }
}
