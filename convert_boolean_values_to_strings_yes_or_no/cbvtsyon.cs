// [convert boolean values to strings yes or no]
// [8 kyu]
// [c#]
using System;
using System.Linq;
public static class Kata
{
public static string boolToWord(bool word)
{
if (word)
{
return "Yes";
} else 
{
return "No";
}
}
}