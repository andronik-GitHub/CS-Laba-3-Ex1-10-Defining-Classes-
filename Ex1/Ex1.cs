using System;

class Ex1
{
    static void Main()
    {
        Person person = new Person();
        Person Pesho = new("Pesho", 20);
        Person Gosho = new("Gosho", 18);
        Person Stamat = new("Stamat", 43);

        Console.WriteLine($"Person: {person.Name}, age: {person.Age}");
        Console.WriteLine($"Person: {Pesho.Name}, age: {Pesho.Age}");
        Console.WriteLine($"Person: {Gosho.Name}, age: {Gosho.Age}");
        Console.WriteLine($"Person: {Stamat.Name}, age: {Stamat.Age}");

        Console.ReadKey();
    }
}