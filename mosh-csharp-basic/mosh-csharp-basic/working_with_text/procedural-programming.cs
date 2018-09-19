using System;
using System.Collections.Generic;

namespace mosh_csharp_basic.working_with_text
{
    class Procedural_Programming
    {
        public void procedural()
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            char[] array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            string reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

        }
    }
}
