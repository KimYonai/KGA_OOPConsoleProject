using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ForestScene : Scene
    {
        private string input;
        private Player player;
        private Monster monster;

        public ForestScene(Game game) : base(game) { }

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
            Console.WriteLine("기분 좋은 바람이 나무 사이로 불어오는 수련의 숲에 도착했다.");
            Thread.Sleep(2000);
            Console.WriteLine($"그 때, {player.name} 은/는 나무 그늘에서 쉬고 있던 슬라임 한 마리를 발견한다."); 
            Thread.Sleep(2000);
            Console.WriteLine($"슬라임도 {player.name} 을/를 발견하고 화들짝 놀라며 전투태세를 취한다."); 
            Thread.Sleep(2000);
            Console.WriteLine($"{player.name} 은/는 싸울 생각이 없었지만, 덤벼드는 슬라임을 보고있을 수만은 없다.");
            Console.WriteLine();

            Console.WriteLine("어떻게 하시겠습니까?");
            Console.WriteLine("1. 마을로 도망친다");
            Console.WriteLine("2. 모른 척하고 후다닥 가던 길을 간다");
            Console.WriteLine("3. 슬라임과 싸운다");
            Console.WriteLine();

            Console.Write("원하는 행동의 번호를 입력해주세요: ");
        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine($"{player.name} 은/는 슬라임을 피해 빠르게 마을로 도망쳤습니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Town);
                    break;

                case "2":
                    Console.WriteLine($"{player.name} 은/는 이 악물고 슬라임을 모른척 하며 후다닥 지나갔습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine($"슬라임을 지나쳐 걸은지 얼마나 됐을까...\n{player.name}의 눈 앞에 가파른 절벽이 펼쳐진 협곡이 보이기 시작한다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Canyon);
                    break;

                case "3":
                    Console.WriteLine($"{player.name} 은/는 자신을 경계하는 슬라임과의 전투를 준비한다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Battle);
                    break;
            }
        }
    }
}
