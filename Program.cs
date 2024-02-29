using System;

class Program
{
    static void Main()
    {
        int sideLength = 5; // Довжина сторони квадрата
        char symbol = '*'; // Символ для відображення квадрата
        DrawSquare(sideLength, symbol);
    }

    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
}
