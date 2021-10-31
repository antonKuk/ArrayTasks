using System;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lettersArr = {'A','B','D','F'};
            foreach (char letter in lettersArr)
            {
                Console.WriteLine($"{letter}");
            }
            char[] newLetters = new char[5];
            Array.Copy(lettersArr, newLetters, 2);
            newLetters[2] = 'C';
            Array.Copy(lettersArr,2, newLetters,3, 2);
            foreach (char letter in newLetters)
            {
                Console.Write($"{letter}");
            }
        }
    }
}
