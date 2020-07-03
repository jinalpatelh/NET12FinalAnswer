using Microsoft.VisualBasic;
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult _adult = new Adult { firstname = "John", lastname = "Reibero" };
            Child _child = new Child { firstname = "Lynda", lastname = "Rose" };
            Person[] personarray = new Person[] { new Adult(), new Child() };
            foreach(Person p in personarray)
            {
                p.Print();
            }
        }


        public abstract class Person
        {
            public  abstract string firstname { get; set; }
            public abstract lastname { get; set; }

            public virtual void Print()
            {
                Console.WriteLine($" Name of the Peson is : {this.firstname} {this.lastname} ");
            }

        }
        public class Adult : Person
        {
            public override void Print()
            {
                base.Print();
                //Console.WriteLine($"Name of the Adult is : {firstname} {lastname}");
            }
        }

        public class Child : Person
        {
            public override void Print()
            {
                Console.WriteLine($"Name of the Child is: {firstname} {lastname}");
            }
        }

    }
}
