using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_dato_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 16;
            double numero2;
            string numeroString = "123";
            int numeroEntero = Convert.ToInt32(numeroString);  // Convierte la cadena a entero

            double otroDecimal = 45.67;
            int otroEntero = Convert.ToInt32(otroDecimal);  // Convierte el número decimal a entero

            Console.WriteLine(numeroEntero);
            Console.WriteLine(otroEntero);

            numero2 = numero;// conversion de int a double
            Console.WriteLine(numero2);
        }
    }
}
