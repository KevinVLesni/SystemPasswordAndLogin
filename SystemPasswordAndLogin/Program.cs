using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPasswordAndLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "123qwe";
            string UserInput;

            Console.Write("Введите ваш пароль:");

            UserInput = Console.ReadLine();

            if(UserInput == password)
            {
                Console.WriteLine("Пароль принят. Доступ к базе данных разрешён.");
            }
            else
            {
                Console.WriteLine("ОШИБКА: Пароль некорректен! Доступ закрыт.");
            }
            Console.Read();
        }
    }
}
