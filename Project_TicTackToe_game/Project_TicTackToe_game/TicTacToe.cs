using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_TicTackToe_game
{
    public class TicTacToe
    {
        Random random = new Random();

        char[] check = new char[9];                                     // 문자 'O', 'X' 넣은 값
        int[] keys = new int[9];                                        // 입력값 집어넣기 1 ~ 9;
        int Count = 0;                                                  // 비기는 조건

        public void Play()
        {
            Console.WriteLine("┌───────────────────────────────────┐");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
            Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
            Console.WriteLine("│     │ │        │ │        │ │     │");
            Console.WriteLine("│     │ │        │ │        │ │     │");
            Console.WriteLine("│     └─┘        └─┘        └─┘     │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│             S T A R T             │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│              E X I T              │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("│                                   │");
            Console.WriteLine("└───────────────────────────────────┘");
            Console.WriteLine("    START : S KEY     EXIT : E KEY   ");

            ConsoleKeyInfo button;

            button = Console.ReadKey(true);                             // 스타트, 종료 버튼 활성화

            Console.Clear();

            if ('s' == button.KeyChar || button.KeyChar == 'S')
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
                    Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     └─┘        └─┘        └─┘     │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│          →  S T A R T  ←          │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│              E X I T              │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" Game Start Loading ..");

                    Thread.Sleep(100);
                    Console.Clear();

                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
                    Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     └─┘        └─┘        └─┘     │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│          →  S T A R T  ←          │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│              E X I T              │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" Game Start Loading ....");

                    Thread.Sleep(100);
                    Console.Clear();

                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
                    Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     └─┘        └─┘        └─┘     │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│          →  S T A R T  ←          │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│              E X I T              │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" Game Start Loading ......");

                    Thread.Sleep(100);
                    Console.Clear();
                }

                for (int i = 0; i < 9; i++)
                {
                    check[i] = ' ';
                }

                Console.WriteLine("┌───────────┬───────────┬───────────┐");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("├───────────┼───────────┼───────────┤");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("├───────────┼───────────┼───────────┤");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("│           │           │           │");
                Console.WriteLine("└───────────┴───────────┴───────────┘");

                Console.Clear();

                for (int i = 0; i < 9; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("┌───────────┬───────────┬───────────┐");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[6], check[7], check[8]);
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("├───────────┼───────────┼───────────┤");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[3], check[4], check[5]);
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("├───────────┼───────────┼───────────┤");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[0], check[1], check[2]);
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("└───────────┴───────────┴───────────┘");

                        Console.Write(" 플레이어 차례입니다 : ");

                        keys[i] = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        check[keys[i] - 1] = 'O';

                        Console.WriteLine("┌───────────┬───────────┬───────────┐");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[6], check[7], check[8]);
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("├───────────┼───────────┼───────────┤");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[3], check[4], check[5]);
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("├───────────┼───────────┼───────────┤");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[0], check[1], check[2]);
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("│           │           │           │");
                        Console.WriteLine("└───────────┴───────────┴───────────┘");

                        Thread.Sleep(1000);
                        Console.Clear();

                        if (check[0] == check[1] && check[1] == check[2])
                        {
                            if (check[1] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[3] == check[4] && check[4] == check[5])
                        {
                            if (check[4] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[6] == check[7] && check[7] == check[8])
                        {
                            if (check[7] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[0] == check[3] && check[3] == check[6])
                        {
                            if (check[3] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[1] == check[4] && check[4] == check[7])
                        {
                            if (check[4] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[2] == check[5] && check[5] == check[8])
                        {
                            if (check[5] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[2] == check[4] && check[4] == check[6])
                        {
                            if (check[4] == 'O')
                            {
                                Win();

                                break;
                            }
                        }

                        else if (check[0] == check[4] && check[4] == check[8])
                        {
                            if (check[4] == 'O')
                            {
                                Win();

                                break;
                            }
                        }
                    }

                    else if (i % 2 == 1)
                    {
                        while (true)
                        {
                            int value = random.Next(1, 9);

                            if (check[value - 1] != 'O' && 'X' != check[value - 1])
                            {
                                check[value - 1] = 'X';

                                Console.WriteLine("┌───────────┬───────────┬───────────┐");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[6], check[7], check[8]);
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("├───────────┼───────────┼───────────┤");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[3], check[4], check[5]);
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("├───────────┼───────────┼───────────┤");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│     {0}     │     {1}     │     {2}     │", check[0], check[1], check[2]);
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("│           │           │           │");
                                Console.WriteLine("└───────────┴───────────┴───────────┘");

                                Thread.Sleep(1000);
                                Console.Clear();

                                break;
                            }
                        }

                        if (check[0] == check[1] && check[1] == check[2])
                        {
                            if (check[1] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[3] == check[4] && check[4] == check[5])
                        {
                            if (check[4] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[6] == check[7] && check[7] == check[8])
                        {
                            if (check[7] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[0] == check[3] && check[3] == check[6])
                        {
                            if (check[3] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[1] == check[4] && check[4] == check[7])
                        {
                            if (check[4] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[2] == check[5] && check[5] == check[8])
                        {
                            if (check[5] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[2] == check[4] && check[4] == check[6])
                        {
                            if (check[4] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }

                        else if (check[0] == check[4] && check[4] == check[8])
                        {
                            if (check[4] == 'X')
                            {
                                Lose();

                                break;
                            }
                        }
                    }
                    Count += 1;
                }

                if (Count == 8)
                {
                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" 비기셨습니다. 게임을 재식작 합니다.      ");

                    Thread.Sleep(1000);
                    Console.Clear();

                    Play();
                }
            }
            else if ('e' == button.KeyChar || button.KeyChar == 'E')
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
                    Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     └─┘        └─┘        └─┘     │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│             S T A R T             │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│          →   E X I T   ←          │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" Game Exit Loading ..");

                    Thread.Sleep(100);
                    Console.Clear();

                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
                    Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     └─┘        └─┘        └─┘     │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│             S T A R T             │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│          →   E X I T   ←          │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" Game Exit Loading ....");

                    Thread.Sleep(100);
                    Console.Clear();

                    Console.WriteLine("┌───────────────────────────────────┐");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│   ┌─────┐    ┌─────┐    ┌─────┐   │");
                    Console.WriteLine("│   └─┐ ┌─┘    └─┐ ┌─┘    └─┐ ┌─┘   │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     │ │        │ │        │ │     │");
                    Console.WriteLine("│     └─┘        └─┘        └─┘     │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│             S T A R T             │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│          →   E X I T   ←          │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("│                                   │");
                    Console.WriteLine("└───────────────────────────────────┘");
                    Console.WriteLine(" Game Exit Loading ......");

                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
        public void Win()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│    ┌─┐┌─┐┌─┐  ┌───┐  ┌──┐  ┌─┐    │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine(" Win    Win    Win    Win    Win     ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│    ┌─┐┌─┐┌─┐  ┌───┐  ┌──┐  ┌─┐    │");
                Console.WriteLine("│    │ ││ ││ │  └┐ ┌┘  │  └┐ │ │    │");
                Console.WriteLine("│    │ ││ ││ │   │ │   │ ┌┐└┐│ │    │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("   Win    Win    Win    Win    Win   ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│    ┌─┐┌─┐┌─┐  ┌───┐  ┌──┐  ┌─┐    │");
                Console.WriteLine("│    │ ││ ││ │  └┐ ┌┘  │  └┐ │ │    │");
                Console.WriteLine("│    │ ││ ││ │   │ │   │ ┌┐└┐│ │    │");
                Console.WriteLine("│    │ ││ ││ │   │ │   │ │└┐└┘ │    │");
                Console.WriteLine("│    │ └┘ └┘ │  ┌┘ └┐  │ │ └┐  │    │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("     Win    Win    Win    Win    Win ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│    ┌─┐┌─┐┌─┐  ┌───┐  ┌──┐  ┌─┐    │");
                Console.WriteLine("│    │ ││ ││ │  └┐ ┌┘  │  └┐ │ │    │");
                Console.WriteLine("│    │ ││ ││ │   │ │   │ ┌┐└┐│ │    │");
                Console.WriteLine("│    │ ││ ││ │   │ │   │ │└┐└┘ │    │");
                Console.WriteLine("│    │ └┘ └┘ │  ┌┘ └┐  │ │ └┐  │    │");
                Console.WriteLine("│    └───────┘  └───┘  └─┘  └──┘    │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("   Win    Win    Win    Win    Win   ");

                Thread.Sleep(100);
                Console.Clear();
            }

        }
        public void Lose()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│%!#$%#^@%$@#%#@#@^#@%$#@^@#%#$@%@#^│");
                Console.WriteLine("│@!#$#$^@^#%$^&^$%@#%$@#^%$#&^@%@##%│");
                Console.WriteLine("│!$#!^@#^%$@&$&%#%#@$!@$$^%@$#%$#^#$│");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine(" Lose   Lose   Lose   Lose   Lose    ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│%!#$%#^@%$@#%#@#@^#@%$#@^@#%#$@%@#^│");
                Console.WriteLine("│@!#$#$^@^#%$^&^$%@#%$@#^%$#&^@%@##%│");
                Console.WriteLine("│!$#!^@#^%$@&$&%#%#@$!@$$^%@$#%$#^#$│");
                Console.WriteLine("│@!#$!@#^@%$&%^&%#@$%#@$^&%^%#$%$^@#│");
                Console.WriteLine("│%$#%&^@#$%$#@%$&#%^$@%^&#$%@%@%#$%$│");
                Console.WriteLine("│!@#^%&@^#$%$#%&#%$@%@#$#^&%#$%#%&%@│");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("  Lose   Lose   Lose   Lose   Lose   ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│%!#$%#^@%$@#%#@#@^#@%$#@^@#%#$@%@#^│");
                Console.WriteLine("│@!#$#$^@^#%$^&^$%@#%$@#^%$#&^@%@##%│");
                Console.WriteLine("│!$#!^@#^%$@&$&%#%#@$!@$$^%@$#%$#^#$│");
                Console.WriteLine("│@!#$!@#^@%$&%^&%#@$%#@$^&%^%#$%$^@#│");
                Console.WriteLine("│%$#%&^@#$%$#@%$&#%^$@%^&#$%@%@%#$%$│");
                Console.WriteLine("│!@#^%&@^#$%$#%&#%$@%@#$#^&%#$%#%&%@│");
                Console.WriteLine("│#%^*#^%&%*$%^%$&$*#^@%$^&^%*#$^$^#&│");
                Console.WriteLine("│^&#%#%#$&%^&$^$#&#%&@$^%$%&@^#@^$&#│");
                Console.WriteLine("│#$&#&@^#$&%^*%&%@#%#&*&*$%&$%#%^%#$│");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("   Lose   Lose   Lose   Lose   Lose  ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│%!#$%#^@%$@#%#@#@^#@%$#@^@#%#$@%@#^│");
                Console.WriteLine("│@!#$#$^@^#%$^&^$%@#%$@#^%$#&^@%@##%│");
                Console.WriteLine("│!$#!^@#^%$@&$&%#%#@$!@$$^%@$#%$#^#$│");
                Console.WriteLine("│@!#$!@#^@%$&%^&%#@$%#@$^&%^%#$%$^@#│");
                Console.WriteLine("│%$#%&^@#$%$#@%$&#%^$@%^&#$%@%@%#$%$│");
                Console.WriteLine("│!@#^%&@^#$%$#%&#%$@%@#$#^&%#$%#%&%@│");
                Console.WriteLine("│#%^*#^%&%*$%^%$&$*#^@%$^&^%*#$^$^#&│");
                Console.WriteLine("│^&#%#%#$&%^&$^$#&#%&@$^%$%&@^#@^$&#│");
                Console.WriteLine("│#$&#&@^#$&%^*%&%@#%#&*&*$%&$%#%^%#$│");
                Console.WriteLine("│%$&$&@%@%$&@$&$@#$%^#&%^$#%^%$#^#@%│");
                Console.WriteLine("│%@^$%&@%&@$*@*@^%$^#$%&^%$^$&@$%^$#│");
                Console.WriteLine("│*&@^#$%#&@$^@#^$%&%&#&$^$#&$&$%^&#$│");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("    Lose   Lose   Lose   Lose   Lose ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│%!#$%#^@%$@#%#@#@^#@%$#@^@#%#$@%@#^│");
                Console.WriteLine("│@!#$#$^@^#%$^&^$%@#%$@#^%$#&^@%@##%│");
                Console.WriteLine("│!$#!^@#^%$@&$&%#%#@$!@$$^%@$#%$#^#$│");
                Console.WriteLine("│@!#$!@#^@%$&%^&%#@$%#@$^&%^%#$%$^@#│");
                Console.WriteLine("│%$#%&^@#$%$#@%$&#%^$@%^&#$%@%@%#$%$│");
                Console.WriteLine("│!@#^%&@^#$%$#%&#%$@%@#$#^&%#$%#%&%@│");
                Console.WriteLine("│#%^*#^%&%*$%^%$&$*#^@%$^&^%*#$^$^#&│");
                Console.WriteLine("│^&#%#%#$&%^&$^$#&#%&@$^%$%&@^#@^$&#│");
                Console.WriteLine("│#$&#&@^#$&%^*%&%@#%#&*&*$%&$%#%^%#$│");
                Console.WriteLine("│%$&$&@%@%$&@$&$@#$%^#&%^$#%^%$#^#@%│");
                Console.WriteLine("│%@^$%&@%&@$*@*@^%$^#$%&^%$^$&@$%^$#│");
                Console.WriteLine("│*&@^#$%#&@$^@#^$%&%&#&$^$#&$&$%^&#$│");
                Console.WriteLine("│#*$^^&%^#^&@$^#&@%$^#@%^$#&@$%^#$^^│");
                Console.WriteLine("│*@&%@#^#%$@#^@#%$#%@#%#@^@&@#%@^$#^│");
                Console.WriteLine("│#@%#@^&$#&@$^#%^@$&$@^$&@$%^$%^@$&*│");
                Console.WriteLine("│                                   │");
                Console.WriteLine("│                                   │");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("   Lose   Lose   Lose   Lose   Lose  ");

                Thread.Sleep(100);
                Console.Clear();

                Console.WriteLine("┌───────────────────────────────────┐");
                Console.WriteLine("│%!#$%#^@%$@#%#@#@^#@%$#@^@#%#$@%@#^│");
                Console.WriteLine("│@!#$#$^@^#%$^&^$%@#%$@#^%$#&^@%@##%│");
                Console.WriteLine("│!$#!^@#^%$@&$&%#%#@$!@$$^%@$#%$#^#$│");
                Console.WriteLine("│@!#$!@#^@%$&%^&%#@$%#@$^&%^%#$%$^@#│");
                Console.WriteLine("│%$#%&^@#$%$#@%$&#%^$@%^&#$%@%@%#$%$│");
                Console.WriteLine("│!@#^%&@^#$%$#%&#%$@%@#$#^&%#$%#%&%@│");
                Console.WriteLine("│#%^*#^%&%*$%^%$&$*#^@%$^&^%*#$^$^#&│");
                Console.WriteLine("│^&#%#%#$&%^&$^$#&#%&@$^%$%&@^#@^$&#│");
                Console.WriteLine("│#$&#&@^#$&%^*%&%@#%#&*&*$%&$%#%^%#$│");
                Console.WriteLine("│%$&$&@%@%$&@$&$@#$%^#&%^$#%^%$#^#@%│");
                Console.WriteLine("│%@^$%&@%&@$*@*@^%$^#$%&^%$^$&@$%^$#│");
                Console.WriteLine("│*&@^#$%#&@$^@#^$%&%&#&$^$#&$&$%^&#$│");
                Console.WriteLine("│#*$^^&%^#^&@$^#&@%$^#@%^$#&@$%^#$^^│");
                Console.WriteLine("│*@&%@#^#%$@#^@#%$#%@#%#@^@&@#%@^$#^│");
                Console.WriteLine("│#@%#@^&$#&@$^#%^@$&$@^$&@$%^$%^@$&*│");
                Console.WriteLine("│#@^#&%$@&*$^*@$^%#@^%$#^$&$^$%^#&$#│");
                Console.WriteLine("│!%$@#$&$*@^@%^&%&@$^$%#^$%&$#^$%^$#│");
                Console.WriteLine("└───────────────────────────────────┘");
                Console.WriteLine("  Lose   Lose   Lose   Lose   Lose   ");

                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}
