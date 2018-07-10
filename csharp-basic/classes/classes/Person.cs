using System;

namespace classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            //Console.WriteLine("My name is " + FirstName + " " + LastName );
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }
}
