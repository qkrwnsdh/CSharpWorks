using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Test_23_06_09
{
    internal class Program                  // 클래스 내부의 함수(멤버 변수)를 메서드 라고한다.
    {
        static void Main(string[] args)             //static 메서드만 부를 수 있다.
        {
            Random random = new Random();
            int[] lottos = new int[6];

            for (int i = 0; i < lottos.Length; i++)
            {
                lottos[i] = random.Next(1, 45);
            }

            Task.Delay(1000).Wait();
            Thread.Sleep(1000);

            foreach (int lotto_ in lottos)
            {
                Console.Write("{0}", lotto_);
            }
            Console.WriteLine();

            //Tutorial();

            int[] numbers = new int[5];
            int[,] numbers2 = new int[5, 5];
            int[,,] numbers3 = new int[5, 5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("numbers[{0}] 의 값 : {1} \n", i, numbers[i]);
            //}

            int valueCount = 0;

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    valueCount += 1;
                    numbers2[y, x] = valueCount;
                }
            }

            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        Console.Write("{0}", numbers2[y, x]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int z = 0; z < 5; z++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        for (int x = 0; x < 5; x++)
            //        {
            //            Console.WriteLine("numbers[{0}][{1}][{2}] 의 값 : {3} \n",z, y, x, numbers2[y, x]);
            //        }
            //    }

            //}

            PrintMyArray(numbers2);

            string[,] board = new string[5, 5];
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    board[y, x] = "*";
                
                }
            
            }
        }

        static void PrintMyArray(int[,] array_)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("{0} ", array_[y, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Tutorial()
        {
            Console.WriteLine("Hello world! \n");

            string userInput1 = default;
            string userInput2 = default;
            int number = default;
            float floatNumber = default;

            int userNumber1 = default;
            int userNumber2 = default;

            //여기서 입력을 받는다.
            userInput1 = Console.ReadLine();
            userInput2 = Console.ReadLine();

            // 입력 받은 것을 숫자로 변환한다.
            //userNumber1 = System.Convert.ToInt32(userNumber1);
            //userNumber2 = System.Convert.ToInt32(userNumber2);

            //userNumber1 = int.Parse(userInput1);
            //userNumber2 = int.Parse(userInput2);

            int.TryParse(userInput1, out userNumber1);
            int.TryParse(userInput2, out userNumber2);

            Console.WriteLine("{0}, {1} = {2} \n", userInput1, userInput2, userInput1 + userInput2);
            // Console.WriteLine("입력 받은 내용을 출력하고 싶어 : {1} {0}\n\n", userInput, userInput2);       // {0} 자리 표시자
        }
    }
}
