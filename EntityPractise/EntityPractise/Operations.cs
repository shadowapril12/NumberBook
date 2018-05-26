using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPractise
{
    /// <summary>
    /// Класс опсывающий операции взаимодействия с базой данных
    /// </summary>
    class Operations
    {
        /// <summary>
        /// Метод удаления записи из таблицы Persons
        /// </summary>
        public static void DeletePerson()
        {
            //Идентификатор удаляемой записи
            int delId;

            Console.WriteLine("Введите индекс удаляемого элемента");

            //Присваивания значения delID
            delId = Convert.ToInt32(Console.ReadLine());

            try
            {
                using (PersonContext db = new PersonContext())
                {
                    //Получение записи по идентификатору
                    Person p = db.Persons.Where(g => g.Id == delId).FirstOrDefault();

                    //Удаление записи
                    db.Persons.Remove(p);

                    //Сохранение изменений
                    db.SaveChanges();
                }
            }
            catch(ArgumentException arg)
            {
                //В случае возникновения исключений выводиться надпись
                Console.WriteLine($"Неверно задан индекс {arg.Message}");
            }
            
                
        }

        /// <summary>
        /// Метод добавления записи в таблицу
        /// </summary>
        public static void AddPerson()
        {
            //Создание экземпляра класса Person
            Person p = new Person();

            //Присваивание значения свойству Name
            Console.WriteLine("Введите имя");
            p.Name = Console.ReadLine();

            //Присваивание значения свойству Number
            Console.WriteLine("Введите номер телефона");
            p.Number = Console.ReadLine();

            //Взаимодействие с базой данных
            using (PersonContext db = new PersonContext())
            {
                //Добавление записи в таблицу
                db.Persons.Add(p);

                //Сохранение изменений
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Метод редактирования записи в таблице
        /// </summary>
        public static void ChangePerson()
        {
            //Идентификатор изменяемой записи
            int changeId;

            Console.WriteLine("Введите индекс элемента, который вы хотите изменить");

            //Присваивание значения изменяемой записи
            changeId = Convert.ToInt32(Console.ReadLine());

            //Взаимодействие с базой данных
            using (PersonContext db = new PersonContext())
            {
                //Получение записи с указанным идентификатором
                Person person = db.Persons.Where(p => p.Id == changeId).FirstOrDefault();

                Console.WriteLine("Введите имя");

                //Присвоение значения свойству Name
                person.Name = Console.ReadLine();
                string name = person.Name;
                
                Console.WriteLine("Введите номер телефона");

                //Присвоение значения свойству Number
                person.Number = Console.ReadLine();
                string number = person.Number;

                //Сохранение изменений
                db.SaveChanges();
                
            }
        }
    }
}
