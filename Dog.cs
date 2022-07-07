using System;
using System.Collections.Generic;
using System.Text;

namespace tezetema
{
    class Dog : Animal
    {
        public string name;
        public string color;
        public byte age;

        public Dog(string n, string c, byte a)
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
