using System;

class Cargo
{
    public int? CargoWeight;
    public string? CargoType;


    public Cargo(string? type = "fragile", int? weight = 0)
    {
        CargoType = type;
        CargoWeight = weight;
    }
}