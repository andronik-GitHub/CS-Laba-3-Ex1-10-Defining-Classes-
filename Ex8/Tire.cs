using System;

class Tire
{
    public float? Tire1Pressure;
    public int? Tire1Age;

    public float? Tire2Pressure;
    public int? Tire2Age;

    public float? Tire3Pressure;
    public int? Tire3Age;

    public float? Tire4Pressure;
    public int? Tire4Age;


    public Tire (int? T1A = 0, float? T1P = 0.0f, 
                int? T2A = 0, float? T2P = 0.0f, 
                int? T3A = 0, float? T3P = 0.0f, 
                int? T4A = 0, float? T4P = 0.0f)
    {
        Tire1Age = T1A;
        Tire2Age = T2A;
        Tire3Age = T3A;
        Tire4Age = T4A;

        Tire4Pressure = T1P;
        Tire3Pressure = T2P;
        Tire2Pressure = T3P;
        Tire1Pressure = T4P;
    }
}