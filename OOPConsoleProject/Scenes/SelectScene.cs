using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class SelectScene : Scene
    {
        public enum State { Name, Job, Confirm }
        private State curState;
        private string input;
        private string nameInput;

        public SelectScene(Game game) : base(game) { }

        public override void Enter()
        {
            curState = State.Name;
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();

            if (curState == State.Name)
            {
                Console.Write("캐릭터의 이름을 입력하세요: ");
            }
            else if (curState == State.Job)
            {
                Console.WriteLine("플레이 할 직업을 선택해주세요.");
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 마법사");
                Console.WriteLine("3. 궁수");
                Console.WriteLine("4. 도적");
                Console.WriteLine("5. 성직자");
                Console.Write("선택한 직업: ");
            }
            else if (curState == State.Confirm)
            {
                Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
                Console.WriteLine($"이름: {game.Player.Name}");
                Console.WriteLine($"직업: {game.Player.Job}");
                Console.WriteLine($"체력: {game.Player.MaxHP}");
                Console.WriteLine($"공격력: {game.Player.Attack}");
                Console.WriteLine($"방어력: {game.Player.Defense}");
                Console.WriteLine($"소지금: {game.Player.Gold}");
                Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
                Console.WriteLine();
                Console.Write("선택한 직업으로 플레이 하시겠습니까? (y/n)");
            }
        }

        public override void Update()
        {
            if (curState == State.Name)
            {
                if (input == string.Empty)
                    return;

                nameInput = input;
                curState = State.Job;
            }
            else if (curState == State.Job)
            {
                if (Job.TryParse(input, out Job select) == false)
                    return;

                if (Enum.IsDefined(typeof(Job), select) == false)
                    return;

                switch (select)
                {
                    case Job.Warrior:
                        game.Player = new Warrior(nameInput);
                        break;

                    case Job.Mage:
                        game.Player = new Mage(nameInput);
                        break;

                    case Job.Archor:
                        game.Player = new Archor(nameInput);
                        break;

                    case Job.Rogue:
                        game.Player = new Rogue(nameInput);
                        break;

                    case Job.Priest:
                        game.Player = new Priest(nameInput);
                        break;
                }

                curState = State.Confirm;
            }
            else if (curState == State.Confirm)
            {
                switch (input)
                {
                    case "Y":
                    case "y":
                        game.ChangeScene(SceneType.Town);
                        break;

                    case "N":
                    case "n":
                        curState = State.Name;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
