using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EOP5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            int i = 127;
            Console.WriteLine("Given Number: " + i);
            if(P.Parity(i))
            {
                Console.WriteLine("Even number of 1 in the Bit version of Number");
            }
            else
            {
                Console.WriteLine("Odd number of 1 in the Bit version of Number");
            }
            
        }

        public bool Parity(int number)
        {
            string value = Convert.ToString(number, 2);
            int total = 0;
            Console.WriteLine("Number in Bit Version: " + value);
            for(int i=0;i<value.Length;i++)
            {
                total += Convert.ToInt32(value[i]);

            }

            if(total % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
