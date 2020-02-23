﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Space_Invaders.Model
{
    class Shot
    {
        public const double ShotPixelsPerSecond = 100;
        public Point Location { get; private set; }
        public Size ShotSize = new Size(2, 10);
        public Direction Direction { get; private set; }
        public bool PlayerShot { get; private set; }

        private DateTime _lastMoved;

        public Shot(Point location, Direction direction, bool playerShot)
        {
            Location = location;
            Direction = direction;
            _lastMoved = DateTime.Now;
            PlayerShot = playerShot;
        }

        public void Move()
         {
            TimeSpan timeSinceLastMoved = DateTime.Now - _lastMoved;
            double distance = timeSinceLastMoved.Milliseconds * ShotPixelsPerSecond / 1000;
            if (Direction == Direction.Up) distance *= -1;
            Location = new Point(Location.X, Location.Y + distance);
            _lastMoved = DateTime.Now;
        }
    }
}
