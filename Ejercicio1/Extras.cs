using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Extras
    {
        public static void Menu(String[] opciones) 
        {
            int o = 1;
            Console.Clear();
            Console.WriteLine("Elija un ejercicio:");
            foreach (String op in opciones)
            {
                Console.WriteLine(o + ". " + op);
                o++;
            }
            Console.WriteLine("\n\n0. Retroceder...");
        }
        public static String ElegirOp()
        {
            return Console.ReadLine();
        }
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }
        public static string Mid(string param, int startIndex)
        {
            string result = param.Substring(startIndex); //devuelve una subcadena desde el indice hasta el fin de cadena
            return result;
        }
    }
}
