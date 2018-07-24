using System;
using mosh_csharp_basic.primitive;
using mosh_csharp_basic.nonprimitive;

namespace mosh_csharp_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld outPutHelloWorld = new HelloWorld();
            //outPutHelloWorld.CSharpHelloWorld();

            //Operators outPutOperators = new Operators();
            //outPutOperators.CSharpoperator();

            //Type_conversions outPutType_conversions = new Type_conversions();
            //outPutType_conversions.CSharpTypeConversions();

            //Variables_and_constants outPutVariables_and_constants = new Variables_and_constants();
            //outPutVariables_and_constants.CSharpVaribaleAndConstants();

            //CSharpString ouPutCSharpString = new CSharpString();
            //ouPutCSharpString.CSharpStrings();

            //CSharpArrays outPutCSharpArrays = new CSharpArrays();
            //outPutCSharpArrays.CSharpArray();

            //Created objects
            //Person peter = new Person(); //Non-Primitive needs to be give memory to it
            //peter.FirstName = "Peter";
            //peter.LastName = "Coker";
            //peter.Introduce();


            ////var peter = new Person //Simplified verison of declaring an instance
            ////{
            ////    FirstName = "Peter",
            ////    LastName = "Coker"
            ////}; 
            ////peter.Introduce();

            //Person scott = new Person
            //{
            //    FirstName = "scott",
            //    LastName = "Brown"
            //};

            //scott.Introduce();

            ////Method
            //Calculator calculator = new Calculator();
            //int result = calculator.Add(1, 2);
            //Console.WriteLine("Calculator result is: " + result);

            ////int result = Calculator.Add(1, 2); //If you were to add the static Modifier

            StructPerson peter = new StructPerson(); //Non-Primitive needs to be give memory to it
            peter.FirstName = "Peter";
            peter.LastName = "Coker";
            peter.Introduce();



            //Method
            StructCalculator calculator = new StructCalculator();
            int result = calculator.Add(1, 2);
            Console.WriteLine("Calculator result is: " + result);

            //int result = Calculator.Add(1, 2); //If you were to add the static Modifier



        }
    }

   
}
