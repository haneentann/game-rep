using System.Collections;
using System.Collections.Generic;
public class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Div(int a, int b) {
        if (b == 0)
        {
            throw new System.Exception("Cannot devide by Zero");
        }
        return a / b; 
    }
}