using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class GameOverScene : Scene
    {
        public GameOverScene(Game game) : base(game) { }

        public override void Enter()
        {

        }
        public override void Exit()
        {

        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("           Game Over");
            Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
            Console.WriteLine();
            Console.WriteLine("        [Press Any Key]");
        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Update()
        {

        }  
    }
}
