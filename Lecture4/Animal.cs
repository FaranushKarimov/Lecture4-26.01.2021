using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Animal
    {
        // Атрибуты (поля), которые есть у всех животных
        // Модификаторы public могут быть напрямую изменены
        // после того, как объект был создан
        public string Name;
        public string Sound;

        // Конструктор устанавливает значения по умолчанию для
        // поля при создании объекта
        // Это конструктор по умолчанию, если нет
        // параметры будут отправлены
        public Animal()
        {
            Name = "No Name";
            Sound = "No Sound";
            numOfAnimals++;
        }

        // Вы можете создавать дополнительные конструкторы
        // но поскольку мы определяем вас по умолчанию
        // не обязательно
        public Animal(string name = "No Name")
        {
            // Имеется в виду название этого объекта
            // вместо имени, переданного в
            // конструктор
            this.Name = name;
            this.Sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name",
            string sound = "No Sound")
        {
            this.Name = name;
            this.Sound = sound;
            numOfAnimals++;
        }

        // Возможности (методы), которыми обладают все животные
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",
                Name, Sound);
        }

        // статические поля и методы принадлежат классу
        // Статическое поле имеет одинаковое значение для всех
        // объекты типа Animal
        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

        

    }
}
