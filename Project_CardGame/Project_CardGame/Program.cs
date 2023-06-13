using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int START_MONEY = 10000;                        // 초기 자금

            int[] CardNumbers = new int[4 * 13];
            string[] CardUpgrade = new string[4 * 13];
            string[] CardPatterns = new string[4 * 13];
            string space = " ";

            ConsoleKeyInfo Keys;                            // Keys 입력값 받기

            Random random = new Random();                   // random변수에 랜덤 넣기

            for (int i = 0; i < 4; i++)                             // CardNumbers[] 숫자형 1 ~ 4*13 넣기 (대소 비교를 위해)
            {                                                       // CardPatterns[] 문자형 ♠ ◆ ♥ ♣ 넣기
                for (int j = 0; j < 13; j++)                        // CardUpgrade[] 문자형 1 ~ 4*13 넣기 or 영어 치환
                {
                    if (i == 0)
                    {
                        CardNumbers[(i * 13) + j] = j + 1;
                        CardPatterns[(i * 13) + j] = " ♠";

                        if (CardNumbers[(i * 13) + j] == 1)
                        {
                            CardUpgrade[(i * 13) + j] = " A";
                        }

                        else if (CardNumbers[(i * 13) + j] == 10)
                        {
                            CardUpgrade[(i * 13) + j] = "10";
                        }

                        else if (CardNumbers[(i * 13) + j] == 11)
                        {
                            CardUpgrade[(i * 13) + j] = " J";
                        }

                        else if (CardNumbers[(i * 13) + j] == 12)
                        {
                            CardUpgrade[(i * 13) + j] = " Q";
                        }

                        else if (CardNumbers[(i * 13) + j] == 13)
                        {
                            CardUpgrade[(i * 13) + j] = " K";
                        }

                        else
                        {
                            CardUpgrade[(i * 13) + j] = space + Convert.ToString(CardNumbers[(i * 13) + j]);    //CardUpgrade[] 숫자형 - > 문자형 숫자만 기입
                        }
                    }

                    else if (i == 1)
                    {
                        CardNumbers[(i * 13) + j] = j + 1;
                        CardPatterns[(i * 13) + j] = " ◆";

                        if (CardNumbers[(i * 13) + j] == 1)
                        {
                            CardUpgrade[(i * 13) + j] = " A";
                        }

                        else if (CardNumbers[(i * 13) + j] == 10)
                        {
                            CardUpgrade[(i * 13) + j] = "10";
                        }

                        else if (CardNumbers[(i * 13) + j] == 11)
                        {
                            CardUpgrade[(i * 13) + j] = " J";
                        }

                        else if (CardNumbers[(i * 13) + j] == 12)
                        {
                            CardUpgrade[(i * 13) + j] = " Q";
                        }

                        else if (CardNumbers[(i * 13) + j] == 13)
                        {
                            CardUpgrade[(i * 13) + j] = " K";
                        }

                        else
                        {
                            CardUpgrade[(i * 13) + j] = space + Convert.ToString(CardNumbers[(i * 13) + j]);
                        }
                    }

                    else if (i == 2)
                    {
                        CardNumbers[(i * 13) + j] = j + 1;
                        CardPatterns[(i * 13) + j] = " ♥";

                        if (CardNumbers[(i * 13) + j] == 1)
                        {
                            CardUpgrade[(i * 13) + j] = " A";
                        }

                        else if (CardNumbers[(i * 13) + j] == 10)
                        {
                            CardUpgrade[(i * 13) + j] = "10";
                        }

                        else if (CardNumbers[(i * 13) + j] == 11)
                        {
                            CardUpgrade[(i * 13) + j] = " J";
                        }

                        else if (CardNumbers[(i * 13) + j] == 12)
                        {
                            CardUpgrade[(i * 13) + j] = " Q";
                        }

                        else if (CardNumbers[(i * 13) + j] == 13)
                        {
                            CardUpgrade[(i * 13) + j] = " K";
                        }

                        else
                        {
                            CardUpgrade[(i * 13) + j] = space + Convert.ToString(CardNumbers[(i * 13) + j]);
                        }
                    }

                    else if (i == 3)
                    {
                        CardNumbers[(i * 13) + j] = j + 1;
                        CardPatterns[(i * 13) + j] = " ♣";

                        if (CardNumbers[(i * 13) + j] == 1)
                        {
                            CardUpgrade[(i * 13) + j] = " A";
                        }

                        else if (CardNumbers[(i * 13) + j] == 10)
                        {
                            CardUpgrade[(i * 13) + j] = "10";
                        }

                        else if (CardNumbers[(i * 13) + j] == 11)
                        {
                            CardUpgrade[(i * 13) + j] = " J";
                        }

                        else if (CardNumbers[(i * 13) + j] == 12)
                        {
                            CardUpgrade[(i * 13) + j] = " Q";
                        }

                        else if (CardNumbers[(i * 13) + j] == 13)
                        {
                            CardUpgrade[(i * 13) + j] = " K";
                        }

                        else
                        {
                            CardUpgrade[(i * 13) + j] = space + Convert.ToString(CardNumbers[(i * 13) + j]);
                        }
                    }
                }
            }

            Console.WriteLine("─────────────────────────────");
            Console.WriteLine("                             ");
            Console.WriteLine("┌───────────────────────────┐");
            Console.WriteLine("│                           │");
            Console.WriteLine("│  ♠                        │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│         S t a r t         │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│          E x i t          │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                           │");
            Console.WriteLine("│                        ♠  │");
            Console.WriteLine("│                           │");
            Console.WriteLine("└───────────────────────────┘");
            Console.WriteLine("                             ");

            Keys = Console.ReadKey(true);                                           // Keys에 입력값 받기
            Console.Clear();

            if ('s' == Keys.KeyChar || Keys.KeyChar == 'S')                         // 's', 'S' 키 입력시 게임 시작
            {
                Console.WriteLine("─────────────────────────────");
                Console.WriteLine("                             ");
                Console.WriteLine("┌───────────────────────────┐");
                Console.WriteLine("│                           │");
                Console.WriteLine("│  ♠                        │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│      →  S t a r t  ←      │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│          E x i t          │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                        ♠  │");
                Console.WriteLine("│                           │");
                Console.WriteLine("└───────────────────────────┘");
                Console.WriteLine(" Game Start Loading          ");

                Thread.Sleep(1000);
                Console.Clear();

                while (true)
                {
                    int value1 = random.Next(0, 4 * 13);
                    int value2 = random.Next(0, 4 * 13);
                    int value3 = random.Next(0, 4 * 13);

                    if (value1 == value2 && (value1 == value3 && value2 == value3))
                    {
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine(" My Money $ : {0}", START_MONEY);
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│  ┌─────────┐ ┌─────────┐  │");
                        Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardUpgrade[value1], CardUpgrade[value2]);
                        Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardPatterns[value1], CardPatterns[value2]);
                        Console.WriteLine("│  │         │ │         │  │");
                        Console.WriteLine("│  │         │ │         │  │");
                        Console.WriteLine("│  │         │ │         │  │");
                        Console.WriteLine("│  │      {0} │ │      {1} │  │", CardPatterns[value1], CardPatterns[value2]);
                        Console.WriteLine("│  │      {0} │ │      {1} │  │", CardUpgrade[value1], CardUpgrade[value2]);
                        Console.WriteLine("│  └─────────┘ └─────────┘  │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.Write(" Betting $ : ");

                        int bet = 0;
                        bet = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (bet <= 0)
                        {
                            START_MONEY -= 500;

                            continue;
                        }
                        else if (bet > START_MONEY)
                        {
                            START_MONEY -= 500;

                            continue;
                        }
                        else if (bet > 0)
                        {
                            if (CardNumbers[value1] < CardNumbers[value3] && CardNumbers[value3] < CardNumbers[value2])
                            {
                                START_MONEY += bet;

                                Console.WriteLine("─────────────────────────────");
                                Console.WriteLine(" My Money $ : {0}", START_MONEY);
                                Console.WriteLine("┌───────────────────────────┐");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│  ┌─────────┐ ┌─────────┐  │");
                                Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardUpgrade[value1], CardUpgrade[value2]);
                                Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardPatterns[value1], CardPatterns[value2]);
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │      {0} │ │      {1} │  │", CardPatterns[value1], CardPatterns[value2]);
                                Console.WriteLine("│  │      {0} │ │      {1} │  │", CardUpgrade[value1], CardUpgrade[value2]);
                                Console.WriteLine("│  └─────────┘ └─────────┘  │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│        ┌─────────┐        │");
                                Console.WriteLine("│        │ {0}      │        │", CardUpgrade[value3]);
                                Console.WriteLine("│        │ {0}      │        │", CardPatterns[value3]);
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │      {0} │        │", CardPatterns[value3]);
                                Console.WriteLine("│        │      {0} │        │", CardUpgrade[value3]);
                                Console.WriteLine("│        └─────────┘        │");
                                Console.WriteLine("└───────────────────────────┘");
                                Console.WriteLine(" You Win!!!!!");

                                Console.ReadKey(true);
                                Console.Clear();
                            }

                            else if (CardNumbers[value2] < CardNumbers[value3] && CardNumbers[value3] < CardNumbers[value1])
                            {
                                START_MONEY += bet;

                                Console.WriteLine("─────────────────────────────");
                                Console.WriteLine(" My Money $ : {0}", START_MONEY);
                                Console.WriteLine("┌───────────────────────────┐");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│  ┌─────────┐ ┌─────────┐  │");
                                Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardUpgrade[value1], CardUpgrade[value2]);
                                Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardPatterns[value1], CardPatterns[value2]);
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │      {0} │ │      {1} │  │", CardPatterns[value1], CardPatterns[value2]);
                                Console.WriteLine("│  │      {0} │ │      {1} │  │", CardUpgrade[value1], CardUpgrade[value2]);
                                Console.WriteLine("│  └─────────┘ └─────────┘  │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│        ┌─────────┐        │");
                                Console.WriteLine("│        │ {0}      │        │", CardUpgrade[value3]);
                                Console.WriteLine("│        │ {0}      │        │", CardPatterns[value3]);
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │      {0} │        │", CardPatterns[value3]);
                                Console.WriteLine("│        │      {0} │        │", CardUpgrade[value3]);
                                Console.WriteLine("│        └─────────┘        │");
                                Console.WriteLine("└───────────────────────────┘");
                                Console.WriteLine(" You Win!!!!!");

                                Console.ReadKey(true);
                                Console.Clear();
                            }

                            else
                            {
                                START_MONEY -= bet;

                                Console.WriteLine("─────────────────────────────");
                                Console.WriteLine(" My Money $ : {0}", START_MONEY);
                                Console.WriteLine("┌───────────────────────────┐");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│  ┌─────────┐ ┌─────────┐  │");
                                Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardUpgrade[value1], CardUpgrade[value2]);
                                Console.WriteLine("│  │ {0}      │ │ {1}      │  │", CardPatterns[value1], CardPatterns[value2]);
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │         │ │         │  │");
                                Console.WriteLine("│  │      {0} │ │      {1} │  │", CardPatterns[value1], CardPatterns[value2]);
                                Console.WriteLine("│  │      {0} │ │      {1} │  │", CardUpgrade[value1], CardUpgrade[value2]);
                                Console.WriteLine("│  └─────────┘ └─────────┘  │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│                           │");
                                Console.WriteLine("│        ┌─────────┐        │");
                                Console.WriteLine("│        │ {0}      │        │", CardUpgrade[value3]);
                                Console.WriteLine("│        │ {0}      │        │", CardPatterns[value3]);
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │         │        │");
                                Console.WriteLine("│        │      {0} │        │", CardPatterns[value3]);
                                Console.WriteLine("│        │      {0} │        │", CardUpgrade[value3]);
                                Console.WriteLine("│        └─────────┘        │");
                                Console.WriteLine("└───────────────────────────┘");
                                Console.WriteLine(" You Lose T-T");

                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }
                    }
                    if (START_MONEY >= 20000)
                    {                                                            //승리조건 100,000
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();

                            Console.WriteLine("─────────────────────────────");
                            Console.WriteLine("   You Win       You Win     ");
                            Console.WriteLine("┌───────────────────────────┐");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│                           │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│      ■    '   '    ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│      ■             ■      │");
                            Console.WriteLine("│       ■           ■       │");
                            Console.WriteLine("│         ■■■■■■■■■         │");
                            Console.WriteLine("└───────────────────────────┘");
                            Console.WriteLine("   You Win       You Win     ");

                            Thread.Sleep(100);
                            Console.Clear();
                        }

                        break;
                    }

                    else if (START_MONEY <= 0)
                    {
                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("│      ■    '   '    ■      │");
                        Console.WriteLine("│      ■             ■      │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│         ■■■■■■■■■         │");
                        Console.WriteLine("│       ■           ■       │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        Console.WriteLine("─────────────────────────────");
                        Console.WriteLine("   You Lose      You Lose    ");
                        Console.WriteLine("┌───────────────────────────┐");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("│                           │");
                        Console.WriteLine("└───────────────────────────┘");
                        Console.WriteLine("   You Lose      You Lose    ");

                        Thread.Sleep(100);
                        Console.Clear();

                        break;
                    }
                }
            }

            else if ('e' == Keys.KeyChar || Keys.KeyChar == 'E')
            {
                Console.WriteLine("─────────────────────────────");
                Console.WriteLine("                             ");
                Console.WriteLine("┌───────────────────────────┐");
                Console.WriteLine("│                           │");
                Console.WriteLine("│  ♠                        │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│         S t a r t         │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│      →   E x i t   ←      │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                           │");
                Console.WriteLine("│                        ♠  │");
                Console.WriteLine("│                           │");
                Console.WriteLine("└───────────────────────────┘");
                Console.WriteLine(" Game Exit Loading           ");
                Console.WriteLine("─────────────────────────────");

                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}