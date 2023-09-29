using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    internal class Program
    {
        
        static void Main()

        {
            Console.WriteLine("Enter the number to find its factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int f1 = 1; 

            for (int i = 1; i <= num; i++)
            {
                f1 = f1 * i;
            }
            Console.WriteLine("{0}! is {1}", num, f1);

            Console.ReadLine();
        }
    }
}
