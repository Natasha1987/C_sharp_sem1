// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void intersection( double k1, double b1, double k2, double b2)
{
    double _sub = k1 - k2;
    if ((k1-k2) != 0)
    {
        double x = (b2 - b1) / (k1-k2);
        double y = k1 * x + b1;
        Console.WriteLine($"intersrction point: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
         Console.WriteLine("There are an infinite number of intersection points.");
    else
         Console.WriteLine("There is no intersection point");
}
