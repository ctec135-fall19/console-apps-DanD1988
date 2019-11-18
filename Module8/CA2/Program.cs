using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the CA2 program");

            string s = Console.ReadLine();
            while (s != null)
            {
                Console.WriteLine(s);
                s = Console.ReadLine();
            }

            /*
            int i = 0;

            while (i < 4)
            {
                Console.WriteLine("CA2:{0}", i);
                i++;
            }
            */


        }
    }
}
