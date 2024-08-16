using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class BattleScene : Scene
    {
        private string input;

        public BattleScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("==========Battle Start!==========");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine($"{game.Player.Name} 은/는 {game.Monster.Name}과 전투를 시작한다.");
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("============Battle End============");
            Thread.Sleep(2000);
        }

        public override void Render()
        {  
            Console.WriteLine("행동을 선택해주세요.");
            Console.WriteLine("1. 공격한다(일반 공격)");
            Console.WriteLine("2. 공격한다(스킬 사용)");
            Console.WriteLine("3. 도망간다");
            Console.WriteLine();
            Console.Write("선택할 행동: ");
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {
            Console.Clear();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    game.Player.AttackMonster(game.Monster);
                    game.Monster.TakeDamage(game.Player);
                    if (game.Monster.CurHP <= 0)
                    {
                        game.Monster.Die();

                        if (game.Monster.Place == SceneType.Forest)
                        {
                            game.ChangeScene(SceneType.Forest);
                        }
                        else if (game.Monster.Place == SceneType.Canyon)
                        {
                            game.ChangeScene(SceneType.Canyon);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"공격을 받은 {game.Monster.Name} 이/가 반격합니다.");
                        game.Player.TakeDamage(game.Monster);
                        if (game.Player.CurHP <= 0)
                        {
                            game.Player.Die();
                            // 이 자리에 GameOverScene 넣기
                            game.ChangeScene(SceneType.Home);
                        }
                        else
                        {
                            Render();
                        }
                    }                    
                    break;

                case "2":
                    Console.Clear();
                    game.Player.Skill(game.Monster);
                    game.Monster.TakeDamage(game.Player);
                    game.Player.AfterSkill();
                    if (game.Monster.CurHP <= 0)
                    {
                        game.Monster.Die();

                        if (game.Monster.Place == SceneType.Forest)
                        {
                            game.ChangeScene(SceneType.Forest);
                        }
                        else if (game.Monster.Place == SceneType.Canyon)
                        {
                            game.ChangeScene(SceneType.Canyon);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        game.Monster.AttackPlayer(game.Player);
                        game.Player.TakeDamage(game.Monster);
                        if (game.Player.CurHP <= 0)
                        {
                            game.Player.Die();
                            // 이 자리에 GameOverScene 넣기
                            game.ChangeScene(SceneType.Home);
                        }
                        else
                        {
                            Render();
                        }
                    }
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine($"{game.Player.Name} 은/는 겁에 질려 도망갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Home);
                    break;
            }
        }
    }
}
