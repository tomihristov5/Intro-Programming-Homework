using System;

class PrintASequence
{
    static void Main()
    {
        int number = 2;
        for (int counter = 0; counter <= 9; counter++)
        {
            Console.WriteLine((number % 2 == 0 ? number : -number) + ",");
            number++;
        }
    }
}

