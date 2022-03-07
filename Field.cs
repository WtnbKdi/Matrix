using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Field
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        Cell[] _field;
        public Field()
        {
            _field = new Cell[0];
        }
        public Field(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            _field = new Cell[width * height];
            for (int i = 0; i < _field.Length; i++) _field[i] = new Cell();
        }
        public Cell this[int x, int y]
        {
            get { return _field[(Width * y) + x]; }
            set { _field[(Width * y) + x] = value; }
        }
    }
}
