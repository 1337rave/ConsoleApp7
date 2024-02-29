using System;

class Program
{
    static void Main()
    {
        int number = 1221;
        bool isPalindrome = PalindromeChecker.IsPalindrome(number);
        Console.WriteLine($"Is {number} a palindrome? {isPalindrome}");
    }
}

class PalindromeChecker
{
    public static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();
        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
