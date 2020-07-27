using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> nombre = new List<char>() { 'K', 'a', 'r', 'i', 'n', 'a' };
            List<char> apellido = new List<char>() { 'R', 'o', 'd', 'r', 'i', 'g', 'u', 'e', 'z' };
            List<char> fullName = new List<char>();

            fullName.AddRange(nombre);
            fullName.Add(' ');
            fullName.AddRange(apellido);

            string resultado = new string(fullName.ToArray());
            Console.WriteLine(resultado);
        }
    }
}
