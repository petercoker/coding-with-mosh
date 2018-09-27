using System;
using System.IO;
using System.Runtime.InteropServices;

namespace mosh_csharp_basic.working_with_files.working_with_files_exercises
{
    class filesex1
    {
        //1- Write a program that reads a text file and displays the number of words.

        public void GetFileEx1()
        {
            string file = "/c/Users/sonol/Downloads/file";

            FileInfo numOfWords = new FileInfo(file);


            if (File.Exists(file))
            {
                Console.WriteLine("it lit");
            }
            

        }

        public void ppGetFileEx1()
        {

        }
    }
}
