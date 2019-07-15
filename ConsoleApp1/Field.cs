using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Field
    {
        public string[] CultureType { get; set; }
        public void FillTheField(int numberOfField)
        {
             CultureType = new string[numberOfField];
            for (int i = 0; i < numberOfField; i++)
            {
                Console.Write("Выберите кльтуры для {0}: ",i+1);
                CultureType[i] = Console.ReadLine();
            }
        }

        public void CreateTheField(string country,int numberOfField)
        {
            FillTheField(numberOfField);
            Console.Write("Вы создали {0} поле в {1} с культурами: ", numberOfField, country);
            for (int i = 0; i < numberOfField; i++)
            {
                Console.Write("{0}." + CultureType[i] + "\t", i + 1);
            }
            SetTheWatering(numberOfField);
        }
        public void SetTheWatering(int numberOfField)
        {
            for (int i = 0; i < numberOfField; i++)
            {
                Console.WriteLine("\nВыберите поле (выберите номер поле):");
                int.TryParse(Console.ReadLine(), out int fieldNumber);
                if ((i + 1) == fieldNumber)
                {
                    Console.WriteLine("Выберите время начало полива: ");
                    string userInput = Console.ReadLine();
                    DateTime.TryParse(userInput, out DateTime result);
                    //string timeWatering = result.ToString(result,"HH:MM");
                    Console.WriteLine(result);
                    Console.WriteLine("Выберите количество раз полива в неделю: ");
                    int.TryParse(Console.ReadLine(), out int numberInWeek);
                }
            }
        }
        public void EditField(int numberOfField)
        {
            //Console.Write("Выберите количество полей: ");
            //numberOfField = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfField; i++)
            {
                Console.WriteLine(CultureType[i]);
            }
        }
    }
}
