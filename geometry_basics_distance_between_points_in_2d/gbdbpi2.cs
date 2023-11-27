// [geometry basics distance between points in 2d]
// [8 kyu]
// [c#]
using System;
public class Kata
{
public static double DistanceBetweenPoints(Point a, Point b)
{
double squaredDistanceY = Math.Abs(a.Y - b.Y);
double squaredDistanceX = Math.Abs(a.X - b.X);
double distance = Math.Sqrt(Math.Pow(squaredDistanceY, 2) + Math.Pow(squaredDistanceX, 2));
return distance;
}
}
