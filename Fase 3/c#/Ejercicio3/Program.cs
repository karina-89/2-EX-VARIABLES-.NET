using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> nombre = new List<char>() { 'K', 'a', 'r', 'i', 'n', 'a' };
            Dictionary<char, int> letras = new Dictionary<char, int>();

            foreach (char caracter in nombre)
            {
                if (letras.ContainsKey(caracter))
                    letras[caracter] += 1;
                else
                    letras.Add(caracter, 1);
            }

            foreach (var item in letras)
            {
                Console.WriteLine($"La letra {item.Key} aparece {item.Value} vez/veces.");
            }
        }
    }
}
