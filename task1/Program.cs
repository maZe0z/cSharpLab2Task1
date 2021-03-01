using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ZString zString = new ZString();
            
            Console.WriteLine("Enter a string to reverse:");

            zString.InitialString = Console.ReadLine();
            
            zString.ReverseString();
            
            zString.ShowString();
        }
    }
}