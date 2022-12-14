using System;

class Car
{
    public string? OutputName { get; set; }
    public string? OutputMeaning { get; set; }

    public string? Model;
    public string? Weight;
    public string? Color;

    Engine engine;

    public static bool CheckToNull(string? name, ref string? str)
    {
        while (str == null)
        {
            Console.WriteLine($"{name} is \"null\"! Repeat input!");
            str = Console.ReadLine();
        }
        return true;
    }

    public void InputCar(Car[] ArrayCar, Engine[] ArrayEngine)
    {
        for (int i = 0; i < ArrayEngine.Length; i++)
            if (ArrayEngine[i] == null)
                ArrayEngine[i] = new();

        for (int i = 0; i < ArrayCar.Length; i++)
        {
            if (ArrayCar[i] == null)
                ArrayCar[i] = new();


            Console.Write("Model: ");
            string? tempStr = Console.ReadLine();
            if (CheckToNull("Model", ref tempStr))
                ArrayCar[i].Model = tempStr;

            Console.Write("Engine model: ");
            tempStr = Console.ReadLine();
            if (CheckToNull("Engine", ref tempStr))
            {
                int TempCount = 0;
                for (int j = 0; j < ArrayEngine.Length; j++)
                    if (ArrayEngine[j].Model == tempStr)
                        ArrayCar[i].engine = ArrayEngine[j];
                    else TempCount++;

                if (TempCount == ArrayEngine.Length)
                {
                    while (true)
                    {
                        TempCount = 0;

                        Console.WriteLine("This engine model not found, repeat input!");
                        Console.Write("Engine: ");
                        tempStr = Console.ReadLine();
                        CheckToNull("Engine", ref tempStr);

                        for (int j = 0; j < ArrayEngine.Length; j++)
                            if (ArrayEngine[j].Model == tempStr)
                                ArrayCar[i].engine = ArrayEngine[j];
                            else TempCount++;

                        if (TempCount != ArrayEngine.Length) break;
                    }
                }
            }

            Console.Write("Weight: ");
            ArrayCar[i].Weight = Console.ReadLine();

            Console.Write("Color: ");
            ArrayCar[i].Color = Console.ReadLine();


            Console.WriteLine();
        }
    }

    public void OutputCar(Car[] ArrayCar)
    {
        for (int i = 0; i < ArrayCar.Length; i++)
            Console.WriteLine($"{ArrayCar[i]}\n");
    }

    public override string ToString()
    {
        return Model + ":" +
            "\n   " + engine.Model + ":" +
            "\n      Power: " + engine.Power + 
            "\n      Displacement: " + (String.IsNullOrEmpty(engine.Displacement) ? "n/a" : engine.Displacement) + 
            "\n      Efficiency: " + (String.IsNullOrEmpty(engine.Efficiency) ? "n/a" : engine.Efficiency) + 
            "\n   Weight: " + (String.IsNullOrEmpty(Weight) ? "n/a" : Weight) + 
            "\n   Color: " + (String.IsNullOrEmpty(Color) ? "n/a" : Color);
    }

    public Car()
    {
        Model = Weight = Color = new string("");
        engine = new Engine();
    }
}