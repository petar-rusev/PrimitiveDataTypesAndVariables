using System;
using System.Globalization;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double diff = 0;
        double[] a = {5.3,5.00000001,-0.0000007,-4.999999};
        double[] b = {6.01,5.00000003,0.00000007,-4.999998};

        int flag;

        for (int i = 0; i < a.Length; i++)
        {
            diff = Math.Abs(a[i] - b[i]);
            
            if (diff > eps | diff==eps)
            {
                flag = 1;
                 
            }
            else
            {
                flag = 2;
            }
            switch (flag)
            {
                case 1:
                    Console.WriteLine("Tne numbers {0:f8} and {1:f8} are not equal!\nExplanation: The difference between the numbers is greater than 0.000001!\n",a[i],b[i]);
                    break;
                case 2:
                    Console.WriteLine("Tne numbers {0:f8} and {1:f8} are equal!\nExplanation: The difference between the numbers is less than 0.000001!\n", a[i], b[i]);
                    break;
                
            }
            
        }
        
    }
}

