using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    static class Matrix
    {
        static Random random = new Random();
        static int _width, _height;
        static List<Rains> _rains = new List<Rains>();
        public static void Init(int width, int height, int rainNum, int rainLength)
        {
            _width = width;
            _height = height;
            for (int x = 0; x < rainNum; x++)
            {
                int randomY = random.Next(0, _height - 1);
                _rains.Add(new Rains(x, randomY, rainLength));
            }
        }

        static void write(Field field)
        {
            foreach (Rains rains in _rains)
            {
                foreach (Rain rain in rains)
                {
                    if (isOutOfRange(rain.X, 0, _width)
                        || isOutOfRange(rain.Y, 0, _height)) continue;
                    field[rain.X, rain.Y].Character = rain.Character;
                    field[rain.X, rain.Y].Color = rain.Color;
                }
            }
        }

        public static void WriteField(Field field)
        {
            for (int y = 0; y < _height; y++)
                for (int x = 0; x < _width; x++)
                    write(field);
        }

        public static void PrintField(Field field)
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    Console.ForegroundColor = field[x, y].Color;
                    Console.Write(field[x, y].Character);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        public static void Update(Field field)
        {
            for (int index = 0; index < _rains.Count; index++)
            {
                for (int rainIndex = 0; rainIndex < _rains[rainIndex].Length; rainIndex++)
                {
                    int clearPoint = _rains[index][_rains[index].Length - 1].Y - 1;
                    if (!isOutOfRange(clearPoint, 0, _height))
                        field[index, clearPoint].Character = ' ';
                    _rains[index][rainIndex].Y++;
                    _rains[index][rainIndex].Character = RandomCharacter.Get();
                    if (_rains[index][rainIndex].Y == field.Height + 1)
                        _rains[index][rainIndex].Y = 0;
                }
            }
        }

        static bool isOutOfRange(int point, int min, int max)
        {
            return !(min <= point && point < max);
        }
    }

}
