using System;

class Ex3
{
    static void Main()
    {
        Console.Write("Members family: ");
        int membersFamily = Convert.ToInt32(Console.ReadLine());

        Family family = new(membersFamily);

        family.AddMember();

        Console.WriteLine();

        family.GetOldestMember();

        Console.ReadKey();
    }
}