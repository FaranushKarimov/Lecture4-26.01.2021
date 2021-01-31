using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Lecture4
{
    class Rectangle
    {
        
            //  Person person = new Person("Lola",25,1997,12);
            //  person.WriteNameWithUpperCase();
            //  person.WriteNameWithCustomWord("Mr. ");
            //  Person person1 = new Person("Chuck", 31, 1990,7);
            //  Person person2 = new Person("Norris", 6,2020,10);


            //  var person4 = new Person
            //  {
            //      Age = 20,
            //      YearOfBirth = 2020,
            //      Name = "Johny"
            //  };
            //  person.Name = "Chuck";
            //  person.Age = 4;
            //  person.YearOfBirth = 2017;

            //  person1.Name = "Bob";
            //  person1.Age = 23;
            //  person1.YearOfBirth = 1997;

            //var nameWithUpper = person2.GetNameWithUpperCase();

            //if(person2.GetNameWithUpperCase() == "")
            //{

            //}
            //  var nameWithCustomWord = person1.GetNam
            //  Console.WriteLine(nameWithUpper);

            //var (name, age) = person4;



            /*    Console.WriteLine($"Имя: {person.Name}\n" + $"Возраст: {person.Age}\n" + $"Год рождения: {person.YearOfBirth}");
                Console.WriteLine($"Имя: {person1.Name}\n" + $"Возраст: {person1.Age}\n" + $"Год рождения: {person1.YearOfBirth}");*/



            /*    var payment = new Payment {
                    Id = Guid.NewGuid(),
                    AmountOfPayment = 2000,
                    Currency = "Dollar"
                };

                Console.WriteLine($"Ключ {payment.Id}\n" + $"Сумма платежа {payment.AmountOfPayment}\n" + $"Тип валюты {payment.Currency}");
                Console.ReadLine();*/

        
    

    /*  class Payment
      {
          public Guid Id { get; set; }
          public string Currency { get; set; }
          public int AmountOfPayment { get; set; }

          public Payment(string currency, int amountofpayment)
          {
              Currency = currency;
              AmountOfPayment = amountofpayment;
          }

          public Payment(string currency)
          {
              Currency = currency;
          }

          public Payment()
          {

          }

      }*/

        public double side1, side2;
        public Rectangle (double side1, double side2) {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return Math.Round(side1 * side2, 3);
        }

        public double PerimeterCalculator()
        {
            return Math.Round(side1 + side2, 3);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimetr
        {
            get { return PerimeterCalculator(); }
        }
    }
    /*    class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int dayOfBirth { get; set; }
            public int yearOfBirth { get; set; }
            public int YearOfBirth { 
                get
                {
                    return yearOfBirth;
                }
                set {
                    if (value < (2021 - 100))
                    {
                       // Console.WriteLine("Год рождения не может быть 0");
                        throw new Exception($"Год рождения не может быть меньше {2021 - 100 }");
                    }
                    else
                    {
                        yearOfBirth = value;
                    }
                    YearOfBirth = value;
                }
            }
            public int MonthOfBirth { get; set; }

            public Person(string name,int age,int yearofbirth,int monthofbirth)
            {
                Name = name;
                Age = age;
                YearOfBirth = yearofbirth;
                MonthOfBirth = monthofbirth;
            }
            public void Deconstructor(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Person()
            {

            }

            /// <summary>
            /// Выводим на экран объекта большими буквами
            /// </summary>
            public void WriteNameWithUpperCase()
            {
                Console.WriteLine(this.Name.ToUpper());
            }
            /// <summary>
            /// Выводим на экран Имя с префиксом
            /// </summary>
            /// <param name="customWord"></param>
            public void WriteNameWithCustomWord(string customWord)
            {
                Console.WriteLine($"customWord {customWord} {this.Name}");
            }

            public string GetNameWithUpperCase()
            {
                var nameWithUpper = Name.ToUpper();
                return nameWithUpper;
            }
        }*/

    /*   public record Human
       {
           public string Name { get; set; }
           public int Age { get; set; }

       }*/

}

