using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio05
    {
// Conversión de temperatura - Crear un menú que permita convertir entre Celsius, Fahrenheit y
// Kelvin. El usuario elige la conversión deseada.
// Para este ejercicio hare lo mismo que en el anterior, switch para evaluar el menu y sin ciclo for    
    public void ConversiónTemperatura()
        {
            Console.WriteLine("Conversion de temperatura");
            Console.WriteLine("Seleccione una conversion:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Celsius a Kelvin");
            Console.WriteLine("3. Fahrenheit a Celsius");
            Console.WriteLine("4. Fahrenheit a Kelvin");
            Console.WriteLine("5. Kelvin a Celsius");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            int Opción = int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;

            switch (Opción){
   
                case 1: 
                Console.WriteLine("Introduzca la cantidad de grados Celsius:");
                decimal Celsius = decimal.TryParse(Console.ReadLine(), out decimal no) ? no: 0;
                Console.WriteLine($"{Celsius} grados Celsius son {(Celsius*(9/5))+32m} Grados Fahrenheit");
                break;
                case 2:
                Console.WriteLine("Introduzca la cantidad de grados Celsius:");
                decimal Celsius2 = decimal.TryParse(Console.ReadLine(), out  no) ? no: 0;
                Console.WriteLine($"{Celsius2} grados Celsius son {(Celsius2+273.15m)}");  
                break;
                case 3:
                Console.WriteLine("Introduzca la cantidad de grados Fahrenheit:");
                decimal Fahrenheit = decimal.TryParse(Console.ReadLine(), out  no) ? no: 0;
                Console.WriteLine($"{Fahrenheit} grados Fahrenheit son {(Fahrenheit-32)*(9/5)} grados Celsius");  
                break;       
                case 4:
                Console.WriteLine("Introduzca la cantidad de grados Fahrenheit:");
                decimal Fahrenheit2 = decimal.TryParse(Console.ReadLine(), out  no) ? no: 0;
                Console.WriteLine($"{Fahrenheit2} grados Fahrenheit son {((Fahrenheit2-32)*(9/5))+273.15m} grados Kelvin");  
                break;   
                case 5:
                Console.WriteLine("Introduzca la cantidad de grados Kelvin:");
                decimal Kelvin = decimal.TryParse(Console.ReadLine(), out  no) ? no: 0;
                Console.WriteLine($"{Kelvin} grados Kelvin son {Kelvin-273.15m} grados Celsius");  
                break;   
                case 6:
                Console.WriteLine("Introduzca la cantidad de grados Kelvin:");
                decimal Kelvin2 = decimal.TryParse(Console.ReadLine(), out  no) ? no: 0;
                Console.WriteLine($"{Kelvin2} grados Kelvin son {(Kelvin2-273.15m*(9/5))+32m} grados Celsius");  
                break;    
                      
                      
                 }




        }

    }
}