using System;
using System.IO;

namespace FileWork
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader text = new StreamReader(@"C:\Users\alexo\OneDrive\Рабочий стол\fileex\file.txt");
            string[] array = text.ReadToEnd().Split('\n');
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}