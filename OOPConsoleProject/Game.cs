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

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void Over()
        {
            isRunning = false;
        }

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

        private void End()
        {
            curScene.Exit();
        }

        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }
    }
}
