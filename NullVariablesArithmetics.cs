using System;

class NullVariablesArithmetics
{
    static void Main()
    {
        int? IntegerNull = null;
        double? DoubleNull = null;
        Console.WriteLine("IntegerNull:{0}\nDoubleNull:{1}\n",IntegerNull,DoubleNull);
        int IntNumber = 10;
        double DoubNumber = 543.2;

        int result = IntegerNull.GetValueOrDefault()+IntNumber;
        double resulttwo = DoubleNull.GetValueOrDefault() + DoubNumber;
        Console.WriteLine("The IntegerNull after added a number 10: {0}\nThe DoubleNull after added a number 543.2: {1}",result,resulttwo);

    }
}

