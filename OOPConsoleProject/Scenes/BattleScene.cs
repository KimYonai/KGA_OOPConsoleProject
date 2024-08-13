using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class BattleScene : Scene
    {
        private string input;
        public BattleScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("==========Battle Start!==========");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("============Battle End============");
            Thread.Sleep(2000);
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
