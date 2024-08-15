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
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {

        }

        public override void Render()
        {
            
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Update()
        {

        }
    }
}
