using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter the year you were born");
        int birthYear = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;
        int ageNow;
        int ageAfter;
        ageNow = currentYear - birthYear;
        ageAfter = ageNow + 10;
        Console.WriteLine("Your age now is {0} and your age in 10 years will be {1}", ageNow, ageAfter);
    }
}

