// [find multiples of a number]
// [8 kyu]
// [java]
public class Multiples
{
public static int[] find(int b, int l)
{
int[] ns = new int [(int) l / b];
for (int i = 0, n = b; n <= l; i++, n += b)
{
ns[i] = n;
}
return ns;
}
}