using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
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

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("           [인벤토리 목록]          ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"소유 골드: {game.Player.Gold}");
            Console.WriteLine("-----------------------------------");
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

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {
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
                    if (inventory[index] == null)
                    {
                        Console.WriteLine("해당 슬롯은 비어있습니다.");
                    }
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

                case "0":
                    game.ChangeScene(SceneType.Town);
                    break;
            }
        }

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

        public void RemoveItem()
        {
            Console.WriteLine("아이템을 삭제했습니다.");
            inventory.RemoveAt(index);
            index--;
        } 
    }
}
