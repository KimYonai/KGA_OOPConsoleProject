using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ShopScene : Scene
    {
        private string input;
        private InventoryScene inven;

        public ShopScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loadind...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("Loadind...");
            Thread.Sleep(2000);
        }

        public override void Render()
        {

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {

        }

        public void AddItem(Item item)
        {
            inven.inventory[inven.index] = item;
            inven.index++;
        }
    }
}
