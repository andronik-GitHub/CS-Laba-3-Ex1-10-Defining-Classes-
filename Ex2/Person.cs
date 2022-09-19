using System;

class Person
{
    private string name = "Tom";
    private int age = 21;

    public string Name;
    public int Age;

    public Person() { Name = "No name"; Age = 1; }
    public Person(int a) { Name = "No name"; Age = a; }
    public Person(string n, int a) { Name = n; Age = a; }
}

