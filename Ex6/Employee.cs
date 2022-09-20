using System;

class Employee
{
    public string? Name;
    public float? Salary;
    public string? Position;
    public string? Department;
    public string? Email;
    public string? Age;

    // логічний метод який перевіряє строку на пустоту
    public static bool CheckToNull(string? name, ref string? str)
    {
        while (str == null)
        {
            Console.WriteLine($"{name} is \"null\"! repeat input!");
            str = Console.ReadLine();
        }
        return true;
    }

    // Метод який вводить данні в масив
    public void Input(Employee[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            // Виділяється пам'ять якщо не виділено
            if (array[i] == null)
                array[i] = new Employee();

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
            array[i].Age = Console.ReadLine();

            Console.WriteLine();
        }
    }

    // Виведення даних масива
    public void Output(Employee[] array)
    {
        float?[] avg = new float?[array.Length]; // для визначення суми зарплати по Department
        int count; // для визначення кількості однакових Department (кількість людей)

        // Цикл для визначення середнього значення по кожному Department
        for (int i = 0; i < array.Length; i++)
        {
            avg[i] = 0;
            count = 0;

            // Шукається однакові Department і сумується зарплата
            for (int j = 0; j < array.Length; j++)
                if (array[i].Department == array[j].Department)
                {
                    avg[i] += array[j].Salary;
                    count++;
                }

            avg[i] = avg[i] / count; // середнє значення
        }

        // Знаходиться максимальне середнє значення
        float? max = avg[0];
        for (int i = 0; i < avg.Length; i++)
            if (avg[i] > max) max = avg[i];



        // Сортирування та вивід працівників по однаковому Department
        for (int i = 0; i < array.Length; i++)
            if (avg[i] == max)
            {
                string? tempStr = array[i].Department;


                // Сортирування бульбашкою по спаданню
                for (int j = 1; j < array.Length; j++)
                    for (int k = 0; k < array.Length - j; k++)
                        if (array[k].Salary < array[j].Salary)
                        {
                            Employee temp = array[k];
                            array[k] = array[j];
                            array[j] = temp;
                        }


                // Вивід працівників по однаковому Department
                Console.WriteLine($"Highest Average Salary: {tempStr}");

                for (int j = 0; j < array.Length; j++)
                    if (array[j].Department == tempStr)
                    {
                        // якщо пуста строка то виводить n/a
                        string? tempStrOne;
                        if (String.IsNullOrEmpty(array[j].Email))
                            tempStrOne = "n/a";
                        else  tempStrOne = array[j].Email;

                        // якщо пуста строка то виводить -1
                        string? tempStrTwo;
                        if (String.IsNullOrEmpty(array[j].Age))
                            tempStrTwo = "-1";
                        else tempStrTwo = array[j].Age;

                        // Зарплата завжди виводиться з двома числами після коми
                        Console.WriteLine("{0} {1:0.00} {2} {3}", array[j].Name, array[j].Salary, tempStrOne, tempStrTwo);
                    }

                break;
            }
    }

    public Employee()
    {
        Email = Age = Department = Position = Name = "";
        Salary = 0.0f;
    }
}
