using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class RandomCharacter
    {
        static Random _random = new Random();

        // Ascii文字の!から~までの文字を返す
        public static char Get()
        {
            return (char)_random.Next(33, 126);
        }
    }
}
