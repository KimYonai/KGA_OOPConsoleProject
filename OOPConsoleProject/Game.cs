using OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Game
    {
        // Game 클래스 인자값
        private bool isRunning;

        private Scene[] scenes;
        private Scene curScene;
        public Scene CurScene { get { return curScene; } }

        private Player player;
        public Player Player { get { return player; } set { player = value; } }

        private Monster monster;
        public Monster Monster { get { return monster; } set { monster = value; } }

        private Item item;
        public Item Item { get { return item; } set { item = value; } }

        // 게임 구동 과정 함수(메서드)
        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        // 게임 내 화면 전환 함수(메서드)
        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        // 게임 종료 함수
        public void Over()
        {
            isRunning = false;
        }

        // 게임 시작 함수
        private void Start()
        {
            isRunning = true;

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Town] = new TownScene(this);
            scenes[(int)SceneType.Shop] = new ShopScene(this);
            scenes[(int)SceneType.Church] = new ChurchScene(this);
            scenes[(int)SceneType.Home] = new HomeScene(this);
            scenes[(int)SceneType.Forest] = new ForestScene(this);
            scenes[(int)SceneType.Canyon] = new CanyonScene(this);
            scenes[(int)SceneType.Battle] = new BattleScene(this);
            scenes[(int)SceneType.Inventory] = new InventoryScene(this);
            scenes[(int)SceneType.GameOver] = new GameOverScene(this);



            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();
        }

        // Scene 종료 함수
        private void End()
        {
            curScene.Exit();
        }

        // Scene에 출력될 내용 렌더링 전용 함수
        private void Render()
        {
            curScene.Render();
        }

        // Scene에서 필요한 값 입력 함수
        private void Input()
        {
            curScene.Input();
        }

        // Input에서 입력한 값에 의한 상황 업데이트 함수
        private void Update()
        {
            curScene.Update();
        }
    }
}
