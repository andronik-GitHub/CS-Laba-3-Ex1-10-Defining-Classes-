using System;

class Ex7
{
    static void Main()
    {
        Console.Write("N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Car[] car = new Car[N];
        Car car1 = new();


        Console.WriteLine();
        car1.InputCar(car);

        Console.WriteLine();
        car1.DriveCar(car);

        Console.WriteLine();
        car1.OutputCar(car);


        Console.ReadKey();
    }
}