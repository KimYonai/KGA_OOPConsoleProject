using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game) { }

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
            Console.WriteLine();
            Console.WriteLine("           Game Name");
            Console.WriteLine();
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
            game.ChangeScene(SceneType.Select);
        }
    }
}
