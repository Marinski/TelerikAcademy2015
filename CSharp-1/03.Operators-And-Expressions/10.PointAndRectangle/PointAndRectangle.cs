using System;

class PointAndRectangle
{
    static void Main()
    {
        Console.Write("Enter value for X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value for Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        // A circle can be defined by a single point K(x,y) and a radius R.
        // If the distance D between the center and the point P(x,y) is less than the radius R, then it is inside the circle:
        // The Pythagorean Theoreom:
        //  C² = A² + B² and C = SQRT(A² + B²)
        //  D = SQRT( ABS(Cx - Px)² + ABS(Cy - Py)²)
        //
        //  IF( D <= R ) THEN
        //      point P is inside the circle with center C and radius R
        //  ELSE
        //      nope
        //  ENDIF
        int Kx = 1;
        int Ky = 1;
        double r = 1.5d;
        bool inCircle = Math.Pow((x - Kx), 2) + Math.Pow((y - Ky), 2) <= Math.Pow(r, 2);

        // A rectangle can be defined by two points representing the opposing corners, eg: A(x,y) and C(x,y).
        // If you have a point G(x,y) that you want to test to see if it is inside the rectangle then:
        //  
        //  IF( (Gx BETWEEN Ax AND Cx) AND (Gy BETWEEN Ay AND Cy) ) THEN
        //    point C is in the rectangle defined by opposite points A and C
        //  ELSE
        //    nope
        //  ENDIF
        bool outRect = ((x < -1) || (x > 5) || (y < -1) || (y > 1));
        bool ifTrue = inCircle && outRect;
        Console.WriteLine(ifTrue ? "Point ({0}, {1}) is inside circle K and outside rectangle R" : "Point ({0}, {1}) isn't inside circle K and outside rectangle R at the same time", x, y);
    }
}