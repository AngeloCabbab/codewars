// [return negative]
// [8 kyu]
// [c#]
using System;
public static class Kata
{
public static int MakeNegative(int number)
{
if (number <= 0) 
{
return number;
} else 
{
return -number;
}
}
}