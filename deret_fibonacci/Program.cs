using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deret_fibonacci
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] deret = new int[3] { 0, 1, 0 };
            for (int i=0; i<10; i++)
            {
                deret[0] = deret[1];
                deret[1] = deret[2];
                deret[2] = deret[0]+deret[1];
                Console.Write(deret[2] + ",");

            }

            Console.ReadKey();
        }
    }
}
