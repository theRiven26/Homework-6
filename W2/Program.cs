/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

using static Common.Helper;
double b1 = UserInputDouble("Enter b1");
double k1 = UserInputDouble("Enter k1");
double b2 = UserInputDouble("Enter b2");
double k2 = UserInputDouble("Enter k2");

if (k1 == k2)
{
	Console.WriteLine("it is impossible to find the coordinates of the point of intersection of the given lines, since these lines are parallel.");
}

GetPointCoordinates(k1, k2, b1, b2, out double x, out double y);
Console.WriteLine($"({x};{y})");

void GetPointCoordinates(double k1, double k2, double b1, double b2, out double x, out double y)
{
	double x = (b1 - b2) / (k2 - k1);
	double y = (k2 * x + b2);
}
