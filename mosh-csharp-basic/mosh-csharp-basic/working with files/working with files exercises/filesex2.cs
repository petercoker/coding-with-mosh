using System;
using System.IO;

namespace mosh_csharp_basic.working_with_files.working_with_files_exercises
{
    class filesex2
    {
        //2- Write a program that reads a text file and displays the longest word in the file.

        public void GetFileEx2()
        {
            //Exercise 2


            string path = @"c:\temp\CSharpTestFile.txt";


            string[] dataFromFile = File.ReadAllLines(path);


            string tempWord = "";

            string[] tempString;

            string longestWord = " ";


            foreach (string word in dataFromFile)

            {

                tempWord = word.Trim(' ');

                tempString = tempWord.Split(new char[] { '"', ',', '.', '!', '?', ';', ':', ' ' });


                foreach (string word2 in tempString)

                {



                    if (word2.Length > longestWord.Length)

                    {


                        longestWord = word2;

                    }

                }

            }


            Console.WriteLine("The longest word is : " + longestWord);

        }

        public void ppGetFileEx2()
        {

        }
    }
}
