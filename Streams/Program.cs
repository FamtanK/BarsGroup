using System;
using System.Collections.Generic;

namespace Streams
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите текст запроса для отправки. Для выхода введите /exit");
                string message = Console.ReadLine();
                if (message == "/exit")
                {
                    break;
                }
                Console.WriteLine($"Будет послано сообщение '{message}'");

                string[] args = GetArgs();
                string id = Guid.NewGuid().ToString("D");

                ThreadPool.QueueUserWorkItem(callBack => StartingHandleRequest(message, args, id));
                Console.WriteLine($"Было отправлено сообщение '{message}'. Присвоен идентификатор {id}");
            }
            Console.WriteLine("Приложение завершает работу.");
        }

        static void StartHandleRequest(string message, string[] args, string id)
        {
            var ecz = new DummyRequestHandler();
            try
            {
                string res = ecz.HandleRequest(message, args);
                Console.WriteLine($"Сообщение с идентификатором {id} получило ответ: {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сообщение с идентификатором {id} упало с ошибкой: {ex.Message}");
            }
        }

        static string[] GetArgs()
        {
            var args = new List<string>();
            while (true)
            {
                Console.WriteLine("Введите аргументы сообщения. Если аргументы не нужны - введите /end");
                var arg = Console.ReadLine();
                if (arg == "/end")
                {
                    break;
                }
                args.Add(arg);
            }
            return args.ToArray();
        }
    }
}
