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
        
        public ChurchScene(Player player) : base(player) { }

        public ChurchScene(Game game) : base(game) { }

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

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {
            Console.WriteLine("당신의 기도에 신상이 응답합니다.");

            switch (input)
            {
                case "1":

                    if (game.Player.Attack >= 50)
                    {
                        Console.WriteLine("이미 축복을 받아 성스러움이 묻어난다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("다음 사람에게 양보하자.");
                        Thread.Sleep(2000);
                    }
                    else if (game.Player.Job == Job.Priest)
                    {
                        Console.WriteLine("나는 신님을 대신해서 축복을 주는 사람...");
                        Thread.Sleep(2000);
                        Console.WriteLine("내가 축복을 받으면 안되지 않을까...?");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("성스러운 기운의 축복을 받았습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("공격력이 10 상승했습니다.");
                        game.Player.Attack += 10;
                        Thread.Sleep(2000);
                    }
                    break;

                case "2":
                    game.ChangeScene(SceneType.Town);
                    break;
            }
        }
    }
}
