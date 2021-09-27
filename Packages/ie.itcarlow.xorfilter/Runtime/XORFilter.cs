public class XORFilter
{
    public static int XOR21(int x)
    {
        return (x ^ 21);
    }

    public static int[] XOR21s(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = XOR21(xs[i]);
        }
        return result;
    }
}
