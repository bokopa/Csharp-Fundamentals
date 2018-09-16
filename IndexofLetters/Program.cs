using System;

namespace IndexofLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            char[] alphabet = new char[26];
            int index = 0;
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                char currentLetter = letter;
                alphabet[index] = currentLetter;

                index++;

            }
            for (int i = 0; i < inputWord.Length; i++)
            {
                char currentLetter = inputWord[i];
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == currentLetter)
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    }
                }
            }
        }
    }
}
