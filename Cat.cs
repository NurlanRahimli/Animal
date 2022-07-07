using System;
using System.Collections.Generic;
using System.Text;


namespace tezetema
{
    public class Cat 
    {
        public string name;
        public string color;
        public byte age;

        public Cat(string n, string c, byte a)
        {
            name = n;
            color = c;
            age = a;

            Console.WriteLine("Custom construktor worked");
        }


        public string GetDetails()
        {
            return $"{name} {color} {age}";
        }
    }
}










