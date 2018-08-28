using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
            
            List<String> names = new List<string>();
            string input;

            do
            {
                Console.Write("Enter a name or hit ENTER to quit: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                names.Add(input);

            } while (true);

            if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post", names[0]);
            }

            else if (names.Count == 2)
            {
                Console.WriteLine("{0}, {1} likes your post", names[0], names[1]);
            }

            else if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others likes your post", names[0], names[1], names.Count - 2);
            }

            else
            {
                Console.WriteLine();
            }

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


        }
    }
}

