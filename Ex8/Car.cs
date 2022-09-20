using System;

class Car
{
    public string? Model;

    public Tire tire;
    public Cargo cargo;
    public Engine engine;

    public void InputCar(Car[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == null)
                Array[i] = new();


            Console.Write("Model: ");
            Array[i].Model = Console.ReadLine();


            Console.Write("Engine Speed: ");
            Array[i].engine.EngineSpeed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Engine Power: ");
            Array[i].engine.EnginePower = Convert.ToInt32(Console.ReadLine());


            Console.Write("Cargo Weight: ");
            Array[i].cargo.CargoWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cargo Type: ");
            Array[i].cargo.CargoType = Console.ReadLine();



            Console.Write("Tire 1 Pressure: ");
            Array[i].tire.Tire1Pressure = Convert.ToSingle(Console.ReadLine());

            Console.Write("Tire 1 Age: ");
            Array[i].tire.Tire1Age = Convert.ToInt32(Console.ReadLine());


            Console.Write("Tire 2 Pressure: ");
            Array[i].tire.Tire2Pressure = Convert.ToSingle(Console.ReadLine());
            Console.Write("Tire 2 Age: ");
            Array[i].tire.Tire2Age = Convert.ToInt32(Console.ReadLine());


            Console.Write("Tire 3 Pressure: ");
            Array[i].tire.Tire3Pressure = Convert.ToSingle(Console.ReadLine());
            Console.Write("Tire 3 Age: ");
            Array[i].tire.Tire3Age = Convert.ToInt32(Console.ReadLine());


            Console.Write("Tire 4 Pressure: ");
            Array[i].tire.Tire4Pressure = Convert.ToSingle(Console.ReadLine());
            Console.Write("Tire 4 Age: ");
            Array[i].tire.Tire4Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
    }

    public void OutputCar(Car[] Array)
    {
        Console.WriteLine("Enter type cargo \"fragile/flamable\": ");
        string? TempType = Console.ReadLine();
        Console.WriteLine();

        for (int i = 0; i < Array.Length; i++)
        {
            if (TempType == "fragile")
            {
                if (Array[i].cargo.CargoType == TempType &&
                    (Array[i].tire.Tire1Pressure < 1 ||
                    Array[i].tire.Tire2Pressure < 1 ||
                    Array[i].tire.Tire3Pressure < 1 ||
                    Array[i].tire.Tire4Pressure < 1))
                    Console.WriteLine(Array[i].Model);
            }
            else if (TempType == "flamable")
            {
                if (Array[i].cargo.CargoType == TempType && Array[i].engine.EnginePower > 250)
                    Console.WriteLine(Array[i].Model);
            }
        }
    }

    public Car()
    {
        Model = "";

        tire = new();
        cargo = new();
        engine = new();
    }
}
