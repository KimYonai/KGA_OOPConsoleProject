using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 게임 시작 시 출력되는 타이틀 화면
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game) { }

        public override void Enter()
        {

        }

        public override void Exit()
        {

        }

        // 시작 시 해당 함수 출력
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

        // 아무 키 입력 시 업데이트
        public override void Input()
        {
            Console.ReadKey();
        }

        // 키 입력에 따른 업데이트로 선택 화면으로 전환
        public override void Update()
        {
            game.ChangeScene(SceneType.Select);
        }
    }
}
