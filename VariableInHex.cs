using System;

class VariableInHex
{
    static void Main()
    {
        string Var = "FE";
        int value = Convert.ToInt32(Var, 16);
        Console.WriteLine(value);
    }
}

