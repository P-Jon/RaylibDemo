﻿using PointDefence.Core.Data;
using Raylib_cs;

namespace PointDefence.Core
{
    public class GameManager
    {
        private PointDefenceGame GameLoop;

        private static void Main(string[] args)
        {
            new GameManager();
        }

        public GameManager()
        {
            SetupGameWindow();

            GameLoop = new PointDefenceGame();
        }

        private void SetupGameWindow()
        {
            Raylib.InitWindow(GameData.screenWidth, GameData.screenHeight, "Point Defence Game");
            Raylib.SetTargetFPS(60);
            Raylib.HideCursor();
            GameData.ImageData.SetWindowIcon();
        }
    }
}