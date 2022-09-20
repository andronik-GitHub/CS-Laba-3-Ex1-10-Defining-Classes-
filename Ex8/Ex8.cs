using System;

class Ex8
{
    static void Main()
    {
        Console.Write("N: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Car[] car = new Car[num];

        for (int i = 0; i < num; i++)
            if (car[i] == null)
                car[i] = new();


        Console.WriteLine();
        car[0].InputCar(car);

        Console.WriteLine("");
        car[0].OutputCar(car);


        Console.ReadKey();
    }
}