// [fix me replace all dots]
// [8 kyu]
// [c#]
using System.Text.RegularExpressions;
public class Kata
{
public static string ReplaceDots(string str)
{
return new Regex("\\.").Replace(str, "-");
}
}