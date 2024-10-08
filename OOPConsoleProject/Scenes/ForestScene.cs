﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    // 수련의 숲 화면
    public class ForestScene : Scene
    {
        private string input;

        public ForestScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        // 수련의 숲 진입 시 출력
        public override void Render()
        {
            Console.WriteLine("기분 좋은 바람이 나무 사이로 불어오는 수련의 숲에 도착했다.");
            Thread.Sleep(2000);
            Console.WriteLine($"그 때, {game.Player.Name} 은/는 나무 그늘에서 쉬고 있던 {game.Monster.Name} 한 마리를 발견한다."); 
            Thread.Sleep(2000);
            Console.WriteLine($"{game.Monster.Name}도 {game.Player.Name} 을/를 발견하고 화들짝 놀라며 전투태세를 취한다."); 
            Thread.Sleep(2000);
            Console.WriteLine($"{game.Player.Name} 은/는 싸울 생각이 없었지만, 덤벼드는 {game.Monster.Name}을 보고있을 수만은 없다.");
            Console.WriteLine();

            Console.WriteLine("어떻게 하시겠습니까?");
            Console.WriteLine("1. 마을로 도망친다");
            Console.WriteLine("2. 모른 척하고 후다닥 가던 길을 간다");
            Console.WriteLine($"3. {game.Monster.Name}과 싸운다");
            Console.WriteLine();

            Console.Write("원하는 행동의 번호를 입력해주세요: ");
        }

        // 값 입력
        public override void Input()
        {
            input = Console.ReadLine();
        }

        // 값 입력에 따른 업데이트
        public override void Update()
        {
            switch (input)
            {
                // case "1": 도망가기 -> 마을로 화면 전환
                case "1":
                    Console.WriteLine($"{game.Player.Name} 은/는 슬라임을 피해 빠르게 마을로 도망쳤습니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Town);
                    break;

                // case "2": 지나가기 -> 협곡으로 화면 전환
                case "2":
                    Console.WriteLine($"{game.Player.Name} 은/는 이 악물고 슬라임을 모른척 하며 후다닥 지나갔습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine($"슬라임을 지나쳐 걸은지 얼마나 됐을까...\n{game.Player.Name}의 눈 앞에 가파른 절벽이 펼쳐진 협곡이 보이기 시작한다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Canyon);
                    break;

                // case "3": 전투하기 -> 전투 화면으로 전환
                case "3":
                    Console.WriteLine($"{game.Player.Name} 은/는 자신을 경계하는 슬라임과의 전투를 준비한다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Battle);
                    break;
            }
        }
    }
}
