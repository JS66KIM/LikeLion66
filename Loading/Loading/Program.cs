using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] status = new float[10];
            string[] stat_name = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}번 스탯 이름 입력: ");
                stat_name[i] = Console.ReadLine();
                Console.Write($"{stat_name[i]}의 스탯 입력: ");
                status[i] = float.Parse(Console.ReadLine());
                
            }

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{stat_name[i]}: {status[i]}%");
            }

        }
    }
}
