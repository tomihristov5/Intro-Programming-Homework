using System;

class PrintLongSequence
{
    static void Main()
    {
        int number = 2;
        for (int counter = 0; counter < 999; counter++)
        {
            Console.Write((number % 2 == 0 ? number : -number) + ",");
            number++;
        }
    }
}

