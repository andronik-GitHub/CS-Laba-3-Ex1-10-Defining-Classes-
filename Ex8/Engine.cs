using System;

class Engine
{
    public int? EngineSpeed;
    public int? EnginePower;


    public Engine(int? speed = 0, int? power = 0)
    {
        EngineSpeed = speed;
        EnginePower = power;
    }
}