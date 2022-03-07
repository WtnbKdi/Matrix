using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Rains
    {
        public int Length { get; private set; }
        List<Rain> _rains = new List<Rain>();
        public Rains() { }
        public Rains(int x, int y, int length)
        {
            this.Length = length;
            for (int i = 0; i < length; i++) _rains.Add(new Rain(x, y--, ConsoleColor.DarkGreen));
        }

        public Rain this[int x]
        {
            get { return _rains[x]; }
            set { _rains[x] = value; }
        }

        public IEnumerator<Rain> GetEnumerator()
        {
            return _rains.GetEnumerator();
        }
    }
}
