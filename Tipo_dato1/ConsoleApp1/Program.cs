using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato = 20;
            float valor = 30.5F;
            double numero = 58.80;
            string cadena = "el inicio de todo es siempre la parte mas dificil";
            bool valorN = true;

            Console.WriteLine("INT: {0}", dato);
            Console.WriteLine("FLOAT: {0}", valor);
            Console.WriteLine("DOUBLE: {0}", numero);
            Console.WriteLine("STRING: {0}", cadena);
            Console.WriteLine("BOOL: {0}", valorN);

        }
    }
}
