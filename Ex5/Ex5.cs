using System;

class Ex5
{
    static void Main()
    {
        DateModifier date = new();


        date.Input();

        Console.WriteLine();

        if (date.FirstDate != null && date.LastDate != null)
            DateModifier.DifferenceInDay(date.FirstDate, date.LastDate);


        Console.ReadKey();
    }
}