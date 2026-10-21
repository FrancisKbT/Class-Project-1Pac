using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio16
    {
        public void NotasUNAH()
        {
// Sistema de calificaciones UNAH - Ingresar nota de 0-100 y mostrar: letra (A, B, C, D, F),
// descripción y si aprobó o reprobó. Incluir validación de rango.
// no veo necesario el uso de switch, solo usare if, else if y else
            Console.WriteLine("Posicionamiento de notas UNAH");
            Console.WriteLine("introduzca su nota:");
            double nota = double.TryParse(Console.ReadLine(), out double nro) ? nro:0;

            if(nota<0 || nota > 100)
            {
                Console.WriteLine("La nota que ingreso no es valida.");
            }
            else if(nota<65)
            {
                Console.WriteLine($"Su nota es {nota} reprobatoria, categoria F");
            }
            else if(nota<75)
            {
                Console.WriteLine($"Su nota es {nota} Aprobatoria, categoria D");
            }
            else if(nota<80)
            {
                Console.WriteLine($"Su nota es {nota} Aprobatoria, categoria C");
            }
            else if(nota<90)
            {
                Console.WriteLine($"Su nota es {nota} Aprobatoria, categoria B");
            }
            else
            {
                Console.WriteLine($"Su nota es {nota} Aprobatoria, categoria A");
            }
        }
    }
}