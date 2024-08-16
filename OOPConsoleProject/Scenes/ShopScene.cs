using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 상점 화면
    // 코드는 여러번 수정하며 구현했지만, 마지막에 시간이 부족하여 직접 테스트를 하지는 못했습니다.
    // 구동이 되지 않았을 경우, 잘못된 부분에 대한 피드백 부탁드립니다.
    public class ShopScene : Scene
    {
        private string input;
        private InventoryScene inven;
        public int index = 0;
        private Item item;
        private Weapons weapon;
        private Armors armor;
        private Accs acc;
        private Consumes consume;

        public ShopScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        // 상점 진입 시 출력 내용
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("         [구매할 아이템 선택]        ");
            Console.WriteLine("-----------------------------------");
            // 1번 아이템 품목 출력 조건
            if (player.Job == Job.Warrior)
            {
                Console.WriteLine("1 | 롱 소드 | 200G");
            }
            if (player.Job == Job.Mage)
            {
                Console.WriteLine("1 | 고목 스태프 | 200G");
            }
            if (player.Job == Job.Archor)
            {
                Console.WriteLine("1 | 사냥꾼의 활 | 200G");
            }
            if (player.Job == Job.Rogue)
            {
                Console.WriteLine("1 | 복수의 단검 | 200G");
            }
            if (player.Job == Job.Priest)
            {
                Console.WriteLine("1 | 홀리 바이블 | 200G");
            }

            // 2번 아이템 품목 출력 조건
            if (player.Job == Job.Warrior)
            {
                Console.WriteLine("2 | 철 갑옷 | 300G");
            }
            if (player.Job == Job.Mage)
            {
                Console.WriteLine("2 | 마법의 로브 | 300G");
            }
            if (player.Job == Job.Archor)
            {
                Console.WriteLine("2 | 사냥꾼의 옷 | 300G");
            }
            if (player.Job == Job.Rogue)
            {
                Console.WriteLine("2 | 검정색 슈트 | 300G");
            }
            if (player.Job == Job.Priest)
            {
                Console.WriteLine("2 | 성스러운 로브 | 300G");
            }

            // 3번 아이템 품목 출력 조건
            if (player.Job == Job.Warrior)
            {
                Console.WriteLine("3 | 축복받은 로자리오 | 150G");
            }
            if (player.Job == Job.Mage)
            {
                Console.WriteLine("3 | 마법 속성 수정 | 150G");
            }
            if (player.Job == Job.Archor)
            {
                Console.WriteLine("3 | 사냥꾼의 깃털 | 150G");
            }
            if (player.Job == Job.Rogue)
            {
                Console.WriteLine("3 | 은색 한쪽 귀고리 | 150G");
            }
            if (player.Job == Job.Priest)
            {
                Console.WriteLine("3 | 빛나는 십자가 | 150G");
            }

            Console.WriteLine("4 | 빨간 포션 | 50G");
            Console.WriteLine("5 | 파란 포션 | 50G");
            Console.WriteLine("6 | 닭다리 | 50G");
            Console.WriteLine("7 | 성수 | 100G");
            Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
            Console.WriteLine("마을로 돌아가기: 0");
            Console.WriteLine();
            Console.Write("아이템 선택(0 ~ 7): ");
        }

        // 값 입력 함수
        public override void Input()
        {
            input = Console.ReadLine();
        }

        // 값 입력에 따른 업데이트
        public override void Update()
        {
            switch (input)
            {
                // 직업에 따라 구매 가능한 무기를 다르게 설정
                case "1":
                    if (player.gold > 200)
                    {
                        if (player.Job == Job.Warrior)
                        {
                            Console.WriteLine("구매에 성공했습니다.");
                            player.attack += 20;
                            player.gold -= 200;
                            AddItem();
                        }
                        else
                        {
                            Console.WriteLine("구매에 성공했습니다.");
                            player.attack += 10;
                            player.gold -= 200;
                            AddItem();
                        }
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                // 직업에 따라 구매 가능한 방어구를 다르게 설정
                case "2":
                    if (player.gold > 300)
                    {
                        if (player.Job == Job.Warrior)
                        {
                            Console.WriteLine("구매에 성공했습니다.");
                            player.defense += 20;
                            player.gold -= 300;
                            AddItem();
                        }
                        else
                        {
                            Console.WriteLine("구매에 성공했습니다.");
                            player.defense += 10;
                            player.gold -= 300;
                            AddItem();
                        }
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                // 직업에 따라 구매 가능한 장신구를 다르게 설정
                case "3":
                    if (player.gold > 150)
                    {
                        Console.WriteLine("구매에 성공했습니다.");
                        game.Player.MaxHP += 20;
                        player.gold -= 150;
                        AddItem();
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                // case "4" ~ "7": 소비(Consumes) 아이템
                case "4":
                    if (player.gold > 50)
                    {
                        Console.WriteLine("구매에 성공했습니다.");
                        player.gold -= 50;
                        AddItem();
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                case "5":
                    if (player.gold > 50)
                    {
                        Console.WriteLine("구매에 성공했습니다.");
                        player.gold -= 50;
                        AddItem();
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                case "6":
                    if (player.gold > 50)
                    {
                        Console.WriteLine("구매에 성공했습니다.");
                        player.gold -= 50;
                        AddItem();
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                case "7":
                    if (player.gold > 100)
                    {
                        Console.WriteLine("구매에 성공했습니다.");
                        player.gold -= 100;
                        AddItem();
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                    }
                    break;

                case "0":
                    game.ChangeScene(SceneType.Town);
                    break;

                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    Console.Write("원하는 카테고리를 숫자로 입력해주세요: ");
                    Input();
                    break;
            }
        }

        // 아이템 구매 시 인벤토리에 추가 함수
        public void AddItem()
        {
            inven.inventory[index] = item;
            index++;
        }

    }   
}
