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
        private Player player;
        private Monster monster;
        public BattleScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("==========Battle Start!==========");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine($"{player.name} 은/는 {monster.name}과 전투를 시작한다.");
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("============Battle End============");
            Thread.Sleep(2000);
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            
            Console.WriteLine("행동을 선택해주세요.");
            Console.WriteLine("1. 공격한다(일반 공격)");
            Console.WriteLine("2. 공격한다(스킬 사용)");
            Console.WriteLine("3. 도망간다");
            Console.Write("선택할 행동: ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    monster.TakeDamage(player);
                    if (monster.curHP <= 0)
                    {
                        monster.Die();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"공격을 받은 {monster.name} 이/가 반격합니다.");
                        player.TakeDamage(monster);
                        if (player.curHP <= 0)
                        {
                            player.Die();
                            game.ChangeScene(SceneType.Home);
                        }
                    }                    
                    break;

                case "2":
                    Console.Clear();
                    player.Skill(monster);
                    if (monster.curHP <= 0)
                    {
                        monster.Die();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"공격을 받은 {monster.name} 이/가 반격합니다.");
                        player.TakeDamage(monster);
                        if (player.curHP <= 0)
                        {
                            player.Die();
                            game.ChangeScene(SceneType.Home);
                        }
                    }
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine($"{player.name} 은/는 겁에 질려 도망갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Home);
                    break;
            }
        }
    }
}
