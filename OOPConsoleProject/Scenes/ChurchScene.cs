using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ChurchScene : Scene
    {
        private string input;
        private Player player;

        public ChurchScene(Game game) : base(game) { }

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
            Console.WriteLine("성스러움이 느껴지는 교회에 도착했다.");
            Thread.Sleep(2000);

            Console.Clear();
            game.Player.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("[현재 위치: 교회]");
            Console.WriteLine();

            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 기도하기(공격력 증가)");
            Console.WriteLine("2. 마을로 이동");
            Console.WriteLine();

            Console.Write("원하는 행동의 번호를 입력해주세요: ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    // 각 직업별로 1번 증가받고, 그 다음은 축복을 받아도 공격력이 증가하지 않게 설정(전사는 2번 받을 수 있게 설정)
                    // 성직자는 공격력이 증가하지 않게 설정
                    if (player.job == Job.Warrior && player.job == Job.Rogue
                        && player.attack >= 50)
                    {
                        Console.WriteLine("이미 축복을 받아 성스러움이 묻어난다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("다음 사람에게 양보하자.");
                    }
                    else if (player.job == Job.Archor &&  player.job == Job.Mage
                            && player.attack >= 60)
                    {
                        Console.WriteLine("이미 축복을 받아 성스러움이 묻어난다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("다음 사람에게 양보하자.");
                    }
                    else if (player.job == Job.Priest)
                    {
                        Console.WriteLine("나는 신님을 대신해서 축복을 주는 사람...");
                        Thread.Sleep(1000);
                        Console.WriteLine("내가 축복을 받으면 안되지 않을까...?");
                    }
                    else
                    {
                        Console.WriteLine("성스러운 기운의 축복을 받았습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("공격력이 10 상승했습니다.");
                        player.attack += 10;
                    }
                    break;

                case "2":
                    game.ChangeScene(SceneType.Town);
                    break;
            }
        }
    }
}
