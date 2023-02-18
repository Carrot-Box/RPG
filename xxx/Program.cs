using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//시스템 추가 예정
//나나나나ㅏ나중 최종 시스템
//아군공격력 100 - 적군방어력 50 = +50
//아군공격력 100 - 적군방어력 200 = -100
//최소 5%의 딜 보정이 되어서 5%의 딜이 들간다. -> 명방 방어력 메커니즘
//-------------------

//0. 전투종료후 마을 or Next선택지 만들기 (O)
//1. LVUP기능 (공격력 강화 체력증가 방어력증가) (0)
//2. 방어력 먼저 깍고 체력 깎는 시스템
//3. 다른 스테이지에 다른 몬스터 나오기
class FightUnit
{
    protected string Name = "None";
    protected int ATT = 200;
    protected int DEF = 100;
    protected int HP = 500;
    protected int MAXHP = 1000;

    // bool : 논리형 내가 HP가 0이나 아니냐를 알려주는것(참과 거짓)
    public bool IsDeath()
    {
        // bool boolDeath = HP <= 0;
        // 연산자도 함수에 가까움, 리턴값이(결과값)이 있다
        return HP <= 0;
    }
    public void Damage(FightUnit _OtherUnit)
    {
        Console.Write(Name);
        Console.Write("가" + _OtherUnit.ATT);
        Console.WriteLine("의 데미지를 입었습니다");
        Console.ReadKey();
        HP -= _OtherUnit.ATT;
    }
    public void StatusRender()
    {
        Console.Write(Name);
        Console.WriteLine("------------------------");
        Console.Write("AT : " + ATT);
        Console.WriteLine("         DEF : " + DEF);
        Console.Write("HP : " + HP);
        Console.WriteLine("/" + MAXHP);
        Console.WriteLine("------------------------------");
    }
    public void LvUp()
    {
        ATT *= 2;
        DEF *= 2;
        HP *= 2;
        MAXHP *= 2;
        StatusRender();
        Console.WriteLine("플레이어가 레벨업 하였습니다.");
    }
    public void AttMechanism()
    {
        if (true)
        {
            // 만약 Def가 0이 아니라면 Def를 떄린다
            // 만약 Def가 0이라면 Hp를 공격한다.
        }
    }
}
class Player : FightUnit
{
    public Player(string _Name)
    {
        Name = _Name;
    }
    public void PrintHp()
    {
        Console.Write("현재 플레이어의 HP는" + HP);
        Console.WriteLine("입니다.");
        Console.ReadKey();
    }
    public void MaxHeal(/*Player this*/)
    {
        // 작은 함수는 많이많이 만들자.
        if (HP < MAXHP)
        {
            PrintHp();
            this.HP = MAXHP;
        }
        else
        {
            Console.Write("현재 플레이어의 HP는" + HP);
            Console.WriteLine("입니다.");
            Console.ReadKey();
            Console.WriteLine("플레이어의 체력이 가득찼습니다.");
            Console.ReadKey();
        }
    }
}
class Monster : FightUnit
{
    public Monster(string _Name)
    {
        Name = _Name;
    }
}
class Stage
{
    // 스테이지는 나아아아아중에 하자
    // 몬스터 정보 / 몬스터는 스펙up
}
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONESELECT
}
namespace TEXTRPG
{
    internal class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("이세계에 오신것을 환영합니다,\n어느곳으로 가실 겁니까?");
            Console.WriteLine("1. 마을 \n2. 배틀");
            Console.WriteLine("------------------------------");

            ConsoleKeyInfo CKI = Console.ReadKey();
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 떠나겠습니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("전장으로 떠나겠습니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못 입력하였습니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }
        static STARTSELECT Town(Player _Player)
        {
            while (true)
            {// 탈주 코드
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 
                // 탈주 

                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에 오신것을 환영합니다. \n무엇을 도와드릴까요?");
                Console.WriteLine("1. 체력회복 \n2. 머하지... \n3. 떠나기");
                Console.WriteLine("------------------------------");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("이것을 보고있는 당신 생각해봐!");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        return STARTSELECT.NONESELECT;
                }
            }
        }
        static STARTSELECT Battle(Player _Player)
        {
            Monster NewMonster = new Monster("오크");
            while (!NewMonster.IsDeath() && !_Player.IsDeath())
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                Console.ReadKey();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("");
                        // 둘다 죽는걸 방지하기 위해서 한대 떄리자마자 채크
                        // 그걸 if로 묶어주고 뉴몬스터가 안죽었을때만 플레이어가 대미지를 줄 수 있도록

                        NewMonster.Damage(_Player);
                        if (!NewMonster.IsDeath())
                        {
                            _Player.Damage(NewMonster);
                        }
                        else
                        {
                            // 몬스터가 죽었을 경우
                            NewMonster.IsDeath();
                            Console.WriteLine("몬스터 체력이 0이 되었습니다.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("전투에서 승리하였습니다");
                            _Player.LvUp();
                            Console.WriteLine("어디로 가시겠습니까?");
                            Console.WriteLine("1. 마을로 돌아가기\n2. 다음 스테이지로 넘어가지");
                            Console.WriteLine("------------------------------");
                            switch (Console.ReadKey().Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("마을로 돌아가겠습니다.");
                                    Console.ReadKey();
                                    return STARTSELECT.SELECTTOWN;
                                case ConsoleKey.D2:
                                    Console.WriteLine("다음 스테이지가 없습니다. 마을로 돌아가겠습니다.");
                                    Console.ReadKey();
                                    return STARTSELECT.SELECTTOWN;
                            }
                        }
                        break;
                }
            }
            return STARTSELECT.SELECTTOWN;
        }
        static void Main(string[] args)
        {
            // 반복문에안들어가도록 반드시 조심할것
            Player NewPlayer = new Player("플레이어");

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;

            while (true)
            {
                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;
                }
            }
        }
    }
}

//