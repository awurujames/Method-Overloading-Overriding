﻿// C# program to demonstrate the function  
// overloading by changing the Data types 
//  of the parameters  
using System;
class GFG
{

    // adding three integer values. 
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    // adding three double values. 
    public double Add(double a, double b, double c)

    {
        double sum = a + b + c;
        return sum;
    }

    // Main Method 
    public static void Main(String[] args)
    {

        // Creating Object 
        GFG ob = new GFG();

        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three " + "integer value : " + sum2);

        double sum3 = ob.Add(1.0, 2.0, 3.0);
        Console.WriteLine("sum of the three " + "double value : " + sum3);

    }
}