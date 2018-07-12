
using System;
using classes.math;

namespace classes
{
    //public class Person
    //{
    //    public string FirstName;
    //    public string LastName;

    //    public void Introduce()
    //    {
    //        //Console.WriteLine("My name is " + FirstName + " " + LastName );
    //        Console.WriteLine("My name is {0} {1}", FirstName, LastName);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person(); //Non-Primitive needs to be give memory to it
            peter.FirstName = "Peter";
            peter.LastName = "Coker";
            peter.Introduce();


            //var peter = new Person //Simplified verison of declaring an instance
            //{
            //    FirstName = "Peter",
            //    LastName = "Coker"
            //}; 
            //peter.Introduce();

            Person scott = new Person
            {
                FirstName = "scott",
                LastName = "Brown"
            };

            scott.Introduce();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Console.WriteLine("Calculator result is: " + result);

            //int result = Calculator.Add(1, 2); //If you were to add the static Modifier
        }
    }
}
