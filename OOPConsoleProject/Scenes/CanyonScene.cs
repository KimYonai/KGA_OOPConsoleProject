﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class CanyonScene : Scene
    {
        private string input;

        public CanyonScene(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Loadind...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("Loadind...");
            Thread.Sleep(2000);
        }

        public override void Render()
        {
            
        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Update()
        {

        }
    }
}
