using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Num2: ");
            int num2 = int.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine("La suma  de {0} + {1} = {2} ", num1, num2, respuesta);

            //Pausa.
            Console.ReadLine();


        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num1: ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Num2: ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            int suma = num1 + num2;

            Console.WriteLine("La suma de  {0} + {1} = {2}", num1, num2, suma);

            //Pausa
            Console.ReadLine();

        }
    }
}
