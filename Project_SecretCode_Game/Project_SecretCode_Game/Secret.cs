using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace Project_SecretCode_Game
{
    public class Secret
    {
        Random random = new Random();

        char secretCode;
        int[] secretNumber = new int[26];

        public void Play()
        {
            char value = (char)random.Next(65, 90);
            int count = 0;

            while (true)
            {
                Console.Write("대문자 A ~ Z를 입력해주세요 : ");

                char keysNumber = Convert.ToChar(Console.ReadLine());

                if (count < 10)
                {
                    if (value < keysNumber)
                    {
                        Console.WriteLine("보다 작은 값입니다.");
                    }
                    else if (value > keysNumber)
                    {
                        Console.WriteLine("보다 큰 값입니다.");
                    }
                    else if (value == keysNumber)
                    {
                        Console.WriteLine("정답입나다.");
                    }
                    else if (count == 0)
                    {
                        Console.WriteLine("패배 하셨습니다.");
                    }
                }
            }

        }
    }
}
