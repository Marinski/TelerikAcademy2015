using System;

class CalcRectangles
{
    static void Main()
    {
        float rectWidth = 3f;
        float rectHeight = 4f;
        float rectPerimeter = 2 * (rectWidth + rectHeight); // p = a + b + a + b = 2 * (a + b)
        float rectArea = rectWidth * rectHeight; // s = a * b
        Console.WriteLine("Rectangle with width {0} and height {1} has permeter {2} and area {3}", rectWidth, rectHeight, rectPerimeter, rectArea);

        rectWidth = 2.5f;
        rectHeight = 3f;
        rectPerimeter = 2 * (rectWidth + rectHeight);
        rectArea = rectWidth * rectHeight;
        Console.WriteLine("Rectangle with width {0} and height {1} has permeter {2} and area {3}", rectWidth, rectHeight, rectPerimeter, rectArea);
 
        rectWidth = 5f;
        rectHeight = 5f;
        rectPerimeter = 2 * (rectWidth + rectHeight);
        rectArea = rectWidth * rectHeight;
        Console.WriteLine("Rectangle with width {0} and height {1} has permeter {2} and area {3}", rectWidth, rectHeight, rectPerimeter, rectArea);
    
    }
}