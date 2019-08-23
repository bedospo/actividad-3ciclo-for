using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Los Ciclos FOR");
            Console.WriteLine("Coloca el numero que prefieras");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Coloca el numero que prefieras");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De cuanto en cuanto quieres que valla:  ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i = " + i);
                }

            }
            else
            {
                for (int i = x; i < y; i += z)
                {
                    Console.WriteLine("i = " + i);
                }


            }

        }
    }
}
