using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_23_06_12
{
    public class Monster_Slime : MonsterBase
    {
        public override void print_Monster_Slime()
        {
            base.print_Monster_Slime();

            Console.WriteLine("야옹이 클래스에서 뭔가 추가 작업을 했다.");
            Console.WriteLine();
        }
        public override void Initilize(string monsterName, string monsterType, int monsterHp, int monsterMp, int monsterDamage, int monsterDefence)
        {
            base.Initilize(monsterName, monsterType, monsterHp, monsterMp, monsterDamage, monsterDefence);
        }

        public void Print_OverloadingTest()
        {
            Console.WriteLine("함수 찍힌다.");
        }

        public void Print_OverloadingTest(int textStr)
        {
            Console.WriteLine("함수 찍힌다");
        }
        
        
        //string monsterName = "슬라임";
        //int monsterHp = 999999;
        //int monsterMp = 999999;
        //int monsterDamage = 999999;
        //int monsterDefence = 999999;
        //string monsterType = "이물";

        //public void print_Monster_Slime()
        //{
        //    Console.WriteLine(
        //        "몬스터 이름     :   {0}\n" +
        //        "몬스터 타입     :   {1}\n" +
        //        "몬스터 체력     :   {2}\n" +
        //        "몬스터 마나     :   {3}\n" +
        //        "몬스터 파워     :   {4}\n" +
        //        "몬스터 방어     :   {5}\n",
        //        monsterName, monsterType, monsterHp, monsterMp, monsterDamage, monsterDefence);
        //}
    }

    public class Monster_LeeJeongGeun
    {
        string monsterName = "이정근";
        int monsterHp = 10;
        int monsterMp = 0;
        int monsterDamage = 0;
        int monsterDefence = 99999;
        string monsterType = "요물";

        public void print_Monster_LeeJeongGeun()
        {
            Console.WriteLine(
                "몬스터 이름     :   {0}\n" +
                "몬스터 타입     :   {1}\n" +
                "몬스터 체력     :   {2}\n" +
                "몬스터 마나     :   {3}\n" +
                "몬스터 파워     :   {4}\n" +
                "몬스터 방어     :   {5}\n",
                monsterName, monsterType, monsterHp, monsterMp, monsterDamage, monsterDefence);
        }
    }

    public class Monster_Skeleton
    {
        string monsterName = "스켈레톤";
        int monsterHp = 1000;
        int monsterMp = 500;
        int monsterDamage = 100;
        int monsterDefence = 0;
        string monsterType = "언데드";

        public void print_Monster_Skeleton()
        {
            Console.WriteLine(
                "몬스터 이름     :   {0}\n" +
                "몬스터 타입     :   {1}\n" +
                "몬스터 체력     :   {2}\n" +
                "몬스터 마나     :   {3}\n" +
                "몬스터 파워     :   {4}\n" +
                "몬스터 방어     :   {5}\n",
                monsterName, monsterType, monsterHp, monsterMp, monsterDamage, monsterDefence);
        }
    }


}
