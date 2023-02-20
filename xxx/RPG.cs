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

public enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    BATTLE2,
    NONESELECT
}
namespace TEXTRPG
{
    internal class RPG
    {
        
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;


            while (true)
            {
                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = Menu.StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = Menu.Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = Menu.Battle(NewPlayer);
                        break;
                    case STARTSELECT.BATTLE2:
                        SelectCheck = Menu.Battle2(NewPlayer);
                        break;
                }
            }
        }
    }
}