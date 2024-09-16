using System;

class Program
{
    static void Main()
    {
        double xStart = -9;
        double xEnd = 9;
        double dx = 1;

        double x01 = -6, y01 = 0, R1 = 3;

        double x2_1 = -3, y2_1 = 0;
        double x2_2 = 0, y2_2 = 3;

        double x3_1 = 3, y3_1 = -3;
        double x3_2 = 9, y3_2 = 3;

        double x03 = 0, y03 = 0, R3 = 3;

        Console.WriteLine(" x\t y");
        Console.WriteLine("----------------");

        double x = xStart;

        while (x <= xEnd)
        {
            double y;

            if (x >= -9 && x <= -6)
            {
                y = y01 - Math.Sqrt(R1 * R1 - Math.Pow(x - x01, 2));
            }
            else if (x > -6 && x <= -3)
            {
                y = ((y2_2 - y2_1) / (x2_2 - x2_1)) * (x - x2_1) + y2_1;
            }
            else if (x > -3 && x <= 0)
            {
                y = y03 + Math.Sqrt(R3 * R3 - Math.Pow(x - x03, 2));
            }            else if (x > 0 && x <= 3)
            {
                y = -x + 3; 
            }
            else if (x > 3 && x <= 9)
            {
                y = (1.0 / 2.0) * (x - 3);  
            }
            else
            {
                y = 0;
            }

            Console.WriteLine($"{x:F2}\t {y:F2}");

            x += dx;
        }
    }
}
