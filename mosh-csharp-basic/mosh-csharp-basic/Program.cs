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

            //exercise_2 ex2 = new exercise_2();
            //ex2.Ex2();

            //exercise_3 ex3 = new exercise_3();
            //ex3.Ex3();

            //exercise_4 ex4 = new exercise_4();
            //ex4.Ex4();

            //exercise_5 ex5 = new exercise_5();
            //ex5.Ex5();

            //Procedural_Programming procedural = new Procedural_Programming();
            //procedural.procedural();

           
        }

         ////***************Procedural_Programming**********
        /// <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        public void Exercise1()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

        // <summary>
        //Ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        //</summary>
        //public void Exercise2()
        //{
            //Console.Write("What's your name? ");
            //string name = Console.ReadLine();

            ////char[] array = new char[name.Length];
            ////for (int i = name.Length; i > 0; i--)
            ////    array[name.Length - i] = name[i - 1];

            //string reversed = ReverseName(name); //We can our new method


            //Console.WriteLine("Reversed name: " + reversed);

        //}

        //public static string ReverseName(string name)
        //{
            //char[] array = new char[name.Length];
            //for (int i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            ////This a bit of noise becuase the main of the method ReverseName that what is coming out 
            ////Out of this ReverseName method is the name so we don't need ot store it in separte variable

            //string reversed = new string (array);
            //return reversed; 

            //This way the method is shorter and eassier to understand
            //return new string(array);
        //}

        // <summary>
        // Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display 
        // an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        // and display the result on the console.
        // </summary>

        //public void Exercise3()
        //{
        //    var numbers = new List<int>();

        //    while (numbers.Count < 5)
        //    {
        //        Console.Write("Enter a number: ");
        //        int number = Convert.ToInt32(Console.ReadLine());
        //        if (numbers.Contains(number))
        //        {
        //            Console.WriteLine("You've previously entered " + number);
        //            continue;
        //        }

        //        numbers.Add(number);
        //    }

        //    numbers.Sort();

        //    foreach (var number in numbers)
        //        Console.WriteLine(number);
        //}

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        //public void Exercise4()
        //{
        //    List<int> numbers = new List<int>();
        //    const string quit = "Quit";
        //    int number = 0;

        //    while (true)
        //    {
        //        Console.Write("Enter a number or type \"Quit\": ");
        //        string input = Console.ReadLine();

        //        if (input == "quit")
        //        {
        //            break;
        //        }

        //        numbers.Add(Convert.ToInt32(input));
        //    }

        //List<int> uniqueNumbers = getUniqueNumbers(numbers); //We can simply can this inside the foreach block

        //    Console.WriteLine();
        //    Console.WriteLine("List of unique numbers user entered");
        //    foreach (var uniqueNumber in getUniqueNumbers(numbers))
        //    {
        //        Console.WriteLine(uniqueNumber);
        //    }
        //}

        //public static List<int> getUniqueNumbers(List<int> numbers)
        //{
        //    List<int> uniques = new List<int>();
        //    foreach (var unique in numbers)
        //    {
        //        if (!uniques.Contains(unique))
        //        {
        //            uniques.Add(unique);
        //        }
        //    }

        //    return uniques;
        //}


        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        public void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            List<int> numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            List<int> smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }

       

        



    }
}
