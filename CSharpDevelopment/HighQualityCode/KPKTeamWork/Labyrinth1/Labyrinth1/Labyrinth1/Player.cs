﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Player
    {
        private string name = string.Empty;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private int points = 0;
        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        private Position position = new Position(0, 0);
        public Position Position
        {
            get
            {
                return new Position(position.X, position.Y);
            }
            protected set
            {
                this.position = new Position(value.X, value.Y);
            }
        }

        public Player(Position position)
        {
            this.Position = position;
        }

        public bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    this.position.X -= 1;
                    break;
                case Direction.Up:
                    this.position.Y -= 1;
                    break;
                case Direction.Right:
                    this.position.X += 1;
                    break;
                case Direction.Down:
                    this.position.Y += 1;
                    break;
                default:
                    return false;
            }

            return true;
        }
    }
}
