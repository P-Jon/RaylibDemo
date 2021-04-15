﻿using PointDefence.Assets;
using PointDefence.Audio;
using PointDefence.Enemies;
using PointDefence.Player;
using System.IO;

namespace PointDefence.Core.Data
{
    public class GameData
    {
        public const int ScreenWidth = 1280;
        public const int ScreenHeight = 720;

        public static bool InGameLoop = false;
        public static bool Gameover = false;
        public static bool QuitGame = false;
        public static string localDir = Directory.GetCurrentDirectory() + "/../../../";

        public static EnemySpawnManager EnemyManager = new EnemySpawnManager(30);
        public static AlliedMissileManager AlliedMissileManager = new AlliedMissileManager();

        public static ExplosionManager ExplosionManager = new ExplosionManager();
        public static ImageData ImageData = new ImageData();
        public static AudioManager AudioManager = new AudioManager();
    }
}