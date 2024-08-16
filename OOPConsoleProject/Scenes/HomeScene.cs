using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 숙소 화면
    public class HomeScene : Scene
    {
        private string input;
        private Player player;

        public HomeScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        // 숙소 진입 시 출력
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("푹신한 침대가 반겨주는 숙소에 도착했다.");
            Thread.Sleep(2000);

            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("[현재 위치: 숙소]");
            Console.WriteLine();

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 휴식하기(HP 회복)");
            Console.WriteLine("2. 마을로 이동");
            Console.WriteLine();

            Console.Write("원하는 행동의 번호를 입력해주세요: ");
        }

        // 값 입력 함수
        public override void Input()
        {
            input = Console.ReadLine();
        }

        // 값 입력에 따른 업데이트
        public override void Update()
        {
            switch (input)
            {
                // case "1": 체력 회복
                case "1":
                    Console.WriteLine($"{game.Player.Name} 이/가 푹신한 침대에 몸을 던져 휴식을 취한다.");
                    Thread.Sleep(2000);
                    if (game.Player.MaxHP - game.Player.CurHP >= 30)
                    {
                        Console.WriteLine("체력을 회복합니다.");
                        player.curHP += 30;
                        Thread.Sleep(2000);
                    }
                    else if (game.Player.MaxHP - game.Player.CurHP < 30 && game.Player.MaxHP != game.Player.CurHP)
                    {
                        Console.WriteLine("체력을 회복합니다.");
                        player.curHP += game.Player.MaxHP - game.Player.CurHP;
                        Thread.Sleep(2000);
                    }
                    else if (game.Player.MaxHP == game.Player.CurHP)
                    {
                        Console.WriteLine("하지만 기운이 넘쳐서인지 내 몸이 침대를 거부한다...");
                        Thread.Sleep(2000);
                    }
                    break;

                // case "2": 마을로 돌아가기
                case "2":
                    game.ChangeScene(SceneType.Town);
                    break;
            }
        }
    }
}
