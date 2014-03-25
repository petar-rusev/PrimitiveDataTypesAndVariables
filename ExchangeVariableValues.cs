using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 1;
        Console.WriteLine("Variables Values before exchange:\na={0}\nb={1}",a,b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("Variables Values after exchange:\na={0}\nb={1}",a,b);
            
    }
}

