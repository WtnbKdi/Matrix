using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Cell
    {
        public ConsoleColor Color { get; set; }
        public char Character { get; set; }
        public Cell()
        {
            this.Color = ConsoleColor.Black;
            Character = ' ';
        }
        public Cell(ConsoleColor color)
        {
            this.Color = color;
            Character = RandomCharacter.Get();
        }
    }
}
