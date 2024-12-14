using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsLesson
{
    internal class Ship
    {
        public int Length { get; set; }
        public bool IsHorizontal { get; set; }
        public List<Point> Positions { get; set; }
        public int Health { get; set; }
        public Ship(int length, bool isHorizontal)
        {
            Length = length;
            IsHorizontal = isHorizontal;
            Positions = new List<Point>();
            Health = length;
        }
    }
}
