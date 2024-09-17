using System;

class Program
{
    static void Main()
    {
        double x0 = 0, y0 = 3; 
        double R = 3; 
        
        double x1 = 3, y1 = 3;
        double x2 = 12, y2 = 0;

        int xStart = -6, xEnd = 12;
        double dx = 1; 

        Console.WriteLine(" x\t| y");
        Console.WriteLine("----------------");

        double x = xStart;

        while (x <= xEnd)
        {
            double y;

            if (x >= -6 && x <= -4)
            {
                y = -2;
            }
            else if (x > -4 && x <= 0) // Второй сегмент
            {
                y = -2 + 0.5 * (x + 4);
            }
            else if (x > 0 && x <= 2) // Третий сегмент: парабола
            {
                y = x*x;
            }
            else if (x > 2 && x <= 12) 
            {
                y = 4 + (x - 2) * (-1 - 4) / (12 - 2);
            }
            else
            {
                y = double.NaN; 
            }
               
            Console.WriteLine($"{x}\t| {y:F2}");

            x += dx;
        }
    }
}
