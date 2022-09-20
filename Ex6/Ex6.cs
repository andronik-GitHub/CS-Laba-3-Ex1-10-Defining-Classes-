using System;

class Ex6
{
    static void Main()
    {
        Console.Write("Num: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Employee[] employee = new Employee[size];
        Employee employee1 = new();


        Console.WriteLine();
        employee1.Input(employee);
        employee1.Output(employee);


        Console.ReadKey();
    }
}