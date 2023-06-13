using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Test_23_06_12
{
    public class MonsterBase
    {                                       //protected는 상속받은 자식 클래스에서는 쓸 수 있도록 하겠다는 의미.
        protected string monsterName;
        protected int monsterHp;
        protected int monsterMp;
        protected int monsterDamage;
        protected int monsterDefence;
        protected string monsterType;

        //Initilize = 초기화
        public virtual void Initilize(string monsterName, string monsterType, int monsterHp, int monsterMp, int monsterDamage, int monsterDefence)
        {
            this.monsterName = monsterName;
            this.monsterType = monsterType;
            this.monsterHp = monsterHp;
            this.monsterMp = monsterMp;
            this.monsterDamage = monsterDamage;
            this.monsterDefence = monsterDefence;
        }

        public virtual void print_Monster_Slime()
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
