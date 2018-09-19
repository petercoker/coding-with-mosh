using System;
using System.Collections.Generic;

namespace mosh_csharp_basic.working_with_text.procedural_programming
{
    class ex1
    {
        //Make sure Method name are readable always
        public static string ReverseName(string name)
        {
            char[] array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            ////This a bit of noise becuase the main of the method ReverseName that what is coming out 
            ////Out of this ReverseName method is the name so we don't need ot store it in separte variable

            //string reversed = new string (array);
            //return reversed; 

            //This way the method is shorter and eassier to understand
            return new string(array);
        }
    }
}
