using System;

class Engine
{
    public string? Model;
    public string? Power;
    public string? Displacement;
    public string? Efficiency;

    public static bool CheckToNull(string? name, ref string? str)
    {
        while (str == null)
        {
            Console.WriteLine($"{name} is \"null\"! Repeat input!");
            str = Console.ReadLine();
        }
        return true;
    }

    public void InputEngine(Engine[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == null)
                Array[i] = new();


            Console.Write("Model: ");
            string? tempStr = Console.ReadLine();
            if (CheckToNull("Model", ref tempStr))
                Array[i].Model = tempStr;

            Console.Write("Power: ");
            tempStr = Console.ReadLine();
            if (CheckToNull("Power", ref tempStr))
                Array[i].Power = tempStr;

            Console.Write("Displacement: ");
            Array[i].Displacement = Console.ReadLine();

            Console.Write("Efficiency: ");
            Array[i].Efficiency = Console.ReadLine();


            Console.WriteLine();
        }
    }

    public Engine ()
    {
        Model = Power = Displacement = Efficiency = new string("");
    }
}
