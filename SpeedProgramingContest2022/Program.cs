class Program
{
    private static DateTime t;

    static void Main(string[] args)
    {
        t = DateTime.Now;
        for (int i = 0; i <= int.MaxValue; i++)
        {
            me(i);
        }
        Console.WriteLine("End");
        Console.ReadLine();
    }

    private static void me(int @in)
    {
        List<int> i = new List<int>();
        int l = 1;
        int k = 10;

        while (true)
        {
            if (@in < k) break;
            l++;
            k = k * 10;
        }

        int t = @in;
        while (k >= 1)
        {
            if (t >= k)
                i.Add(t / k);
            t = t % k;
            k = k / 10;
        }

        int m = 0;
        for (int n = 0; n <= i.Count - 1; n++)
        {
            m += P(i[n], l);
        }

        if (@in == m)
        {
            TimeSpan el = DateTime.Now - Program.t;
            Console.WriteLine(m + ": Ellapsed: " + el);
        }
    }

    private static int P(int @in, int l)
    {
        int o = @in;
        for (int i = 1; i < l; i++)
        {
            @in = @in * o;
        }
        return @in;
    }
}