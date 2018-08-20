using System;

namespace mosh_csharp_basic.arrys_and_lists
{
    class arrays
    {
        public void ArraysDemo()
        {
            int[] numbers = new int[] {3, 7, 9, 2, 14, 6};
            //var numbers = new[] {3, 7, 9, 2, 14, 6};

            // Length(): This method is used to find the legnth of the Array
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf(): This method is used to find the position in the Array
            int index = Array.IndexOf(numbers, 9);

            //var index = Array.IndexOf(numbers, 9); 
            Console.WriteLine("Index of 9: " + index); //Output 9 is the 3rd element in the array

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];

            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()

            Array.Reverse(numbers);

            Console.WriteLine("Effect of reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}
