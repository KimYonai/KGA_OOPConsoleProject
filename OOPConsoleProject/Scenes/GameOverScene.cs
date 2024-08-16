using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 게임 오버 화면
    public class GameOverScene : Scene
    {
        public GameOverScene(Game game) : base(game) { }

        public override void Enter()
        {

        }
        public override void Exit()
        {

        }

        // 게임 오버 시 출력
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("           Game Over");
            Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
            Console.WriteLine();
            Console.WriteLine("        [Press Any Key]");
        }

        // 아무 키 입력
        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Update()
        {

        }  
    }
}
