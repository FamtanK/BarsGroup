using System;

namespace Task1
{
    public class Task1
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            char keyChar;
            while ((keyChar = Console.ReadKey().KeyChar) != 'c')
            {
                OnKeyPressed?.Invoke(this, keyChar);
            }
        }
    }
}