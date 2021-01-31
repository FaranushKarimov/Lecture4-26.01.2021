using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //************ Класс Треугольника ********************/ 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("----------------------Треугольник---------------------- ");

                Console.ForegroundColor = ConsoleColor.White;

                System.Console.Write(" Введите одну из сторон треугольника: ");
                double side1 = double.Parse(Console.ReadLine());

                System.Console.Write(" Введите одну из сторон треугольника: ");
                double side2 = double.Parse(Console.ReadLine());

                Rectangle rectangle1 = new Rectangle(side1, side2);

                System.Console.WriteLine($" Площадь тругольника равна {rectangle1.Area}");
                System.Console.WriteLine($" Периметр треугольника равен {rectangle1.Perimetr}");

            }

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------Книга------------------- : ");

                Console.ForegroundColor = ConsoleColor.White;

                string[] bookAuthors = { "Марк Твен", "Джек Лондон", "Даниэль Дефо" };
                string[] bookContents = { "Приключение Тома Сойера", "Белый клык", "Робинзон Крузо" };
                string[] bookTitles = { "C#", "WoW", "Papa" };

                Book[] books = new Book[3];

                for (int i = 0; i < books.Length; i++)
                {

                    int randAuthor = new Random().Next(0, bookAuthors.Length - 1);
                    int randTitle = new Random().Next(0, bookTitles.Length - 1);
                    int randContent = new Random().Next(0, bookContents.Length - 1);

                    books[i] = new Book(
                        bookAuthors[randAuthor],
                        bookTitles[randTitle],
                        bookContents[randContent]
                    );
                }

                for (int i = 0; i < books.Length; i++)
                {

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Book book = books[i];
                    System.Console.WriteLine($"Книги#{i + 1}:");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    System.Console.Write("\t");
                    book.showAuthor();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.Write("\t");
                    book.showTitle();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    System.Console.Write("\t");
                    book.showContent();


                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }
            {
                Converter firstSum = new Converter();
                System.Console.Write("Enter amount: ");
                double sum = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Choose currency:\n1. USD\t2. EUR\n3. RUB\t4. TJS");
                int choice = int.Parse(Console.ReadLine());
                firstSum.amount = sum;

                if (choice != 4)
                {
                    switch (choice)
                    {
                        case 1: firstSum.toTjs(firstSum.usd, firstSum.amount); break;
                        case 2: firstSum.toTjs(firstSum.eur, firstSum.amount); break;
                        case 3: firstSum.toTjs(firstSum.rub, firstSum.amount); break;
                    }
                }
                else
                {
                    System.Console.WriteLine("To which currancy do you want to convert your amount?");
                    System.Console.WriteLine("1. USD\n2. EUR\n3. RUB");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: firstSum.toUsd(firstSum.usd, firstSum.amount); break;
                        case 2: firstSum.toEur(firstSum.eur, firstSum.amount); break;
                        case 3: firstSum.toRub(firstSum.rub, firstSum.amount); break;
                    }
                }
                Console.ReadKey();

            }
            {
                Employee firstEmployee = new Employee();
                System.Console.Write("Enter employee name: ");
                firstEmployee.name = Console.ReadLine();
                System.Console.Write("Enter employee surname: ");
                firstEmployee.surname = Console.ReadLine();
                System.Console.WriteLine("choose his/her position:");
                System.Console.WriteLine("1. intern\t 2. junior\n3. middle\t 4. senior");
                int choicePost = int.Parse(Console.ReadLine());
                Console.WriteLine("choose his/her experience:");
                Console.WriteLine("1. 1 year\t 2. 2 year\n3. 3 year\t 4. 4 year");
                int choiceExperience = int.Parse(Console.ReadLine());
                Console.WriteLine("Information about employee:");
                Console.WriteLine($"Name: {firstEmployee.name}");
                Console.WriteLine($"Surname: {firstEmployee.surname}");
                Console.WriteLine($"Position: {firstEmployee.post[choicePost - 1]}");
                Console.WriteLine($"Salary: {firstEmployee.salary(choicePost, choiceExperience)}");
                Console.WriteLine($"Tax: {firstEmployee.tax(firstEmployee.salary(choicePost, choiceExperience))}");
                Console.ReadKey();

            }
            // Создать объект Animal
            // Вы также можете назначить такие значения, как
            // fox.name = "Red"
            Animal fox = new Animal()
            {
                Name = "Red",
                Sound = "Raaaw"
            };

            Bird colibri = new("Colibri", "Cipcip");
            Bird canary = new("Canary", "Aiaiai");

            Console.WriteLine("Record Type: ");
            Console.WriteLine($"To String:{colibri} ");
            Console.WriteLine($"Are the two objects equal: {Equals(colibri, canary)} ");
            Console.WriteLine($"Are the two objects ==: {colibri == canary}");


            Console.WriteLine("Class Type: ");
            Console.WriteLine($"To String:{fox}");

            // Вызов статического метода
            Console.WriteLine("# of Animals {0}",
                Animal.GetNumAnimals());


        }

        /// <summary>
        /// В основе классического объектно-ориентированного программирования лежит идея о том,
        /// что объект имеет сильную идентичность и инкапсулирует изменяемое состояние
        /// </summary>
        public record Bird(string Name, string Sound);


    }
}


