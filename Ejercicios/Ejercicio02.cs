using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio02
    {
        //Calculadora de IMC - Solicitar peso (kg) y altura (m), calcular el índice de masa corporal y mostrar en qué categoría se encuentra (bajo peso, normal, sobrepeso, obesidad).

       public void Calculadora()
        {
            Console.WriteLine("Calculadora de Indice de Masa Corporal");
            Console.WriteLine("Ingrese su peso en Kilos");
            decimal Peso = decimal.TryParse(Console.ReadLine(), out decimal p) ? p : 0;
            Console.WriteLine("Ingrese su altura en metros");
            decimal Altura = decimal.TryParse(Console.ReadLine(), out decimal a) ? a : 0;
            //aqui voy a proceder a calcular el indice, luego con estructuras de control mostrar la categoria
            decimal IMC = Peso/(Altura*Altura);
            if(IMC > 0 && IMC < 18.5m)
            {
                Console.WriteLine($"Su Imc es de {(double)IMC}, entra en la categoria de bajo peso");
            }
            else if(IMC >= 18.5m && IMC <= 14.99m)
            {
                Console.WriteLine($"Su Imc es de {(double)IMC}, entra en la categoria de Peso Normal");
            }
           else if(IMC >= 25 && IMC <= 29.99m)
            {
                Console.WriteLine($"Su Imc es de {(double)IMC}, entra en la categoria de Sobre Peso");
            }     
           else if(IMC >= 30 && IMC <= 34.99m)
            {
                Console.WriteLine($"Su Imc es de {(double)IMC}, entra en la categoria de Obesidad Grado 1");
            }         
           else if(IMC >= 35 && IMC <= 39.99m)
            {
                Console.WriteLine($"Su Imc es de {(double)IMC}, entra en la categoria de Obesidad Grado 2");
            }      
           else if(IMC > 40)
            {
                Console.WriteLine($"Su Imc es de {(double)IMC}, entra en la categoria de Obesidad Grado 3");
            }
            else
            {
                Console.WriteLine("Datos Invalidos");
            }
        }
    }
}