using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio26
    {
// 26. Potencia con ciclo - Calcular la base elevada al exponente usando un ciclo (sin Math.Pow).
// Considerar exponente 0 y exponentes negativos (resultado con decimales).
// Logica: Multiplica la base N veces en un for y divide 1 entre el resultado si el exponente es negativo.
        public void Potencia()
        {
            Console.WriteLine("Calculo de potencia");
            Console.WriteLine("Introduzca la base:");
            double baseNum = double.TryParse(Console.ReadLine(), out double nrobase) ? nrobase : 0;

            Console.WriteLine("Introduzca el exponente:");
            int exponente = int.TryParse(Console.ReadLine(), out int nroexp) ? nroexp : 0;

            double resultado = 1;
            int expPositivo = exponente;

            if (exponente < 0)
            {
                expPositivo = exponente * -1;
            }

            for (int i = 1; i <= expPositivo; i++)
            {
                resultado *= baseNum;
            }

            if (exponente < 0)
            {
                if (baseNum == 0)
                {
                    Console.WriteLine("No es posible dividir entre cero");
                }
                else
                {
                    double resultadodecimal = 1.0 / resultado;
                    Console.WriteLine($"El resultado de {baseNum} elevado a {exponente} es: {resultadodecimal}");
                }
            }
            else
            {
                Console.WriteLine($"El resultado de {baseNum} elevado a {exponente} es: {resultado}");
            }
        }
    }
}