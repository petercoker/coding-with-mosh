using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace mosh_csharp_basic.working_with_text.exercise_with_working_with_text
{
    public class exercise_1
    {
        public void Ex1()
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //string[] elements;
            //string input;
            //List<int> numbers = new List<int>();

            //while (true)
            //{
            //    Console.Write("Enter a few numbers seprated by hyphen: ");
            //    input = Console.ReadLine();

            //    elements = input.Split('-');

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //}

            //foreach (var element in elements)
            //{
            //    numbers.Add(Convert.ToInt32(element));
            //}

            //foreach (var number in numbers)
            //{
            //    if (numbers[0] < numbers[1])
            //    {
            //        Console.WriteLine("Consecutive");
            //        break;
            //    }

            //    else 
            //    {
            //        Console.WriteLine("Not Consecutive");
            //        break;

            //    }
            //}

            //*****Mosh's Answer****

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();

            foreach (string number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            Boolean isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            string message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);


        }

        public bool IsConsecutiveList(List<int> list)
        {
            // Note that I've copied the list to a new array because I didn't want callign Sort()
            // impact the argument of this method. Caller of this method only expects a true/false answer 
            // as a result of this call. So, this method should not have a side-effect.
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }

            return true;
        }
    }
}


