class Program
{
    private static DateTime t;
    private static string fp = "";
    private static int lv = 100000000;

    static void Main(string[] args)
    {
        t = DateTime.Now;
        int c = new DirectoryInfo(Environment.CurrentDirectory).GetFiles().Where(a => a.Name.StartsWith("result")).Count();
        fp = $"result{c + 1}.txt";
        File.AppendAllText(fp, $"Start program! - Limit value {lv}{Environment.NewLine}");
        for (int i = 0; i <= lv; i++)
        {
            me(i);
        }
        Console.WriteLine("End");
        Console.ReadLine();
    }

    private static void me(int @in)
    {
        int l = 1;
        int k = 10;
        int x = 0;

        while (true)
        {
            if (@in < k) break;
            l++;
            k = k * 10;
        }
        int[] i = new int[l];
        int t = @in;
        while (k >= 1)
        {
            if (t >= k)
            {
                i[x] = (t / k);
                x++;
            }
            t = t % k;
            k = k / 10;
        }

        int m = 0;
        for (int n = 0; n < i.Length; n++)
        {
            m += P(i[n], l);
        }

        if (@in == m)
        {
            TimeSpan el = DateTime.Now - Program.t;
            Console.WriteLine(m + ": Ellapsed: " + el);
            File.AppendAllText(fp, m + ": Ellapsed: " + el + Environment.NewLine);
        }
    }

    private static int P(int @in, int l)
    {
        int a = @in;
        for (int i = 1; i < l; i++) @in = @in * a;
        return @in;
    }
}