using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodoUsados
{
    class Program
    {
        static void Main(string[] args)
        {
            //HolaMundo();
            Console.WriteLine(Media(8.0, 4.0));
            Saludar("Juan", 21);
            Saludar("Erick", 22);
            Saludar("Jhosen", 23);
            Console.ReadKey();
        }
        //static void HolaMundo()
        //{
        //    Console.WriteLine("Hola Mundo");
        //    Console.ReadKey();
        //}
        static void Saludar(string nombre, int edad)
        {
            Console.WriteLine("Hola " + nombre + " y tienes " + edad+ " años ");

        }
        static double Media(double num1, double num2)
        {
            double resultado = (num1 + num2) / 2;
            return resultado;
        }
       

    }
}

