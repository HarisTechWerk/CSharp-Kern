using System;
using System.Collections.Generic;

class FirstUniqueCharacter
{
    public static int FindFirstUniqueCharacter(string s)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        Queue<int> queue = new Queue<int>();

        // Step 1: Count occurrences and track indices
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (!charCount.ContainsKey(c))
            {
                charCount[c] = 1;
                queue.Enqueue(i); // Add index to queue
            }
            else
            {
                charCount[c]++;
            }

            // Remove invalid (non-unique) characters from the queue
            while (queue.Count > 0 && charCount[s[queue.Peek()]] > 1)
            {
                queue.Dequeue();
            }
        }

        return queue.Count > 0 ? queue.Peek() : -1;
    }

    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int index = FindFirstUniqueCharacter(input);
        Console.WriteLine(index == -1 ? "No unique character found." : $"First unique character is at index {index}");
    }
}
