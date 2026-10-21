using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio08
    {
// Desglose de billetes - Dado un monto en lempiras, mostrar la menor cantidad de billetes (500,
// 100, 50, 20, 10, 5, 2, 1) necesarios.

//solo pedire la cantidad de lempiras, lo validare para que no sea negativo y anido los calculos con divisiones y modulos.
        public void Desgloce()
        {
            Console.WriteLine("Desgloce monetario en billetes");
            Console.WriteLine("Ingrese la cantidad de lempiras a desglosar (sin centavos):");
            int Lempiras = int.TryParse(Console.ReadLine(), out int nro) ? nro :0;
            if (Lempiras <= 0)
            {
                Console.WriteLine("La cantidad que ingreso no es valida");
            }
            else
            {
                int billete500= Lempiras/500;
                int sobrante= Lempiras%500;
                int billete100= sobrante/100;
                sobrante= sobrante%100;
                int billete50= sobrante/50;
                sobrante= sobrante%50;
                int billete20= sobrante/20;
                sobrante= sobrante%20;
                int billete10 = sobrante/10;
                sobrante= sobrante%10;
                int billete5 = sobrante/5;
                sobrante= sobrante%5;
                int billete2 = sobrante/2;
                sobrante = sobrante%2;
                int billete1 = sobrante;
                Console.WriteLine($"Para completar los {Lempiras} Lps se necesitan {billete500} billetes de 500, {billete100} billetes de 100, {billete50} billetes de 50");
                Console.WriteLine($"{billete20} billetes de 20, {billete10} billetes de 10, {billete5} billetes de 5, {billete2} billetes de 2 y {billete1} billetes de un lempira.");
            }

        }


    }
}