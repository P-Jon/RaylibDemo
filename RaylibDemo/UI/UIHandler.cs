﻿using PointDefence.Core.Data;
using PointDefence.UI.Components;
using Raylib_cs;
using System.Collections.Generic;

namespace PointDefence.UI
{
    public class UIHandler
    {
        private List<Button> buttons = new List<Button>
        {
            new Button("New Game", new Rectangle(300,200,100,60), 40, new Color(0,0,0,255), new Color(50,168,82,255)),
            new Button("Settings", new Rectangle(300,300,100,60), 40, new Color(0,0,0,255), new Color(50,168,82,255)),
            new Button("Exit", new Rectangle(300,400,100,60), 40, new Color(0,0,0,255), new Color(50,168,82,255)),
        };

        private HUD headsUpDisplay;

        public UIHandler()
        {
            headsUpDisplay = new HUD();
        }

        public void UpdateUI()
        {
            headsUpDisplay.update();
        }

        public void DrawUI()
        {
            if (GameData.InGameLoop)
                RenderTitleScreen();

            if (GameData.Gameover)
                DisplayGameover();

            headsUpDisplay.draw();
        }

        private void DisplayGameover()
        {
            var halfTextMeasure = (Raylib.MeasureText("Game Over", 64) / 2);
            Raylib.DrawText("Game Over", (GameData.ScreenWidth / 2) - halfTextMeasure, (GameData.ScreenHeight / 2) - halfTextMeasure, 64, Color.WHITE);
            Raylib.DrawText("Press Spacebar to Restart", (GameData.ScreenWidth / 2) - (Raylib.MeasureText("Press Spacebar to Restart", 32) / 2), (GameData.ScreenHeight / 2), 32, Color.WHITE);
        }

        private void RenderTitleScreen()
        {
            RenderButtons();
        }

        private void RenderButtons()
        {
            buttons.ForEach(x => x.draw());
        }
    }
}