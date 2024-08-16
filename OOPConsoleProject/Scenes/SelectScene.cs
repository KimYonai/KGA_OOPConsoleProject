using OOPConsoleProject.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 플레이어 선택 화면
    public class SelectScene : Scene
    {
        private Player player;

        public enum State { Name, Job, Confirm }        // 이름, 작업, 확인 입력 상황을 구분하기 위한 열거형
        private State curState;
        private string input;
        private string nameInput;

        public SelectScene(Game game) : base(game) { }

        // 플레이어의 이름 설정
        public override void Enter()
        {
            curState = State.Name;
        }

        public override void Exit()
        {

        }

        public override void Render()
        {
            Console.Clear();
            // 플레이어의 이름 입력
            if (curState == State.Name)
            {
                Console.Write("캐릭터의 이름을 입력하세요: ");
            }
            // 플레이 할 직업 입력
            else if (curState == State.Job)
            {
                Console.WriteLine("플레이 할 직업을 선택해주세요.");
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 마법사");
                Console.WriteLine("3. 궁수");
                Console.WriteLine("4. 도적");
                Console.WriteLine("5. 성직자");
                Console.Write("선택한 직업(1 ~ 5): ");
            }
            // 선택 확인 창
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

        // 값 입력 함수
        public override void Input()
        {
            input = Console.ReadLine();
        }

        // 값 입력에 따른 업데이트
        public override void Update()
        {
            if (curState == State.Name)
            {
                if (input == string.Empty)
                    return;

                nameInput = input;
                curState = State.Job;
            }
            // 입력한 값에 따른 해당 직업 정보 호출
            else if (curState == State.Job)
            {
                switch (input)
                {
                    case "1":
                        game.Player = new Warrior(nameInput);
                        break;

                    case "2":
                        game.Player = new Mage(nameInput);
                        break;

                    case "3":
                        game.Player = new Archor(nameInput);
                        break;

                    case "4":
                        game.Player = new Rogue(nameInput);
                        break;

                    case "5":
                        game.Player = new Priest(nameInput);
                        break;
                }

                curState = State.Confirm;
            }
            // 확인 창에서의 입력값에 대한 업데이트
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
