namespace Inheritance8438
{
    internal class Program // interface'ler abstract (soyut, new'lenemez), class'lar concrete (somut, new'lenebilir)
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Çağıl",
                Surname = "Alsaç"
            };
            person.Display();
            Student student = new Student()
            {
                Department = "8438",
                Surname = "Uzun",
                Name = "Zahide"
            };
            student.Display();
            Person insan = new Customer()
            {
                CardNo = "**** 1234",
                Surname = "Anaç",
                Name = "Mehmet *"
            };
            person.Display();
            Console.WriteLine(((Customer)insan).CardNo); // casting: tip dönüşüm
            Console.WriteLine((insan as Customer).CardNo);

            Person[] people = new Person[3]
            {
                new Student()
                {
                    Department = "Yazılım",
                    Name = "Ali",
                    Surname = "Veli"
                },
                new Customer()
                {
                    CardNo = "1234",
                    Name = "Zeynep",
                    Surname = "Tan"
                },
                new ExtendedCustomer()
                {
                    Address = "Ankara",
                    CardNo = "9876",
                    Name = "Hüsnü",
                    Surname = "Dündar"
                }
            };
            foreach (Person p in people)
            {
                p.Display();
            }
            ExtendedCustomer extended = (people[2] as ExtendedCustomer);
            extended.Display();
            Console.WriteLine(extended.CardNo + " - " + extended.Address);
        }
    }

    class Person //: Object // base, parent
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }

    class Student : Person // sub, child
    {
        public string Department { get; set; }
    }

    class Customer : Person // is a relationship, // sub, child
    {
        public string CardNo { get; set; }
    }

    sealed class ExtendedCustomer : Customer, IAddress
    {
        public string Address { get; set; }
    }

    interface IAddress
    {
        string Address { get; set; }
    }
}