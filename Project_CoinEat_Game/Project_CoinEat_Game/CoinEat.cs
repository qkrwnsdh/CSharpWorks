using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_CoinEat_Game
{
    public class CoinEat
    {
        int SWAP_COUNT = 1000;              // SWAP 횟수

        char[,] map = new char[15, 15];
        int score = 0;                      // 점수
        int side = 0;                       // 배열 크기 지정
        int coinCount = 0;                  // 방향키 누른 횟수

        int initialValueY;                  // 플레이어 죄표값 : Y
        int initialValueX;                  // 플레이어 좌표값 : X

        Random random = new Random();

        ConsoleKeyInfo key;

        public void Play()
        {
            while (true)
            {
                Console.Write("5 ~ 15 사이의 길이를 적어주세요 : ");
                side = Convert.ToInt32(Console.ReadLine());
                
                if (5 <= side && side <= 15)
                {                                                                       // { 입력 받은 side 값을 이용해 map 배열에 모조리 ' ' 넣기 시작
                    Console.WriteLine("한 변의 길이가 {0}인 문제가 주어집니다.", side);

                    Thread.Sleep(1000);
                    Console.Clear();

                    for (int y = 0; y < side; y++)
                    {
                        for (int x = 0; x < side; x++)
                        {
                            map[y, x] = ' ';
                        }
                    }
                }

                else
                {
                    Console.WriteLine("한 변의 길이가 {0}인 문제가 주어집니다.", side);

                    Thread.Sleep(1000);
                    Console.Clear();
                }                                                                       // } 입력 받은 side 값을 이용해 map 배열에 모조리 ' ' 넣기 끝

                map[side - 1, side - 1] = '▣';                                          // 플레이어 좌표값 임의로 지정 (마지막 배열에 지정)

                int randomValue1;
                int randomValue2;
                int randomValue3;
                int randomValue4;

                for (int i = 0; i < SWAP_COUNT; i++)
                {                                                                       // { 배열 모조리 섞기 시작
                    randomValue1 = random.Next(0, side);
                    randomValue2 = random.Next(0, side);
                    randomValue3 = random.Next(0, side);
                    randomValue4 = random.Next(0, side);

                    char temp = '0';

                    temp = map[randomValue1, randomValue2];
                    map[randomValue1, randomValue2] = map[randomValue3, randomValue4];
                    map[randomValue3, randomValue4] = temp;
                }                                                                       // } 배열 모조리 섞기 끝

                Console.WriteLine("점수 : {0}",score);

                for (int y = 0; y < side; y++)
                {                                                                       // { 초기 화면 출력 시작
                    for (int x = 0; x < side; x++)
                    {
                        Console.Write(" {0} ", map[y, x]);
                    }
                    Console.WriteLine();
                }                                                                       // } 초기 화면 출력 끝

                for (int y = 0; y < side; y++)
                {                                                                       // { 플레이어 좌표값 추출 시작
                    for (int x = 0; x < side; x++)
                    {
                        if (map[y, x] == '▣')
                        {
                            initialValueX = x;
                            initialValueY = y;
                        }
                    }
                }                                                                       // } 플레이어 좌표값 추출 끝

                while (true)
                {
                    if (score == 10)
                    {                                                                   // { 승리 조건 score 10 점 시작
                        Console.WriteLine("승리하셨습니다.");

                        Thread.Sleep(1000);
                        Console.Clear();

                        break;
                    }                                                                   // } 승리 조건 score 10 점 끝

                    if (coinCount == 3)
                    {                                                                   // { 이동 횟수 3회가 되면 새로운 코인 랜덤 생성 + 이동 키 지정 시작
                        while (true)
                        {
                            int coinValue1 = random.Next(1, side);
                            int coinValue2 = random.Next(1, side);

                            if ('ⓒ' != map[coinValue1, coinValue2] && map[coinValue1, coinValue2] != map[initialValueY, initialValueX])
                            {
                                map[coinValue1, coinValue2] = 'ⓒ';

                                coinCount = 0;

                                break;
                            }
                        }

                        key = Console.ReadKey(true);

                        Console.Clear();

                        if ('a' == key.KeyChar || key.KeyChar == 'A')
                        {
                            if (0 < initialValueX)
                            {
                                if (map[initialValueY, initialValueX - 1] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY, initialValueX - 1] = ' ';

                                    if (1 <= initialValueX && initialValueX <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX - 1];
                                        map[initialValueY, initialValueX - 1] = temp;
                                        initialValueX -= 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (1 <= initialValueX && initialValueX <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX - 1];
                                        map[initialValueY, initialValueX - 1] = temp;
                                        initialValueX -= 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (initialValueX == 0)
                            {
                                initialValueX = 0;
                            }
                        }

                        else if ('d' == key.KeyChar || key.KeyChar == 'D')
                        {
                            if (side - 1 > initialValueX)
                            {
                                if (map[initialValueY, initialValueX + 1] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY, initialValueX + 1] = ' ';

                                    if (0 <= initialValueX && initialValueX <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX + 1];
                                        map[initialValueY, initialValueX + 1] = temp;
                                        initialValueX += 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (0 <= initialValueX && initialValueX <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX + 1];
                                        map[initialValueY, initialValueX + 1] = temp;
                                        initialValueX += 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (side - 1 == initialValueX)
                            {
                                initialValueX = side - 1;
                            }
                        }

                        else if ('s' == key.KeyChar || key.KeyChar == 'S')
                        {
                            if (side - 1 > initialValueY)
                            {
                                if (map[initialValueY + 1, initialValueX] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY + 1, initialValueX] = ' ';

                                    if (0 <= initialValueY && initialValueY <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY + 1, initialValueX];
                                        map[initialValueY + 1, initialValueX] = temp;
                                        initialValueY += 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (0 <= initialValueY && initialValueY <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY + 1, initialValueX];
                                        map[initialValueY + 1, initialValueX] = temp;
                                        initialValueY += 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (side - 1 == initialValueY)
                            {
                                initialValueY = side - 1;
                            }
                        }

                        else if ('w' == key.KeyChar || key.KeyChar == 'W')
                        {
                            if (0 < initialValueY)
                            {
                                if (map[initialValueY - 1, initialValueX] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY - 1, initialValueX] = ' ';

                                    if (1 <= initialValueY && initialValueY <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY - 1, initialValueX];
                                        map[initialValueY - 1, initialValueX] = temp;
                                        initialValueY -= 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (1 <= initialValueY && initialValueY <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY - 1, initialValueX];
                                        map[initialValueY - 1, initialValueX] = temp;
                                        initialValueY -= 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (initialValueY == 0)
                            {
                                initialValueY = 0;
                            }
                        }

                        else
                        {
                            continue;
                        }
                    }                                                                   // } 이동 횟수 3회가 되면 새로운 코인 랜덤 생성 + 이동 키 지정 끝

                    else if (coinCount < 3)
                    {                                                                   // { 이동 키 지정 시작
                        key = Console.ReadKey(true);

                        Console.Clear();

                        if ('a' == key.KeyChar || key.KeyChar == 'A')
                        {
                            if (0 < initialValueX)
                            {
                                if (map[initialValueY, initialValueX - 1] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY, initialValueX - 1] = ' ';

                                    if (1 <= initialValueX && initialValueX <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX - 1];
                                        map[initialValueY, initialValueX - 1] = temp;
                                        initialValueX -= 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (1 <= initialValueX && initialValueX <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX - 1];
                                        map[initialValueY, initialValueX - 1] = temp;
                                        initialValueX -= 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (initialValueX == 0)
                            {
                                initialValueX = 0;
                            }
                        }

                        else if ('d' == key.KeyChar || key.KeyChar == 'D')
                        {
                            if (side - 1 > initialValueX)
                            {
                                if (map[initialValueY, initialValueX + 1] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY, initialValueX + 1] = ' ';

                                    if (0 <= initialValueX && initialValueX <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX + 1];
                                        map[initialValueY, initialValueX + 1] = temp;
                                        initialValueX += 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (0 <= initialValueX && initialValueX <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY, initialValueX + 1];
                                        map[initialValueY, initialValueX + 1] = temp;
                                        initialValueX += 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (side - 1 == initialValueX)
                            {
                                initialValueX = side - 1;
                            }
                        }

                        else if ('s' == key.KeyChar || key.KeyChar == 'S')
                        {
                            if (side - 1 > initialValueY)
                            {
                                if (map[initialValueY + 1, initialValueX] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY + 1, initialValueX] = ' ';

                                    if (0 <= initialValueY && initialValueY <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY + 1, initialValueX];
                                        map[initialValueY + 1, initialValueX] = temp;
                                        initialValueY += 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (0 <= initialValueY && initialValueY <= side - 2)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY + 1, initialValueX];
                                        map[initialValueY + 1, initialValueX] = temp;
                                        initialValueY += 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (side - 1 == initialValueY)
                            {
                                initialValueY = side - 1;
                            }
                        }

                        else if ('w' == key.KeyChar || key.KeyChar == 'W')
                        {
                            if (0 < initialValueY)
                            {
                                if (map[initialValueY - 1, initialValueX] == 'ⓒ')
                                {
                                    score += 1;

                                    map[initialValueY - 1, initialValueX] = ' ';

                                    if (1 <= initialValueY && initialValueY <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY - 1, initialValueX];
                                        map[initialValueY - 1, initialValueX] = temp;
                                        initialValueY -= 1;

                                        coinCount += 1;
                                    }
                                }

                                else
                                {
                                    if (1 <= initialValueY && initialValueY <= side - 1)
                                    {
                                        char temp = '0';
                                        temp = map[initialValueY, initialValueX];
                                        map[initialValueY, initialValueX] = map[initialValueY - 1, initialValueX];
                                        map[initialValueY - 1, initialValueX] = temp;
                                        initialValueY -= 1;

                                        coinCount += 1;
                                    }
                                }
                            }

                            else if (initialValueY == 0)
                            {
                                initialValueY = 0;
                            }
                        }
                    }                                                                   // } 이동 키 지정 끝

                    else
                    {
                        continue;
                    }

                    Console.WriteLine("점수 : {0}", score);

                    for (int y = 0; y < side; y++)
                    {                                                                   // { 변화 값 출력 시작
                        for (int x = 0; x < side; x++)
                        {
                            Console.Write(" {0} ", map[y, x]);
                        }
                        Console.WriteLine();
                    }                                                                   // } 변화 값 출력 끝
                }

                break;
            }
        }
    }
}
