﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class InventoryScene : Scene
    {
        private string input;
        public int index = 0;
        private Item item;
        public List<Item> inventory = new List<Item>();

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
                Console.WriteLine($">> {index + 1} | {inventory[index].name}");
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
            
        }

        public void RemoveItem(Item item)
        {
            inventory.RemoveAt(index);
            index--;
            Render();
        }
    }
}
