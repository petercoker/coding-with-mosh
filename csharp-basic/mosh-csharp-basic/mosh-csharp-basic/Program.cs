using System;
using System.Collections.Generic;
using mosh_csharp_basic.primitive;
using mosh_csharp_basic.nonprimitive;
using mosh_csharp_basic.nonprimitive.classes;
using mosh_csharp_basic.control_flow;
using mosh_csharp_basic.control_flow.condition_exercises;
using mosh_csharp_basic.control_flow.Iteration_statements;
using mosh_csharp_basic.arrys_and_lists;
using mosh_csharp_basic.working_with_dates;
using mosh_csharp_basic.working_with_text;
using mosh_csharp_basic.working_with_text.exercise_with_working_with_text;

namespace mosh_csharp_basic
{
    class Program
    {
        //public static void Increment(int number)
        //{
        //    number += 10;
        //}

        //public static void MakeOld(ReferenceType referenceType)
        //{
        //    referenceType.Age += 10;
        //}

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

            //int number = 1;
            //Increment(number);
            //Console.WriteLine(number);

            //ReferenceType referenceType = new ReferenceType() {Age = 20};
            //MakeOld(referenceType);
            //Console.WriteLine(referenceType.Age);

            //Conditional Statements *********
            //conditional_statements condition = new conditional_statements();
            //condition.IfCondition();
            //condition.ConditionOperator();

            //var season = Season.Autumn;
            //switch (season)
            //{
            //    //case Season.Autumn:
            //    //    Console.WriteLine("It's autumn and a beautiful season.");
            //    //    break;

            //    //case Season.Summer:
            //    //    Console.WriteLine("It's perfect to go to beach");
            //    //    break;

            //    case Season.Autumn:
            //    case Season.Summer:
            //        Console.WriteLine("We've got promotion");
            //        break;
            //    default:
            //        Console.WriteLine("I don't understand that season");
            //        break;
            //}

            //conditional_exercises exercise = new conditional_exercises();
            //exercise.Exercise1();
            //exercise.Exercise2();
            //exercise.Exercise3();
            //exercise.Exercise4();

            //forloop forloop = new forloop();
            //forloop.ForLoop();

            //foreachloop forEachLoop = new foreachloop();
            //forEachLoop.ForEachLoop();

            //whileloop whileLoop = new whileloop();
            //whileLoop.WhileLoop();

            //randomclass randomClass = new randomclass();
            //randomClass.RandomClass();

            //doloops doLoop = new doloops();
            //doLoop.DoLoop();

            //iterationexercises iterationExercises = new iterationexercises();
            //iterationExercises.Exercise1();
            //iterationExercises.Exercise2();
            //iterationExercises.Exercise3();
            //iterationExercises.Exercise4();
            //iterationExercises.Exercise5();

            ////************Arrays***********
            //arrays arrayDemo = new arrays();
            //arrayDemo.ArraysDemo();

            ////*********Lists**************
            ////lists list = new lists();
            ////list.Lists();

            ////********Array and List Execies*************
            //array_list_exercise exercise = new array_list_exercise();
            //exercise.ArrayAndListEx();

            //******Working with Dates***************
            //DateT dateT = new DateT();
            //dateT.dateTm();

            //TimeS timeS = new TimeS();
            //timeS.timespan();

            //DateT_exercise dateTExercise = new DateT_exercise();
            //dateTExercise.dateTimeExercise();

            //timespan_exercise timespan = new timespan_exercise();
            //timespan.timeSpanExercise();

            //********Working with text *****************
            //text_string textString = new text_string();
            //textString.tString();

            //summarising_text summarisingText = new summarising_text();
            //summarisingText.summarising();

            //string sentence = "This is going to be a really really really really long text.";
            ////string summary = SummerizeText(sentence); //We can create a variable to call our method
            //string summary = StringUtility.SummerizeText(sentence, 25); //We can change the maxlength here 
            //Console.WriteLine(summary);

            //stringbuilder stringBuilder = new stringbuilder();
            //stringBuilder.stringBuilder();

            //exercise_1 ex1 = new exercise_1();
            //ex1.Ex1();

            exercise_2 ex2 = new exercise_2();
            ex2.Ex2();

            //exercise_3 ex3 = new exercise_3();
            //ex3.Ex3();

            //exercise_4 ex4 = new exercise_4();
            //ex4.Ex4();

            //exercise_5 ex5 = new exercise_5();
            //ex5.Ex5();





        }

        

    }
}
