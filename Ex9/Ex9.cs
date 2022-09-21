using System;

class Ex9
{
    static void Main()
    {
        Console.Write("N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Rectangle[] rectangles = new Rectangle[N];

        for (int i = 0; i < N; i++)
            if (rectangles[i] == null)
                rectangles[i] = new Rectangle();


        Console.WriteLine();
        rectangles[0].Input(rectangles);


        for (int i = 0; i < N && M > 0; i++)
            for (int j = 0; j < N - i && M > 0; j++)
                if (rectangles[i].Check(rectangles[j]) && j != i)
                {
                    Console.WriteLine($"{rectangles[i].id} {rectangles[j].id}");
                    M--;
                }


        Console.ReadKey();
    }
}