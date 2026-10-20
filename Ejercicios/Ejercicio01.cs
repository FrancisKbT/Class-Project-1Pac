using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio01
    {
        //Conversor de moneda - Solicitar un monto en lempiras y la tasa de cambD}")io del día. Convertir elmonto a dólares y a euros, mostrando los resultados con dos decimales.
        //El ejercicio esta en el apartado de variables y operadores, entonces no considero un ciclo for para la repeticion del programa

        public void Conversor()
        {
            Console.WriteLine("Calculadora de Divisas");
            Console.WriteLine("Introduzca la cantidad de Lempiras");
            int Lempiras= int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;

            Console.WriteLine("Introduzca el valor del dolar");
            int Dollar= int.TryParse(Console.ReadLine(), out nro) ? nro: 0;
            Console.WriteLine("Introduzca el valor del dolar");
            int Euro= int.TryParse(Console.ReadLine(), out nro) ? nro: 0;

            Console.WriteLine($"{Lempiras}, son ${Lempiras*Euro} Euros");
            Console.WriteLine($"{Lempiras}, son ${Lempiras*Dollar} Dolares");
        }
    }
}