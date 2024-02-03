using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() override - Practice

            Person person1 = new Person("Jun", "Calupcupan");

            Console.WriteLine(person1);
            Console.ReadKey();
        }
    }

    class Person
    {
        string name;
        string lastName;

        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            string message = $"hello {name} {lastName}";
            return message;
        }
    }
}