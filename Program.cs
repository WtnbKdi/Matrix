using System.Diagnostics;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int width = 120, height = 30;
            Field field = new Field(width, height);
            Matrix.Init(width, height, width, 4);
            int milliSecond = 100;
            int startTime = System.Environment.TickCount;
            while (true)
            {
                int stopTime = System.Environment.TickCount;
                if (stopTime - startTime <= milliSecond) continue;
                startTime = System.Environment.TickCount;
                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                Matrix.WriteField(field);
                Matrix.PrintField(field);
                Matrix.Update(field);
            }
        }
    }
}
