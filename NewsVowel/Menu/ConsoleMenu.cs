using NewsVowel.Models;

namespace NewsVowel.Menu
{
    /// <summary>
    /// Меню приложения
    /// </summary>
    public class ConsoleMenu
    {
        public static void Run(Action<InputUser> inner)
        {
            do
            {
                Console.WriteLine("Введите тему (по умолчанию космос):");
                var topic = Console.ReadLine();

                string key;
                do
                {
                    Console.WriteLine("Введите ключ ап:");
                    key = Console.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(key));

                //TODO: валидация
                inner?.Invoke(new InputUser { Topic = topic, KeyApi = key });
            }
            while (true);
        }
    }
}
