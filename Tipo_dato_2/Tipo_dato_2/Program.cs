using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_dato_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variables 
            int num1,num2,opcion;
            double  resultado=0;

            // aqui pedimos los datos para hacer las ecuaciones 
            Console.Write("Ingresa el primer numero para la ecuacion: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingresa el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // aqui obtenemos los parametros para la ejecucion de la sentencia switch
            Console.Write("Ingresa 1 para la suma,2 para la resta , 3 para la multiplicacion, 4 para la division: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            //inicializacion de la sentencia switch
            switch (opcion)
            {
                case 1:  resultado = num1 + num2;
                    break;

                case 2: resultado = num1 - num2;
                    break;

                case 3:resultado = num1 * num2;
                    break;

                case 4:resultado = num1 / num2;
                    break;
            }
            // mostramos el mensajes del resultado de las ecuaciones 
            Console.Write(" este es el resultado de la funcion escojida: {0} ",resultado);
            
        }
    }
}
