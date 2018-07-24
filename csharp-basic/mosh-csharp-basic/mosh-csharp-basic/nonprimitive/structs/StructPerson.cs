using System;

namespace mosh_csharp_basic
{
    public class StructPerson
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
