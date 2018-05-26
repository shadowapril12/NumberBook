using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPractise
{
    /// <summary>
    /// Класс представляющий запись о человеке в телефонной книге
    /// </summary>
    class Person
    {
        //Идентификатор человека в базе данных
        public int Id { get; set; }

        //Имя
        public string Name { get; set; }

        //Номер телефона
        public string Number { get; set; }      
    }
}
