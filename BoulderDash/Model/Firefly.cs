﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Controller;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model
{
    public class Firefly : Character, IMovable, IExplodable
    {
        private Direction CurrentDirection { get; set; }

        public override string ToString()
        {
            return "F";
        }

        public void Explode()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            var left = CurrentDirection.Previous();
            while (true)
            {
                CurrentDirection = left;
                switch (left)
                {
                    case Direction.Up:
                        if (Node.Top.Data == null || Node.Top.Data is Rockford)
                        {
                            MoveUp();
                            return;
                        } 
                        break;
                    case Direction.Right:
                        if (Node.Right.Data == null || Node.Right.Data is Rockford)
                        {
                            MoveRight();
                            return;
                        }
                        break;
                    case Direction.Down:
                        if (Node.Bottom.Data == null || Node.Bottom.Data is Rockford)
                        {
                            MoveDown();
                            return;
                        }
                        break;
                    case Direction.Left:
                        if (Node.Left.Data == null || Node.Left.Data is Rockford)
                        {
                            MoveLeft();
                            return;
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                left = left.Next();
            }
        }

    }
}
