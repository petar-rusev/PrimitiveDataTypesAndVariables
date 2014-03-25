using System;
using System.Text;

class PrintTheAsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        object dec;
        object hex;
        object ascii;
        
        for (int i = 0; i < 256; i++)
        {
            dec = i;
            hex = i.ToString("X");
            ascii = (char)i;


            Console.WriteLine("{0}   {1}   {2}", dec, hex, ascii);
 
        }
        
    }
}


