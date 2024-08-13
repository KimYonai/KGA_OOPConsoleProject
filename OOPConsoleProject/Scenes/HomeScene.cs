using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class HomeScene : Scene
    {
        private string input;
        private Player player;

        public HomeScene(Game game) : base(game) { }

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

        public override void Input()
        {
            Console.ReadKey();
        }

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

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine($"{player.name} 이/가 푹신한 침대에 몸을 던져 휴식을 취한다.");
                    Thread.Sleep(1000);
                    if (player.maxHP - player.curHP >= 30)
                    {
                        Console.WriteLine("체력을 회복합니다.");
                        player.curHP += 30;
                    }
                    else if (player.maxHP - player.curHP < 30)
                    {
                        Console.WriteLine("체력을 회복합니다.");
                        player.curHP += player.maxHP - player.curHP;
                    }
                    else if (player.maxHP == player.curHP)
                    {
                        Console.WriteLine("하지만 기운이 넘쳐서인지 내 몸이 침대를 거부한다...");
                    }
                    break;

                case "2":
                    game.ChangeScene(SceneType.Town);
                    break;
            }
        }
    }
}
