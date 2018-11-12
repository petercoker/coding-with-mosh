using System;

namespace mosh_csharp_intermediate.Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Birthdate = new DateTime(1982, 1, 1);
        }
    }
}
