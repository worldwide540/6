using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        input = input.ToLower(); // Приводим строку к нижнему регистру для учета регистра символов
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static void Main()
    {
        string testString = "radar";
        Console.WriteLine($"Строка '{testString}' является палиндромом: {IsPalindrome(testString)}");
    }
}

