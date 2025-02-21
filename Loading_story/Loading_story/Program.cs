using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading_story
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("직업을 선택하세요.(번호입력)");
            Console.WriteLine("1. 농부");
            Console.WriteLine("2. 마약밀매상");
            Console.WriteLine("3. 광부");

            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            string job = "";

            switch (num)
            {
                case 1:
                    Console.WriteLine("농부를 선택하셨습니다.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    job = "농부";
                    break;
                case 2:
                    Console.WriteLine("마약밀매상을 선택하셨습니다.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    job = "마약밀매상";
                    break;
                    
                case 3:
                    Console.WriteLine("광부를 선택하셨습니다.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    job = "광부";
                    break;
            }

            if (job == "농부")
            {
                Console.WriteLine("농장으로 이동중");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("농장으로 이동중.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("농장으로 이동중..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("농장으로 이동중...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("농장 이동 중 아사하였습니다.");
            }
            else if (job == "마약밀매상")
            {
                Console.WriteLine("마약밀매중");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("마약밀매중.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("마약밀매중..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("마약밀매중...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("경찰에게 붙잡혔습니다.");
            }

            else if (job == "광부")
            {
                Console.WriteLine("광질 중");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("광질 중.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("광질 중..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("광질 중...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("허리를 다쳐 일을 못하게되었습니다.");
            }



        }
    }
}
