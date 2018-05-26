using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityPractise
{
    /// <summary>
    /// Класс представляющий контекст взаимодействия с базой данных
    /// </summary>
    class PersonContext : DbContext
    {
        /// <summary>
        /// Конструктор производного класса, вызывающий конструктор базового класса с указанием названия строки соединения
        /// с базой данных
        /// </summary>
        public PersonContext() : base("DefaultConnection")
        {

        }

        //Сущность пользователей в базе данных
        public DbSet<Person> Persons { get; set; }
    }
}
