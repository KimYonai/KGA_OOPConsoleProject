using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class CanyonScene : Scene
    {
        private string input;

        public CanyonScene(Game game) : base(game) { }

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
            Console.WriteLine("아찔한 절벽이 펼쳐진 협곡에 도착했다..");
            Thread.Sleep(2000);
            Console.WriteLine($"그 때, {game.Player.Name} 은/는 절벽의 끝에 뿌리내리고 있는 나무 밑동같은 {game.Monster.Name}를 발견한다.");
            Thread.Sleep(2000);
            Console.WriteLine($"{game.Player.Name} 은/는 {game.Monster.Name}가 몬스터인지 모르고 휴식을 위해 그 위에 걸터앉는다.");
            Thread.Sleep(2000);
            Console.WriteLine($"{game.Monster.Name}는 화들짝 놀라며 일어나서 {game.Player.Name} 을/를 경계하며 공격하려 한다..");
            Console.WriteLine();

            Console.WriteLine("어떻게 하시겠습니까?");
            Console.WriteLine("1. 마을로 도망친다");
            Console.WriteLine($"2. {game.Monster.Name}과 싸운다");
            Console.WriteLine();

            Console.Write("원하는 행동의 번호를 입력해주세요: ");
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
                    Console.WriteLine($"{game.Player.Name} 미안하다고 외치며 후다닥 도망친다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Forest);
                    break;

                case "2":
                    Console.WriteLine($"{game.Player.Name} 은/는 깜짝 놀라며 전투를 준비한다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Battle);
                    break;
            }
        }
    }
}
