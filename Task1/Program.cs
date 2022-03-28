using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task = new Task1();
            task.OnKeyPressed += Print;
            task.Run();
        }

        public static void Print(object sender, char keyChar)
        {
            Console.WriteLine(keyChar);
        }
    }
}