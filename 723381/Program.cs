using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _723381_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        public static void MethodA()
        {
            while (Peanut())
            {

                Console.WriteLine(" i is {0}", i);
                if (i > 10)
                {
                    return;
                }

            }
        }

        public static bool Peanut()
        {
            i++;
            return true;
        }
    }
}