using System;

namespace AbstractClass
{
    
    class Program
    {
        //==== simple program===
        abstract class Animal
        {
            public abstract void eat();
            public void sound()
            {
               
                Console.WriteLine("\t           \t              \tdog says boww boww");
            }
        }
        class Dog : Animal
        {
            public override void eat()
            {
                Console.WriteLine("\t           \t              \tdog can eat");
            }

        }

        class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("\t            ===================================================================================");
            Console.WriteLine("\t                  \t**==========Abstraction class======**");
            Console.WriteLine();
            Dog d = new Dog();
            Animal thepet = d;
            thepet.eat();
            d.sound();
            Console.WriteLine();
            Console.WriteLine("\t            ===================================================================================");
            Console.WriteLine();
            Console.WriteLine("\t                \t**==========Encapsulation============**");
            Console.WriteLine();
            Student s = new Student();
            s.ID = "001";
            s.Name = "Pooja";
            s.Email = "poojalandage22@gmail.com";
            Console.WriteLine("\t           \t              \tRoll no = "+s.ID);
            Console.WriteLine("\t           \t              \tName = " + s.Name);
            Console.WriteLine("\t           \t              \tEmail = " + s.Email);
            Console.WriteLine();
            Console.WriteLine("\t            ===================================================================================");
        }
    }
}
