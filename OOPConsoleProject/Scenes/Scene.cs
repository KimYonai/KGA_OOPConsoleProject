using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    // 게임 내 화면 부모 클래스
    public abstract class Scene
    {
        protected Game game;
        protected Player player;

        public Scene(Game game) { this.game = game; }
        public Scene(Player player) { this.player = player; }

        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Exit();
    }
}
