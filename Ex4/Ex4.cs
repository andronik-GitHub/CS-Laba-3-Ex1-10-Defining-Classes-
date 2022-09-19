using System;

class Ex4
{
    static void Main()
    {
        Console.Write("n: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Person[] person = new Person[num];

        for (int i = 0; i < num; i++)
        {
            if (person[i] == null)
                person[i] = new Person();

            Console.Write("Name: ");
            person[i].Name = Console.ReadLine();

            Console.Write("Age: ");
            person[i].Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }

        Array.Sort(person, (x, y) => String.Compare(x.Name, y.Name));
        Console.WriteLine();

        for (int i = 0; i < num; i++)
            if (person[i].Age >= 30)
                Console.Write($"{person[i].Name} - {person[i].Age}\n");

        Console.ReadKey();
    }
}