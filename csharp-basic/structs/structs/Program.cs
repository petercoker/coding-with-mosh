
using System;
using structs.math;

namespace structs
{

    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person(); //Non-Primitive needs to be give memory to it
            peter.FirstName = "Peter";
            peter.LastName = "Coker";
            peter.Introduce();


            //Method
            //Method
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Console.WriteLine("Calculator result is: " + result);

            //int result = Calculator.Add(1, 2); //If you were to add the static Modifier
        }
    }
}
