using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio12
    {
// Mayor de tres números - Solicitar tres números diferentes y determinar el mayor usando
// operadores lógicos (&&). Mostrar también el menor de los tres.
//para simplificar un poco el ejercicio podria usarse un ciclo de repeticion, en este caso solo voy a usar condicionales.
        public void MayorDeTres()
        {
            Console.WriteLine("Mayor y menor de tres numeros enteros");
            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.TryParse(Console.ReadLine(), out int nro)? nro :0;
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.TryParse(Console.ReadLine(), out nro)? nro :0;
            Console.WriteLine("Ingrese el tercer numero");
            int num3 = int.TryParse(Console.ReadLine(), out nro)? nro :0;
            if(num1!=num2 && num2!=num3 && num3 != num1)
            {
                if(num1>num2 && num1 > num3)
            {
                Console.WriteLine($"El numero mayor es {num1}");

            }
            else if(num2>num1 && num2 > num3)
            {
                Console.WriteLine($"El numero mayor es {num2}");

            }
            else
            {
                Console.WriteLine($"El numero mayor es {num3}");
                
            }
            if(num1<num2 && num1 < num3)
            {
                Console.WriteLine($"El numero menor es {num1}");

            }
            else if(num2<num1 && num2 < num3)
            {
                Console.WriteLine($"El numero menor es {num2}");

            }
            else
            {
                Console.WriteLine($"El numero menor es {num3}");
                
            }
            }
            else
            {
                Console.WriteLine("Error, los numeros no pueden ser iguales");
            }
            
        }
    }
}