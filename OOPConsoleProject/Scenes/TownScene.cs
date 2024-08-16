using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 마을 화면
    public class TownScene : Scene
    {
        private string input;

        public TownScene(Game game) : base(game) { }

        // 게임 내 로딩 화면 구현
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        // 마을 화면 진입 시 출력
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("따뜻하고 활기찬 마을로 왔습니다.");
            Thread.Sleep(2000);

            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("[현재 위치: 마을]");
            Console.WriteLine();

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 인벤토리 확인");
            Console.WriteLine("2. 상점으로 이동");
            Console.WriteLine("3. 교회로 이동");
            Console.WriteLine("4. 숙소로 이동");
            Console.WriteLine("5. 상점으로 이동");
            Console.WriteLine("6. 수련의 숲으로 이동");
            Console.WriteLine();

            Console.Write("원하는 행동의 번호를 입력해주세요: ");
        }

        // 값 입력 함수
        public override void Input()
        {
            input = Console.ReadLine();
        }

        // 입력한 값에 따른 업데이트
        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Inventory);
                    break;

                case "2":
                    game.ChangeScene(SceneType.Shop);
                    break;

                case "3":
                    game.ChangeScene(SceneType.Church);
                    break;

                case "4":
                    game.ChangeScene(SceneType.Home);
                    break;

                case "5":
                    game.ChangeScene(SceneType.Shop);
                    break;

                case "6":
                    game.ChangeScene(SceneType.Forest);
                    break;

                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    Console.Write("보기에서 원하시는 행동의 숫자를 입력해주세요: ");
                    Input();
                    break;
            }
        }
    }
}
