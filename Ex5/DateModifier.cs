using System;

class DateModifier
{
    public string? FirstDate;
    public string? LastDate;

    public void Input()
    {
        Console.WriteLine("YYYY/MM/DD\n");
        Console.Write("First Date: ");
        FirstDate = Console.ReadLine();

        Console.Write("Last Date: ");
        LastDate = Console.ReadLine();
    }

    public static void DifferenceInDay(string one, string two)
    {
        int FirstYear = 0;
        int FirstMonth = 0;
        int FirstDay = 0;

        int LastYear = 0;
        int LastMonth = 0;
        int LastDay = 0;

        for (int i = 0; i < one.Length; i++)
        {
            if (one[i] != ' ' && two[i] != ' ')
            {
                if (i < 4)
                {
                    FirstYear += Convert.ToInt32(Math.Pow(10, 3 - i) * (one[i] - 48));
                    LastYear += Convert.ToInt32(Math.Pow(10, 3 - i) * (two[i] - 48));
                }
                if (i > 4 && i < 7)
                {
                    if (one[i - 1] != ' ' && two[i - 1] != ' ')
                    {
                        FirstMonth += Convert.ToInt32(one[i] - 48);
                        LastMonth += Convert.ToInt32(two[i] - 48);
                    }
                    else if (one[i - 1] == ' ' && two[i - 1] == ' ')
                    {
                        if (one[i] == '0' && two[i - 1] == '0') continue;
                        else
                        {
                            FirstMonth += Convert.ToInt32((one[i] - 48) * 10);
                            LastMonth += Convert.ToInt32((two[i] - 48) * 10);
                        }
                    }
                }
                if (i > 7)
                {
                    if (one[i - 1] != ' ' && two[i - 1] != ' ')
                    {
                        FirstDay += Convert.ToInt32(one[i] - 48);
                        LastDay += Convert.ToInt32(two[i] - 48);
                    }
                    else if (one[i - 1] == ' ' && two[i - 1] == ' ')
                    {
                        if (one[i] == '0' && two[i - 1] == '0') continue;
                        else
                        {
                            FirstDay += Convert.ToInt32((one[i] - 48) * 10);
                            LastDay += Convert.ToInt32((two[i] - 48) * 10);
                        }
                    }
                }
            }
        }

        Console.Write($"{FirstYear} {FirstMonth} {FirstDay}\n");
        Console.Write($"{LastYear} {LastMonth} {LastDay}\n");

        int Difference = 0;

        for (int i = (FirstYear > LastYear ? LastYear : FirstYear); 
            i <= (FirstYear > LastYear ? FirstYear : LastYear); 
            i++)
        {
            if (i != LastYear)
                Difference += i % 4 == 0 ? 366 : 365;

            if (i == LastYear)
            {
                if (FirstMonth < LastMonth)
                    for (int j = FirstMonth; j < LastMonth; j++)
                    {
                        if (j == 2) Difference += i % 4 == 0 ? 29 : 28;
                        else if (j == 1 || j == 3 || j == 5 || j == 7 || j == 8 || j == 10 || j == 12) Difference += 31;
                        else Difference += 30;
                    }
                else if (FirstMonth > LastMonth)
                    for (int j = LastMonth; j < FirstMonth; j++)
                    {
                        if (j == 2) Difference += i % 4 == 0 ? (FirstYear == LastYear ? 29 : -29) : (FirstYear == LastYear ? 28 : -28);
                        else if (j == 1 || j == 3 || j == 5 || j == 7 || j == 8 || j == 10 || j == 12) Difference += FirstYear == LastYear ? 31 : -31;
                        else Difference += FirstYear == LastYear ? 30 : -30;
                    }
            }

            Console.WriteLine($"{Difference}");
        }

        Difference += FirstDay > LastDay ? 
            (LastYear == FirstYear ? -(LastDay - FirstDay) : LastDay - FirstDay) : 
            -(LastDay - FirstDay);


        Console.WriteLine($"\n\n{Difference}");
    }

    public DateModifier()
    {
        FirstDate = "null";
        LastDate = "null";
    }
}
