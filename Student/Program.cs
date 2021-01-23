using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Person lily = new Person("Lily", 20);
            Person bob = new Person("Bob", 20);

            Console.WriteLine("Name: " + lily.name + " Age: " + lily.age);
            Console.WriteLine("Name: " + bob.name + " Age: " + bob.age);
        }
    }
}
