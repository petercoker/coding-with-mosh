using System;
using System.Collections.Generic;
using System.Text;

namespace mosh_csharp_basic.working_with_text.exercise_with_working_with_text
{
    public class exercise_4
    {
        public void Ex4()
        {
            //4 - Write a program and ask the user to enter a few words separated by a space.
            //    Use the words to create a variable name with PascalCase. 
            //    For example, if the user types: "number of students", display "NumberOfStudents".
            //    Make sure that the program is not dependent on the input.
            //    So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.Write("Enter a few words separted by a space e.g number of students:");
            string input = Console.ReadLine();

           
            //List<string> pascalCases = new List<string>();

            //foreach (var words in input.Split(' '))
            //{
            //    pascalCases.Add((words));
            //}
            //foreach (var n in pascalCases)
            //{
            //    Console.Write(n);
            //}

            //Console.WriteLine();

            List<char> wordList = new List<char>();

            foreach (var word in input)
            {
                wordList.Add(word);
            }
           
            List<char> pascalCases = new List<char>();
            foreach (var word in pascalCases)
            {

                if (wordList.Contains(' '))
                {
                    
                }
            }







            //for (int i = 0; i < input.Length; i++)
            //{
            //    if ()
            //    {
            //        input.ToUpper();
            //    }
            //}
            string firstWord = input.Substring(0, space);
            string lastName = input.Substring(space + 1);


        }
    }
}
