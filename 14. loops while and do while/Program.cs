using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.loops_while_and_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while( index <= 500 )
            {
                
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("this is now do while loop");
            int index2 = 0;
                do
            {
                Console.WriteLine(index2);
                index2++;
            }
            while (index2 <= 5);

            Console.ReadLine();
        }
    }
}
