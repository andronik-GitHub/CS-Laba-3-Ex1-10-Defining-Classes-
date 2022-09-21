using System;

class Rectangle
{
    public string? id;
    public float? width;
    public float? height;
    public float? X;
    public float? Y;

    public void Input(Rectangle[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == null)
                Array[i] = new Rectangle();

            Console.Write("id: ");
            Array[i].id = Console.ReadLine();


            Console.Write("Width: ");
            Array[i].width = Convert.ToSingle(Console.ReadLine());

            Console.Write("Height: ");
            Array[i].height = Convert.ToSingle(Console.ReadLine());


            Console.Write("X: ");
            Array[i].X = Convert.ToSingle(Console.ReadLine());

            Console.Write("Y: ");
            Array[i].Y = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine();
        }
    }

    public bool Check(Rectangle rectangle)
    {
        if ((rectangle.X >= X && rectangle.Y >= Y && rectangle.X <= X + width && rectangle.Y <= Y + height) ||

            (rectangle.X + rectangle.width >= X && rectangle.Y >= Y && rectangle.X + rectangle.width <= X + width && rectangle.Y <= Y + height) ||

            (rectangle.X >= X && rectangle.Y + rectangle.height >= Y && rectangle.X <= X + width && rectangle.Y + rectangle.height <= Y + height) ||

            (rectangle.X + rectangle.width >= X && rectangle.Y + rectangle.height >= Y && 
            rectangle.X + rectangle.width <= X + width && rectangle.Y + rectangle.height <= Y + height))
            return true;

        return false;
    }

    public Rectangle()
    {
        id = new string("");

        X = Y = height = width = 0.0f;
        
    }
}