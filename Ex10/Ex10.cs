using System;

class Ex10
{
    static void Main()
    {
        Console.Write("N: ");
        int N_M = Convert.ToInt32(Console.ReadLine());

        Engine[] engines = new Engine[N_M];
        for (int i = 0; i < N_M; i++)
            if (engines[i] == null)
                engines[i] = new();

        Console.WriteLine();
        engines[0].InputEngine(engines);


        Console.Write("\nM: ");
        N_M = Convert.ToInt32(Console.ReadLine());

        Car[] car = new Car[N_M];
        for (int i = 0; i < N_M; i++)
            if (car[i] == null)
                car[i] = new();

        Console.WriteLine();
        car[0].InputCar(car, engines);

        Console.WriteLine();
        car[0].OutputCar(car);


        Console.ReadKey();
    }
}