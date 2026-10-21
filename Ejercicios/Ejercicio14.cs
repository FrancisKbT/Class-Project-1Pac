using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio14
    {
//  Calculadora con switch - Mostrar un menú con las operaciones +, -, *, / y %. Validar la división y
// el módulo entre cero mostrando un mensaje de error. 
//aun no usare un ciclo de repeticion para este ejercicio, solo usare el switch y validaciones con if para el 0 en la division y el modulo
        public void Calculadora()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Seleccione una operacion con su numero:");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulo");
            int operacion = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            Console.WriteLine("Ingrese los 2 numeros para la operacion:");
            int Num1 = int.TryParse(Console.ReadLine(), out nro) ? nro:0;
            int Num2 = int.TryParse(Console.ReadLine(), out nro) ? nro:0;

            switch (operacion)
            {
                case 1: 
                Console.WriteLine($"El resulado de la suma de {Num1} y {Num2} es {Num1+Num2}");
                break;
                case 2: 
                Console.WriteLine($"El resulado de la resta de {Num1} y {Num2} es {Num1-Num2}");
                break;
                case 3: 
                Console.WriteLine($"El resulado de la multiplicacion de {Num1} y {Num2} es {Num1*Num2}");
                break;
                case 4:
                    if (Num2 == 0)
                    {
                        Console.WriteLine("no es posible dividir entre 0");
                    }
                    else
                    {
                        Console.WriteLine($"El resulado de la division de {Num1} y {Num2} es {(decimal)Num1/Num2}");
                         
                    }
                break;
                case 5:
                    if (Num2 == 0)
                    {
                        Console.WriteLine("no es posible dividir entre 0");
                    }
                    else
                    {
                        Console.WriteLine($"El resulado del residuo entre {Num1} y {Num2} es {(decimal)Num1%Num2}");
                         
                    }
                break;
                
                default:
                Console.WriteLine("La opcion que escribio no es valida");
                break;
                
            }
        }
    }
}