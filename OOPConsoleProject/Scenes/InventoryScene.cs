using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 인벤토리 화면
    // 코드는 여러번 수정하며 구현했지만, 마지막에 시간이 부족하여 직접 테스트를 하지는 못했습니다.
    // 구동이 되지 않았을 경우, 잘못된 부분에 대한 피드백 부탁드립니다.
    public class InventoryScene : Scene
    {
        private string input;
        private int index = 0;
        private int select;
        private Item item;
        public List<Item> inventory = new List<Item>();

        private Weapons weapon;
        private Armors armor;
        private Accs acc;
        private Consumes consume;

        public InventoryScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        // 인벤토리 진입 시 출력
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("           [인벤토리 목록]          ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"소유 골드: {game.Player.Gold}");
            Console.WriteLine("-----------------------------------");
            // 인벤토리 리스트 내 아이템이 있으면 아이템 정보, 없으면 공백 출력
            if (inventory[index] != null)
            {
                Console.WriteLine($">> {index + 1} | {inventory[index].name} | {inventory[index].script}");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
            Console.WriteLine("마을로 돌아가기: 0");
            Console.WriteLine();
            Console.Write("아이템 선택(0 ~ 10): ");
        }

        // 값 입력 함수
        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {
            // 아이템 번호에 맞는 값 입력 시 행동
            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    // 해당 인벤토리 칸이 비어있을 경우
                    if (inventory[index] == null)
                    {
                        Console.WriteLine("해당 슬롯은 비어있습니다.");
                    }
                    // 해당 인벤토리 칸에 소비 아이템이 있는 경우
                    else if (inventory[index] == consume)
                    {
                        Console.WriteLine("1. 아이템 사용");
                        Console.WriteLine("2. 아이템 삭제");
                        Console.Write("선택한 동작: ");
                        Input();

                        if (input == "1")
                        {
                            UseItem();
                        }
                        else
                        {
                            RemoveItem();
                        }
                    }
                    // 해당 인벤토리 칸에 무기 아이템이 있는 경우
                    else if (inventory[index] == weapon)
                    {
                        Console.WriteLine("1. 아이템 장착");
                        Console.WriteLine("2. 아이템 삭제");
                        Console.Write("선택한 동작: ");
                        Input();

                        if (input == "1")
                        {
                            UseItem();
                        }
                        else
                        {
                            RemoveItem();
                        }
                    }
                    // 해당 인벤토리 칸에 방어구 아이템이 있는 경우
                    else if (inventory[index] ==armor)
                    {
                        Console.WriteLine("1. 아이템 장착");
                        Console.WriteLine("2. 아이템 삭제");
                        Console.Write("선택한 동작: ");
                        Input();

                        if (input == "1")
                        {
                            UseItem();
                        }
                        else
                        {
                            RemoveItem();
                        }
                    }
                    // 해당 인벤토리 칸에 장신구 아이템이 있는 경우
                    else if (inventory[index] == acc)
                    {
                        Console.WriteLine("1. 아이템 장착");
                        Console.WriteLine("2. 아이템 삭제");
                        Console.Write("선택한 동작: ");
                        Input();

                        if (input == "1")
                        {
                            UseItem();
                        }
                        else
                        {
                            RemoveItem();
                        }
                    }
                    break;

                // 마을로 돌아가기
                case "0":
                    game.ChangeScene(SceneType.Town);
                    break;
            }
        }

        // 인벤토리 리스트에 있는 아이템 사용 함수
        public void UseItem()
        {
            if (inventory[index] == consume)
            {
                if (consume.name == "성수")
                {
                    player.defense += 10;
                }
                else
                {
                    player.curHP += 10;
                }
            }
            else if (inventory[index] == weapon)
            {
                if (weapon.name == "롱 소드")
                {
                    player.attack += 20;
                }
                else
                {
                    player.attack += 10;
                }
            }
            else if (inventory[index] == armor)
            {
                if (weapon.name == "철 갑옷")
                {
                    player.defense += 20;
                }
                else
                {
                    player.defense += 10;
                }
            }
            else if (inventory[index] == acc)
            {
                Console.WriteLine("1. 아이템 장착");
                Console.WriteLine("2. 아이템 삭제");
                Console.WriteLine("3. 선택 취소");
                Input();
            }
            inventory.RemoveAt(index);
            index--;

        }

        // 인벤토리 리스트에 있는 아이템 버리기 함수
        public void RemoveItem()
        {
            Console.WriteLine("아이템을 삭제했습니다.");
            inventory.RemoveAt(index);
            index--;
        } 
    }
}
