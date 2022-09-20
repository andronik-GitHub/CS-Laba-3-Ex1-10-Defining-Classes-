using System;

class Car
{
    public string? Model;
    public float? FuelAmount;
    public float? FuelConsumptionFor1Km;
    public float? DistanceTraveled;

    public bool CheckToInput(Car[] Array, string? CheckStr, int Pos)
    {
        for (int i = Pos - 1; i >= 0; i--)
            if (Array[i].Model == CheckStr)
            {
                Console.WriteLine("Model repeat!\n");
                return true; 
            }
            else if (String.IsNullOrEmpty(CheckStr))
                Console.WriteLine("Line is null!");

        return false;
    }

    public void InputCar(Car[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == null)
                Array[i] = new();

            Console.Write("Model: ");
            Array[i].Model = Console.ReadLine();
            while(CheckToInput(Array, Array[i].Model, i))
            {
                Console.Write("Model: ");
                Array[i].Model = Console.ReadLine();
            }

            Console.Write("Fuel Amount: ");
            Array[i].FuelAmount = Convert.ToSingle(Console.ReadLine());

            Console.Write("Fuel Consumption For 1 Km: ");
            Array[i].FuelConsumptionFor1Km = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();
        }
    }

    public void DriveCar(Car[] Array)
    {
        string? Action = "";
        string? model = "";
        float? Distance = 0;

        while(Action != "End")
        {
            Console.Write("Action: ");
            Action = Console.ReadLine();

            if (Action == "Drive")
            {
                Console.Write("Model: ");
                model = Console.ReadLine();

                Console.Write("Distance: ");
                Distance = Convert.ToSingle(Console.ReadLine());


                int TempCount = 0;

                for (int i = 0; i < Array.Length; i++)
                    if (Array[i].Model == model)
                    {
                        TempCount++;

                        if (Array[i].FuelAmount / Array[i].FuelConsumptionFor1Km < Distance)
                            Console.WriteLine("Insufficient fuel for the drive!");
                        else
                        {
                            Array[i].FuelAmount -= Distance * Array[i].FuelConsumptionFor1Km;
                            Array[i].DistanceTraveled += Distance;
                        }
                    }

                if (TempCount == 0) Console.WriteLine("Model is not found!");
            }
            Console.WriteLine();
        }
    }

    public void OutputCar(Car[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
            Console.WriteLine("{0} {1:0.00} {2}", Array[i].Model, Array[i].FuelAmount, Array[i].DistanceTraveled);
    }

    public Car ()
    {
        Model = "";
        FuelAmount = 0;
        FuelConsumptionFor1Km = 0;
        DistanceTraveled = 0;
    }
}
