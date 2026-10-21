using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio06
    {
        public void SumaDigitos()
//         Suma de dígitos - Dado un número entero positivo de tres dígitos, calcular la suma de sus
// dígitos usando únicamente división entera y módulo (sin ciclos ni conversión a texto).
// para este ejercicio usare modulo y aritmetica tal como dice la instruccion, evaluare que el numero introducido si sea de 3 digitos
// con un if
        {
            Console.WriteLine("Suma de numero de 3 digitos");
            Console.WriteLine("Introduzca un numero de 3 digitos (ej:348)");
            int numero= int.TryParse(Console.ReadLine(), out int nro) ? nro: 0;
            if(numero>=100 && numero <= 999)
            {
                int centenas = numero / 100;
                int decenas = (numero / 10) % 10;
                int unidades = numero % 10;
            
                Console.WriteLine($"La suma de los digitos es {centenas+decenas+unidades}");
            }
            else Console.WriteLine("El numero que introdujo no es de 3 digitos o es negativo");
        }
    }
}