using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

                Console.WriteLine("Для добавления пользователя нажмите 'A'. Для удаления элемента нажмите 'D'" +
                    "Для редактирования элемента нажмите 'U'.");

                //Считывание нажатой клавиши
                ConsoleKeyInfo button = Console.ReadKey(true);

                switch (button.Key)
                {
                    //В случае нажатия кнопки 'A'
                    case ConsoleKey.A:
                        //Запускается метод добавления записи в базу данных
                        Operations.AddPerson();        
                        break;
                    case ConsoleKey.D:
                        //В случае нажатия клавиши 'D' запускается метод удаления записи из базы данных
                        Operations.DeletePerson();
                        break;
                    case ConsoleKey.U:
                        //В случае нажатия клавиши 'U' запускается метод редактирования записи в таблице базы данных
                        Operations.ChangePerson();
                        break;
                    default:
                        //В остальных случаях выводится сообщение
                        Console.WriteLine("Неверная клавиша");
                        break;
                }

                //Взаимодействие с базой данных
                using (PersonContext db = new PersonContext())
                {
                    //Получение записей таблицы Persons
                    var people = db.Persons;
                    Console.WriteLine($"\n***Список элементов в базе данных***");

                    //Вывод записей
                    foreach (Person p in people)
                    {
                        Console.WriteLine($"{p.Id} - {p.Name} - {p.Number}");
                    }
                    Console.WriteLine("****\n");
                }
                    
            }        
            
        }
    }
}
