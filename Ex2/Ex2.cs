using System;

class Ex2
{
    static void Main()
    {
        Person one = new();
        Person two = new(18);
        Person three = new("Tom", 49);


        Console.WriteLine($"Person: {one.Name} - age: {one.Age}");
        Console.WriteLine($"Person: {two.Name} - age: {two.Age}");
        Console.WriteLine($"Person: {three.Name} - age: {three.Age}");

        Console.ReadLine();
    }
}