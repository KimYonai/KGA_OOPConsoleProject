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
                    else
                    {
                        Console.WriteLine("1. "
                    }

            }
        }

        public void AddItem()
        {
            this.inventory[index] = item;
            index++;
            Render();
        }

        public void RemoveItem()
        {
            inventory.RemoveAt(index);
            index--;
            Render();
        } 
    }
}
