using System;

namespace task1
{
    public class ZString
    {
        public string InitialString { get; set; }

        private string[] Words { get; set; }
        
        public void ReverseString()
        {
            Words = InitialString.Split(' ');

            Array.Reverse(Words);
        }

        public void ShowString()
        {
            if (Words.Length == 1)
            {
                Console.WriteLine("There is only one word or the string is empty!");
            }
            else
            {
                foreach (var word in Words)
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}