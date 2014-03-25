using System;

class IsoscelesTriangle
{
    
    static void Main()
    {
        char uni = '\u00a9';
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char[,] iso = new char[7, 4];
        for (int i = 0; i < 7; i++)
        {
            for (int x = 0; x < 4; x++)
            {
                iso[i, x] = uni;

            }

        }


        for (int hor = 0; hor < 7; hor++)
        {
            if (hor > 1 & hor < 3)
            {
                Console.Write(" {0}", iso[hor, 3]);
            }
            else
            {
                Console.Write(" ");

            }

        }
        Console.WriteLine();

        for (int hor = 0; hor < 7; hor++)
        {
            if (hor > 1 & hor < 3 | hor > 3 & hor < 5)
            {
                Console.Write("{0}", iso[hor, 2]);
            }
            else
            {
                Console.Write(" ");

            }

        }
        Console.WriteLine();

        for (int hor = 0; hor < 7; hor++)
        {
            if (hor > 0 & hor < 2)
            {
                Console.Write("{0}", iso[hor, 1]);
            }
            else if (hor > 3 & hor < 5)
            {
                Console.Write(" {0}", iso[hor, 1]);
            }
            else
            {
                Console.Write(" ");

            }

        }
        Console.WriteLine();

        for (int hor = 0; hor < 7; hor++)
        {
            if (hor % 2 == 0)
            {
                Console.Write("{0}", iso[hor, 0]);
            }
            else if (hor % 2 > 0)
            {
                Console.Write(" ");

            }

        }
        Console.WriteLine();

    }

}



