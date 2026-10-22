using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject1.Ejercicios
{
    public class Ejercicio34
    {
// 34. Validación de contraseña - Solicitar contraseña hasta que cumpla: mínimo 8 caracteres, al
// menos una mayúscula, una minúscula, un número y un carácter especial. Indicar qué falta en cada intento.
// Logica: Evalua la cadena con un while verificando longitudes y recorriendo caracteres para activar banderas.
        public void ValidarClave()
        {
            Console.WriteLine("Validacion de contrasena");
            Console.WriteLine("Requisitos: minimo 8 caracteres, una mayuscula, una minuscula, un numero y un caracter especial");

            bool valida = false;
            
            while (valida == false)
            {
                Console.WriteLine("Introduzca la contrasena a evaluar:");
                string clave = Console.ReadLine() ?? "";

                if (string.IsNullOrEmpty(clave))
                {
                    clave = "";
                }

                bool tienemayus = false;
                bool tieneminus = false;
                bool tienenum = false;
                bool tieneespecial = false;

                for (int i = 0; i < clave.Length; i++)
                {
                    char c = clave[i];

                    if (c >= 'A' && c <= 'Z')
                    {
                        tienemayus = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        tieneminus = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        tienenum = true;
                    }
                    else
                    {
                        tieneespecial = true;
                    }
                }

                bool tamano = clave.Length >= 8;

                if (tamano && tienemayus && tieneminus && tienenum && tieneespecial)
                {
                    Console.WriteLine("Contrasena segura y valida");
                    valida = true;
                }
                else
                {
                    Console.WriteLine("La contrasena no es valida, le falta:");
                    if (!tamano)
                    {
                        Console.WriteLine("- Minimo 8 caracteres");
                    }
                    if (!tienemayus)
                    {
                        Console.WriteLine("- Al menos una letra mayuscula");
                    }
                    if (!tieneminus)
                    {
                        Console.WriteLine("- Al menos una letra minuscula");
                    }
                    if (!tienenum)
                    {
                        Console.WriteLine("- Al menos un numero");
                    }
                    if (!tieneespecial)
                    {
                        Console.WriteLine("- Al menos un caracter especial");
                    }
                }
            }
        }
    }
}