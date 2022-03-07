using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Rain
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; }
        public char Character { get; set; }
        public Rain() { }
        public Rain(int x, int y, ConsoleColor color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            this.Character = RandomCharacter.Get();
        }
    }
}
