﻿using PointDefence.Core.Models;
using PointDefence.Enemies.Models;
using Raylib_cs;
using System.Numerics;

namespace PointDefence.Enemies
{
    public class EnemySpawnManager : ManagerObject<Missile>
    {
        private int maxEnemies;
        private double time;

        public EnemySpawnManager(int maxEnemies)
        {
            this.maxEnemies = maxEnemies;
            time = Raylib.GetTime();
        }

        public override void update()
        {
            UpdateMissiles();

            InstantiateMissile();

            RemoveFromObjectList();
        }

        public override void draw()
        {
            DrawMissiles();
        }

        public void InstantiateMissile()
        {   // This will get progressively harder, but is a good POC for now.
            if (!(ObjectList.Count >= maxEnemies) && Raylib.GetTime() >= time + 1.5f)
            {
                ObjectList.Add(new EnemyMissile());
                time = Raylib.GetTime();
            }
        }

        private void UpdateMissiles()
        {
            ObjectList.ForEach(x => x.update());
        }

        private void DrawMissiles()
        {
            ObjectList.ForEach(x => x.draw());
        }

        public void CheckCollision(Vector2 circleCenter, int radius)
        {
            ObjectList.ForEach(x => x.CheckCollision(circleCenter, radius));
        }
    }
}