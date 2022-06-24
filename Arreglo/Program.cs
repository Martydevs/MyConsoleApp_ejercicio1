using System;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar variables
            int num1 = 10, num2 = 20, num3 = 0;

            //Pedir al usuario que ingrese su nombre
            Console.WriteLine("Ingresa tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es:", nombre);

            //Hacer la suma y imprimirlo
            num3 = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}",
                num1, num2, num3);

            Console.ReadKey();
        }
    }
}
