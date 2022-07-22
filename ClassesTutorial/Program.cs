﻿namespace Classes
{
    public class Person
    {
        public string Name { get; set; }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            var person = Person.Parse("John");
            //person.Name = "John";
            person.Introduce("Mosh");
        }
    }
}