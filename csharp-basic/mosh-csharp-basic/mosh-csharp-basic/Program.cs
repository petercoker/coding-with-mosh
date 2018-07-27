﻿using System;
using mosh_csharp_basic.primitive;
using mosh_csharp_basic.nonprimitive;
using mosh_csharp_basic.nonprimitive.classes;

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


            //CLASS *********
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



            //STUCT ********
            //StructPerson peter = new StructPerson(); //Non-Primitive needs to be give memory to it
            //peter.FirstName = "Peter";
            //peter.LastName = "Coker";
            //peter.Introduce();



            ////Method
            //StructCalculator calculator = new StructCalculator();
            //int result = calculator.Add(1, 2);
            //Console.WriteLine("Calculator result is: " + result);

            //int result = Calculator.Add(1, 2); //If you were to add the static Modifier

            //ENUMS*****************
            //ShippingMethod method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //int methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString()); //Console.WriteLine by default always call the ToString() method on any vaule to pass through it 
            //Console.WriteLine(method); //In case you're not convert using Console.WriteLine and what to explitly convert enum to a string than use the ToString() method

            //string methodName = "Enum";

            //ShippingMethod shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            //Vaule Types ****
            //int a = 10;
            //int b = a;
            //b++;
            //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            ////Reference Types ****
            //int[] array1 = new int[3] {1, 2, 3};
            //int[] array2 = array1;

            //array2[0] = 0;
            //Console.WriteLine(string.Format("array1[0]: {0}, array[0]: {1}", array1[0], array2[0]));

            int number = 1;
            Increment(number);
            Console.WriteLine(number);

            ReferenceType referenceType = new ReferenceType() {Age = 20};
            MakeOld(referenceType);
            Console.WriteLine(referenceType.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(ReferenceType referenceType)
        {
            referenceType.Age += 10;
        }

    }


}