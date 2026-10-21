using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio13
    {
// Día de la semana - Solicitar un número del 1 al 7 y mostrar el nombre del día correspondiente
// usando switch clásico; luego resolverlo de nuevo usando una expresión switch.
// en este ejercicio use switch en el primer metodo y la expresion switch en el segundo.
        public void DiasSemanaSwitch()
        {
            Console.WriteLine("Dias de la semana");
            Console.WriteLine("Ingrese el numero de dia que desea ver");
            int dia= int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            switch (dia){

                case 1: 
                Console.WriteLine("El dia que introdujo es el Lunes");
                break;
                case 2: 
                Console.WriteLine("El dia que introdujo es el Martes");
                break;
                case 3: 
                Console.WriteLine("El dia que introdujo es el Miercoles");
                break;
                case 4: 
                Console.WriteLine("El dia que introdujo es el Jueves");
                break;
                case 5: 
                Console.WriteLine("El dia que introdujo es el Viernes");
                break;
                case 6: 
                Console.WriteLine("El dia que introdujo es el Sabado");
                break;
                case 7: 
                Console.WriteLine("El dia que introdujo es el Domingo");
                break;
                default:
                Console.WriteLine("Introduzca un dia valido");
                break;
            }
        }

        public void DiasSemanaSwitchExp()
        {
            Console.WriteLine("Dias de la semana");
            Console.WriteLine("Ingrese el numero de dia que desea ver");
            int dia= int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
            string Diasemana = dia switch
            {
                1=> "El dia que introdujo es Lunes",
                2=> "El dia que introdujo es Martes",
                3=> "El dia que introdujo es Miercoles",
                4=> "El dia que introdujo es Jueves",
                5=> "El dia que introdujo es Viernes",
                6=> "El dia que introdujo es Sabado",
                7=> "El dia que introdujo es Domingo",
                _=> "Dia invalido"
            };
            Console.WriteLine(Diasemana);
        }
    }
}