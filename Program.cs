using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 2, 3, 4, 5, 1};

        int maxLen = 1;
        int currLen = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
                currLen++;
            else
                currLen = 1;

            if (currLen > maxLen)
                maxLen = currLen;
        }

        Console.WriteLine("Max uzunluq: " + maxLen);
    }
}
