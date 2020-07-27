using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> nombre = new List<char>() { 'K', 'a', 'r', 'i', 'n', 'a', '1' };

            foreach (char caracter in nombre)
            {
                switch (caracter)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("VOCAL: " + caracter);
                        break;
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        Console.WriteLine("Los nombres de personas no pueden tener numeros!");
                        break;
                    default:
                        Console.WriteLine("CONSONANTE: " + caracter);
                        break;
                }
            }
        }
    }
}
