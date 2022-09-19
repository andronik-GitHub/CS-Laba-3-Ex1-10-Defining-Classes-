using System;
using System.Xml.Linq;

class Employee
{
    public string? Name;
    public float? Salary;
    public string? Position;
    public string? Department;
    public string? Email;
    public int? Age;

    public static bool CheckToNull(string? name, ref string? str)
    {
        while (str == null)
        {
            Console.WriteLine($"{name} is \"null\"! repeat input!");
            str = Console.ReadLine();
        }
        return true;
    }

    public static void Inpug(Employee[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
                array[i] = new();

            Console.Write("Name: ");
            string? tempStr = Console.ReadLine();
            if (CheckToNull("Name", ref tempStr))
                array[i].Name = tempStr;

            Console.Write("Salary: ");
            float? tempFloat = Convert.ToSingle(Console.ReadLine());
            while (tempFloat == null)
            {
                Console.WriteLine($"Salary is \"null\"! repeat input!");
                tempFloat = Convert.ToSingle(Console.ReadLine());
            }
            array[i].Salary = tempFloat;

            Console.Write("Position: ");
            tempStr = Console.ReadLine();
            if (CheckToNull("Position", ref tempStr))
                array[i].Position = tempStr;

            Console.Write("Department: ");
            tempStr = Console.ReadLine();
            if (CheckToNull("Department", ref tempStr))
                array[i].Department = tempStr;

            Console.Write("Email: ");
            array[i].Email = Console.ReadLine();

            Console.Write("Age: ");
            array[i].Age = Convert.ToInt32(Console.ReadLine());
        }
    }

    public Employee () { 

    }
}
