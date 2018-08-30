using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace mosh_csharp_basic.arrys_and_lists
{
    class array_list_exercise
    {
        public void ArrayAndListEx()
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //    If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //    If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            //    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            //    Depending on the number of names provided, display a message based on the above pattern.

            //List<String> names = new List<string>();
            //string input;

            //do
            //{
            //    Console.Write("Enter a name or hit ENTER to quit: ");
            //    input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }

            //    names.Add(input);

            //} while (true);

            //if (names.Count == 1)
            //{
            //    Console.WriteLine("{0} likes your post", names[0]);
            //}

            //else if (names.Count == 2)
            //{
            //    Console.WriteLine("{0}, {1} likes your post", names[0], names[1]);
            //}

            //else if (names.Count > 2)
            //{
            //    Console.WriteLine("{0}, {1} and {2} others likes your post", names[0], names[1], names.Count - 2);
            //}

            //else
            //{
            //    Console.WriteLine();
            //}

            //var names = new List<string>();

            //while (true)
            //{
            //    Console.Write("Type a name (or hit ENTER to quit): ");

            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    names.Add(input);
            //}

            //if (names.Count > 2)
            //    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            //else if (names.Count == 2)
            //    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            //else if (names.Count == 1)
            //    Console.WriteLine("{0} likes your post.", names[0]);
            //else
            //    Console.WriteLine();


            //2 - Write a program and ask the user to enter their name. 
            //    Use an array to reverse the name and 
            //    then store the result in a new string.
            //    Display the reversed name on the console.

            //****Answer*****
            //Console.Write("What's your name? ");
            //string name = Console.ReadLine();

            //char[] array = new char[name.Length];
            //for (int i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //string reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);


            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            char[] array = new char[name.Length];
            int i = name.Length;

            //for (int i = name.Length; i > 0; i--)
            //{
            //    array[name.Length - i] = name[i - 1];
            //}

            while (i > 0)
            {
                array[name.Length - i] = name[i - 1];
                i--;
            }
            
            string reversed = new string(array);

         

            Console.WriteLine("Reversed name: "+ reversed);

            //Array.Reverse(name);

            //string[] nameBackward = new string[inputs.Length];
            //Array.Copy(name, nameBackward, inputs.Length);

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character); 
            //}























            //3 - Write a program and ask the user to enter 5 numbers.
            //    If a number has been previously entered, display an error message and ask the user to re-try. 
            //    Once the user successfully enters 5 unique numbers, sort them and display the result on the console.



            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //    The list of numbers may include duplicates.
            //    Display the unique numbers that the user has entered.



            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //    otherwise, display the 3 smallest numbers in the list.


        }
    }
}

