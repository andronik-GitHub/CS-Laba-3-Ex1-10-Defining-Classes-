using System;

class Family
{
    public static int numberPeople = 1;

    public Person[] person;


    public void AddMember()
    {
        for (int i = 0; i < numberPeople; i++)
        {
            Console.Write("Name: ");
            person[i].Name = Console.ReadLine();

            Console.Write("Age: ");
            person[i].Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
    }

    public void GetOldestMember()
    {
        int oldMemberIndex = person[0].Age;

        for (int i = 0; i < numberPeople; i++)
            if (person[i].Age > oldMemberIndex)
                oldMemberIndex = person[i].Age;

        for (int i = 0; i < numberPeople; i++)
            if (person[i].Age == oldMemberIndex)
                Console.WriteLine($"Oldest Member Family: {person[i].Name} {person[i].Age}");
    }


    public Family(int num = 1) { 
        numberPeople = num; 

        person = new Person[numberPeople];

        for (int i = 0; i < numberPeople; i++)
            if (person[i] == null)
                person[i] = new Person();
    }
}