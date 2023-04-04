using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_secuencial1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random number = new Random();
            

           for(int i = 0; i < array.Length; i++)
            {
                array[i] = number.Next(1, 11);
                if(array[i] == array[i])
                {
                    Console.Write(array[i]);
                    Console.Write("\t");

                }
            }

        }
    }
}
