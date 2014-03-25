using System;

class QuotesInStrings
{
    static void Main()
    {
        string a = "The use of quotations causes difficulties.";
        string b = "The" + ' ' + '"' + "use" + '"' + " of quotations causes dificulties.";
        Console.WriteLine("{0}\n{1}",a,b);
    }
}

