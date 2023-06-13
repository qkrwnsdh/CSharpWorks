﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_23_06_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Console.WriteLine("우리집 강아지 이름은 {0} 이고, 다리 갯수는 {1}개 이다.",
                myDog.dogName, myDog.legCount);

            myDog.Print_DogDescription();

            Dog.Print_DogDescription002();
            Console.WriteLine();


            Cat myCat = new Cat(4, "야옹이", "검정색");
            myCat.Print_MyCat();
            myCat.catName = "새로운 야옹이";
            myCat.Print_MyCat();
            Console.WriteLine();

            Monster_Slime monsterSlime = new Monster_Slime();
            monsterSlime.Initilize("슬라임", "이물", 99, 99, 99, 99);
            Console.WriteLine();

            Monster_LeeJeongGeun monsterLeeJeongGeun = new Monster_LeeJeongGeun();
            monsterLeeJeongGeun.print_Monster_LeeJeongGeun();
            Console.WriteLine();

            Monster_Skeleton monster_Skeleton = new Monster_Skeleton();
            monster_Skeleton.print_Monster_Skeleton();
            Console.WriteLine();


            //string[] str = new string[2] { "Hello", "World" };
            ////CallFunc001(str);
            ////CallFunc002("Hello", "World", "+", "Hello", "World");
            ////CallFunc003(ref str);

            //    string[] resultStr;             //배열을 선언함.
            //CallFunc004(str, out resultStr);    //out을 활용해서 값을 넘겨 받음
            //foreach (String result_ in resultStr)
            //{
            //    Console.Write("{0} ", result_);
            //}
        }       // Main()

        // ! 네 번째 방법은 매개변수를 Call by referecne 방식으로 넘기는 방법
        // ! 매개변수를 통해서 값을 Return 한다.
        static void CallFunc004(string[] str, out string[] outstr)
        {
            string[] resultString = new string[str.Length + 1];

            for (int i = 0; i < str.Length; i++)
            {
                resultString[i] = str[i];
            }
            resultString[str.Length] = "!";
            outstr = resultString;

            int number = 0;
            number = number++;
            Console.WriteLine("number는 무슨 값이 들어 있나?? {0}", number);
        }

        // ! 세 번째 방법은 매개변수를 Call by reference 방식으로 넘기는 방법
        static void CallFunc003(ref string[] str)
        {
            foreach (string strElement in str)
            {
                Console.Write("{0} ", strElement);
            }
            Console.WriteLine();
        }       //CallFunc003();

        // ! 두 번쨰 방법은 매개변수를 Call by value 방식으로 넘기는건 똑같음, 그런데 넘겨줄
        // ! 매개변수 배열의 요소 형태로 여러개 넘길 수 있다.
        static void CallFunc002(params string[] str)                // params = 매개변수
        {
            foreach (string strElement in str)
            {
                Console.Write("{0} ", strElement);
            }
            Console.WriteLine();
        }       //CallFunc002();

        // ! 첫 번째 방법은 매개변수를 Call by value 방식으로 넘기는 방법
        static void CallFunc001(string[] str)
        {
            foreach (string strElement in str)
            {
                foreach (char char_ in strElement)
                {
                    Console.Write("{0}", char_);
                }
                Console.Write("{0} ", strElement);
            }
            Console.WriteLine();
        }       // CallFunc001()
    }           // class Program
}
