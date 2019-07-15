using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Clear();
                WriteLine("1.Создавать\n2.Редактировать\n3.Искать\n4.Удалить");
                WriteLine("Выберите действие: ");
                int.TryParse(Console.ReadLine(),out int action);
                Field obj = new Field();
                int numberOfField;
                if (action == 1)
                {
                    Console.Write("Выберите страну для вашей культуры: ");
                    string country = Console.ReadLine();
                    Console.Write("Выберите количество полей: ");
                    int.TryParse(Console.ReadLine(),out numberOfField);
                    obj.CreateTheField(country,numberOfField);
                }
                if (action == 2)
                {
                    obj.EditField(numberOfField);
                }
                ReadKey();
            }
        }
    }
}
