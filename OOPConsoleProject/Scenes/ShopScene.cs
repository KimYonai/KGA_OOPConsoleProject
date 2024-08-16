using OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class ShopScene : Scene
    {
        private string input;
        private InventoryScene inven;
        private Item item;
        private Weapons weapon;
        private Armors armor;
        private Accs acc;
        private Consumes consume;

        public ShopScene(Game game) : base(game) { }

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
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("        [아이템 카테고리 선택]       ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 | 무기 아이템");
            Console.WriteLine("2 | 방어구 아이템");
            Console.WriteLine("3 | 장신구 아이템");
            Console.WriteLine("4 | 소비 아이템");
            Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
            Console.WriteLine("마을로 돌아가기: 0");
            Console.WriteLine();
            Console.Write("아이템 선택(0 ~ 4): ");
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    ShopWeapon();
                    Input();
                    WeaponPurchase();
                    break;

                case "2":
                    ShopArmor();
                    Input();

                    break;

                case "3":
                    ShopAcc();
                    Input();

                    break;

                case "4":
                    ShopConsume();
                    Input();

                    break;

                case "0":
                    game.ChangeScene(SceneType.Town);
                    break;

                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    Console.Write("원하는 카테고리를 숫자로 입력해주세요: ");
                    Input();
                    break;
            }
        }

       //public void AddItem()
       //{
       //    inven.inventory[inven.index] = item;
       //    inven.index++;
       //}

        public void ShopWeapon()
        {
            Console.Clear();
            Console.WriteLine("▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼▽▼");
            Console.WriteLine("             [무기 상점]            ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"1 | {"롱 소드"}: 200G");
            Console.WriteLine($"1 | {"고목 스태프"}: 200G0G");
            Console.WriteLine($"3 | {"사냥꾼의 활"}: 200G");
            Console.WriteLine($"4 | {"복수의 단검"}: 200G");
            Console.WriteLine($"5 | {"홀리 바이블"}: 200G");
            Console.WriteLine("▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲△▲");
            Console.WriteLine("뒤로 가기: 0");
            Console.WriteLine();
            Console.Write("아이템 선택(0 ~ 5): ");
        }

        public void WeaponPurchase()
        {
            
        }

        public void ShopArmor()
        {

        }

        public void ShopAcc()
        {

        }

        public void ShopConsume()
        {

        }
    }
}
