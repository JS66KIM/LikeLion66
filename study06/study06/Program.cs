using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study06
{
    class Program
    {
        static void Main(string[] args)
        {
            string bininput = Console.ReadLine();
            int dec = Convert.ToInt32(bininput, 2);

                Console.WriteLine($"Hi bro{dec}");
        }
    }
}
